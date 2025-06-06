using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace TestCreatorAndSolver
{
    public partial class ManageTestsUserControl : UserControl
    {
        private MainForm mainForm;
        private Query q = new Query();
        private Dictionary<string, (int correctIndex, List<string> answers)> questions = null;
        private int selected_id = -1;
        private string selected_subject = "";
        private int selected_count = 0;
        private int selected_time = 0;
        public ManageTestsUserControl(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            TxtReader.FillSubjectsCombobox(subjectCombobox);
            RefreshDataGridViewT();
            FillResult();
            q.FillComboBox("DISTINCT studentGroup", "Results", studentGroupBox);
            q.FillComboBox("DISTINCT testname", "Results", subjectNameBoxR);
            studentGroupBox.Items.Insert(0, "");
            subjectNameBoxR.Items.Insert(0, "");
        }
        private string file_name = "";
        private string file_path = "";
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                filePathTxtBox.Text = file_path;
                file_name = openFileDialog1.SafeFileName.Replace(".txt","");
                questions = TxtReader.ReadQuestions(file_path, infoLabel);

                if (questions != null)
                {
                    infoLabel.Text = "Savollar soni: " + questions.Count;
                    infoLabel.ForeColor = Color.Black;
                }

            }

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectName.Text))
            {
                subjectName.Focus();
                errorLabel.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(kursBox.Text))
            {
                kursBox.Focus();
                errorLabel.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(semestrBox.Text))
            {
                semestrBox.Focus();
                errorLabel.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(filePathTxtBox.Text))
            {
                filePathTxtBox.Focus();
                errorLabel.Visible = true;
            }
            else if (infoLabel.ForeColor == Color.Red)
            {
                if(MessageBox.Show("Savollar joylashgan .txt fayl tanlansin", "Diqqat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    guna2GradientButton1_Click(sender, e);
                }
            }
            else
            {
                string newfilePath = $"{Environment.CurrentDirectory}\\Savollar\\{file_name + DateTime.Now.ToString(" dd-MM-yyyy HH-mm-ss") + ".txt"}";
                TxtReader.CopyFile(file_path, newfilePath);
                TxtReader.WriteToJSONSubjectAndNewPath(subjectName.Text+"("+kursBox.Text+"-kurs,"+semestrBox.Text+"-semestr)", newfilePath);
                TxtReader.FillSubjectsCombobox(subjectCombobox);
                subjectName.Text = filePathTxtBox.Text = "";
                kursBox.SelectedIndex = -1;
                semestrBox.SelectedIndex = -1;
                errorLabel.Visible = false;
            }
        }
        private void subjectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectCombobox.SelectedIndex != -1)
            {
                TxtReader.FillRichTextBox(filesTextRichTextBox,subjectCombobox.SelectedItem.ToString());
            }
        }
        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            var table = q.Select($"SELECT COUNT FROM TESTS WHERE SUBJECT = '{subjectCombobox.SelectedItem}'");
            if (subjectCombobox.SelectedItem != null)
            {
                var Qcount = TxtReader.GetQuestionsDic(TxtReader.GetPathOfTest(subjectCombobox.SelectedItem.ToString())).Keys.Count;
                if (table.Rows.Count > 0)
                {
                    countErrorLabel.Visible = true;
                    countErrorLabel.Text = $"{subjectCombobox.SelectedItem} avval qo'shilgan";
                }
                else if (Qcount < questionsCountNumeric.Value)
                {
                    countErrorLabel.Visible = true;
                    countErrorLabel.Text = "Ushbu savollar bankida savollar yetarli emas";
                }
                else
                {
                    countErrorLabel.Visible = false;
                    q.Insert($"INSERT INTO TESTS VALUES(N'{subjectCombobox.SelectedItem.ToString().Replace("'", "`")}',{questionsCountNumeric.Value},{testTimeNumeric.Value})");
                    MessageBox.Show("Muvaffaqiyatli", "Muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filesTextRichTextBox.Clear();
                    subjectCombobox.SelectedIndex = -1;
                    questionsCountNumeric.Value = 20;
                    testTimeNumeric.Value = 30;
                }
            }
            else
            {
                countErrorLabel.Visible = true;
                countErrorLabel.Text = "Savollar banki tanlansin";
            }
        }
        private void RefreshDataGridViewT()
        {
            while (dataTableDGV.Rows.Count > 0)
            {
                dataTableDGV.Rows.RemoveAt(0);
            }
            dataTableDGV.DataSource = q.Select("SELECT id,subject as \"Fan nomi(Test nomi)\",count as \"Biletdagi savollar soni\",time as \"Ajratilgan vaqt(daqiqa)\" FROM TESTS");
            dataTableDGV.Columns[0].Visible = false;
            dataTableDGV.Columns[1].Width = 550;
            dataTableDGV.ColumnHeadersHeight = 100;
        }
        private void dataTableDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selected_id = int.Parse(dataTableDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                selected_subject = dataTableDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                selected_count = int.Parse(dataTableDGV.Rows[e.RowIndex].Cells[2].Value.ToString());
                selected_time = int.Parse(dataTableDGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedIndex == 0)
            {
                RefreshDataGridViewT();
            }
            else if (guna2TabControl1.SelectedIndex == 3)
            {
                q.FillComboBox("DISTINCT studentGroup", "Results", studentGroupBox);
                q.FillComboBox("DISTINCT testname", "Results", subjectNameBoxR);
                studentGroupBox.Items.Insert(0, "");
                subjectNameBoxR.Items.Insert(0, "");
            }
            foreach (TabPage tabPage in guna2TabControl1.TabPages)
            {
                if (guna2TabControl1.SelectedTab != tabPage)
                {
                    ClearAllControls(tabPage.Controls);
                }
            }
        }
        private void ClearAllControls(ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 20;
                }
            }
        }
        private void guna2GradientButton2_Click_2(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedTab = createTestPage;
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (selected_id != -1)
            {
                if (MessageBox.Show($"«{selected_subject} | {selected_count}savol | {selected_time}daqiqa» testini o'chirishga aminmisiz?", "Diqqat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    q.Delete($"DELETE FROM TESTS WHERE ID = {selected_id}");
                    MessageBox.Show("Muvaffaqiyatli", "Muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtReader.RemoveSubjectFromJSON(selected_subject);
                    TxtReader.FillSubjectsCombobox(subjectCombobox);
                    RefreshDataGridViewT();
                }
            }
        }
        private void exitButtons_Click(object sender, EventArgs e)
        {
            mainForm.Menu_Open();
        }
        private void FillResult()
        {
            string query = $"SELECT STUDENTNAME AS 'Talaba', STUDENTGROUP AS 'Guruh'," +
                " TESTNAME AS 'Fan nomi(Test nomi)', " +
                "BALL AS 'Ball',DATE_TIME AS 'Test topshirilgan sana' " +
                $"FROM RESULTS WHERE STUDENTNAME LIKE '%{studentName.Text}%'";

            if (!string.IsNullOrWhiteSpace(studentGroupBox.Text))
            {
                query += $" AND STUDENTGROUP = '{studentGroupBox.Text}'";
            }

            if (!string.IsNullOrWhiteSpace(subjectNameBoxR.Text))
            {
                query += $" AND TESTNAME = '{subjectNameBoxR.Text}'";
            }
            resultDGV.DataSource = q.Select(query);
            resultDGV.Columns[0].Width = 275;
            resultDGV.Columns[1].Width = 110;
            resultDGV.Columns[2].Width = 315;
            resultDGV.Columns[3].Width = 100;
            resultDGV.ColumnHeadersHeight = 100;
        }
        private void studentName_TextChanged(object sender, EventArgs e)
        {
            FillResult();
        }
        private void studentGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillResult();
        }
        private void subjectNameBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillResult();
        }
        private void deleteTestSourceBtn_Click(object sender, EventArgs e)
        {
            if (subjectCombobox.SelectedIndex != -1)
            {
                if (MessageBox.Show($"«{subjectCombobox.SelectedItem}» savollar bankini o'chirish natijasida unga tegishli yaratilgan test ham o'chib ketadi, aminmisiz?", "Diqqat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string path = TxtReader.GetPathOfTest(subjectCombobox.SelectedItem.ToString());
                    TxtReader.DeleteTxtFile(path);
                    TxtReader.RemoveJSONElementWithKey(subjectCombobox.SelectedItem.ToString());
                    q.Delete($"DELETE FROM TESTS WHERE SUBJECT = '{subjectCombobox.SelectedItem}'");

                    TxtReader.FillSubjectsCombobox(subjectCombobox);
                    filesTextRichTextBox.Clear();
                }
                
            }
        }
    }
}
