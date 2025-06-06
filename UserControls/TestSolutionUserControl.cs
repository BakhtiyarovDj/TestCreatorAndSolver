using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreatorAndSolver
{
    public partial class TestSolutionUserControl : UserControl
    {
        Query q = new Query();
        private MainForm mainForm;
        private string student_name;
        private string student_group;
        private string test_name;
        private int questionsCount;
        private int timeLeft;
        private Timer timer;
        public TestSolutionUserControl(MainForm mainForm, string student_name, string student_group, string test_name, int questionsCount, int timeLeft)
        {
            this.mainForm = mainForm;
            this.student_name = student_name.Replace("'", "`");
            this.student_group = student_group;
            this.test_name = test_name;
            this.questionsCount = questionsCount;
            this.timeLeft = timeLeft;
            InitializeComponent();
            LoadQuestions();
        }
        private Dictionary<string, (string TrueAnswer, List<string> answers)> questionsDict;
        private List<string> selectedQuestions;
        private Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        private int studentMark = 0;
        private string selectedAnswer = "";
        private int currentQuestionIndex;
        private void LoadQuestions()
        {
            string filePath = TxtReader.GetPathOfTest(test_name);
            questionsDict = TxtReader.GetQuestionsDic(filePath);
            var random = new Random();
            selectedQuestions = questionsDict.Keys.ToList();
            selectedQuestions = selectedQuestions.OrderBy(x => random.Next()).Take(questionsCount).ToList();
            currentQuestionIndex = 0;
            ShowQuestion(selectedQuestions[currentQuestionIndex]);
            timer = new Timer();
            timer.Interval = 1000; // Интервал таймера в миллисекундах (1000 мс = 1 сек)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void ShowQuestion(string question)
        {
            selectedAnswer = "";
            questionRichtextbox.Text = question;
            var answers = questionsDict[question].answers;

            answerA_text.Text = answers[0];
            answerB_text.Text = answers[1];
            answerC_text.Text = answers[2];
            answerD_text.Text = answers[3];

            A_answer.Checked = B_answer.Checked = C_answer.Checked = D_answer.Checked = false;
            questionNumber.Text = (currentQuestionIndex + 1).ToString();
            questionNumber.Location = new Point((panel1.Width - questionNumber.Width) / 2, (panel1.Height - questionNumber.Height) / 2);
        }
        private void Check(bool forward)
        {
            if (keyValuePairs.Keys.Count != questionsCount)
            {
                if (keyValuePairs.Values.Contains(currentQuestionIndex + 1))
                {
                    if (forward)
                    {
                        currentQuestionIndex++;
                        if (currentQuestionIndex == questionsCount)
                        {
                            currentQuestionIndex = 0;
                        }
                        Check(true);
                    }
                    else
                    {
                        currentQuestionIndex--;
                        if (currentQuestionIndex == -1)
                        {
                            currentQuestionIndex = questionsCount-1;
                        }
                        Check(false);
                    }
                }
                else
                {
                    ShowQuestion(selectedQuestions[currentQuestionIndex]);
                }
            }
            else
            {
                The_End();
            }
        }
        private void Comfirm(object sender, EventArgs e)
        {
            if (selectedAnswer != "")
            {
                if (keyValuePairs.Keys.Count != questionsCount)
                {
                    if (!keyValuePairs.Keys.Contains(selectedQuestions[currentQuestionIndex]))
                    {
                        keyValuePairs.Add(selectedQuestions[currentQuestionIndex], currentQuestionIndex + 1);
                    }
                    var correctAnswer = questionsDict[selectedQuestions[currentQuestionIndex]].TrueAnswer;
                    if (correctAnswer == selectedAnswer)
                    {
                        currentQuestionIndex++;
                        if (currentQuestionIndex == questionsCount)
                        {
                            currentQuestionIndex = 0;
                        }
                        studentMark++;
                        Check(true);
                    }
                    else
                    {
                        currentQuestionIndex++;
                        if (currentQuestionIndex == questionsCount)
                        {
                            currentQuestionIndex = 0;
                        }
                        Check(true);
                    }
                }
                else
                {
                    endButton_Click(sender, e);
                }
            }
            else
            {
                Next(sender, e);
            }
            
        }
        private void Next(object sender, EventArgs e)
        {
            
            currentQuestionIndex++;
            if (currentQuestionIndex == questionsCount)
            {
                currentQuestionIndex = 0;
            }
            Check(true);
        }
        private void Preview(object sender, EventArgs e)
        {
            currentQuestionIndex--;
            if (currentQuestionIndex == -1)
            {
                currentQuestionIndex = questionsCount-1;
            }
            Check(false);
        }
        private void answerA_text_Click(object sender, EventArgs e)
        {
            A_answer.Checked = true;
            selectedAnswer = questionsDict[selectedQuestions[currentQuestionIndex]].answers[0];
        }
        private void answerB_text_Click(object sender, EventArgs e)
        {
            B_answer.Checked = true;
            selectedAnswer = questionsDict[selectedQuestions[currentQuestionIndex]].answers[1];
        }
        private void answerC_text_Click(object sender, EventArgs e)
        {
            C_answer.Checked = true;
            selectedAnswer = questionsDict[selectedQuestions[currentQuestionIndex]].answers[2];
        }
        private void answerD_text_Click(object sender, EventArgs e)
        {
            D_answer.Checked = true;
            selectedAnswer = questionsDict[selectedQuestions[currentQuestionIndex]].answers[3];
        }
        private int seconds = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                seconds = 59;
                timeLeft--;
            }
            if (timeLeft <= 0)
            {
                mainForm.Result_Open(student_name, "00:00", studentMark, questionsCount);
                timer.Stop();
            }
            else
            {
                timeLeftLABEL.Text = $"{timeLeft}:{seconds}";
            }
        }
        private void endButton_Click(object sender, EventArgs e)
        {
            The_End();
        }
        public void The_End()
        {
            if (keyValuePairs.Keys.Count == questionsCount)
            {
                timer.Stop();
                q.Insert($"INSERT INTO RESULTS VALUES(N'{student_name}',N'{student_group}',N'{test_name}','{studentMark}/{questionsCount}','{DateTime.Now.ToString("dd.MM.yyyy HH:mm")}')");
                mainForm.Result_Open(student_name, $"{timeLeft}:{seconds}", studentMark, questionsCount);
            }
            else
            {
                if (MessageBox.Show("Yakunlamoqchimisiz?", "Yakunlash", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    timer.Stop();
                    q.Insert($"INSERT INTO RESULTS VALUES(N'{student_name}',N'{student_group}','{test_name}','{studentMark}/{questionsCount}','{DateTime.Now.ToString("dd.MM.yyyy HH:mm")}')");
                    mainForm.Result_Open(student_name, $"{timeLeft}:{seconds}", studentMark, questionsCount);
                }
            }
        }
    }
}
