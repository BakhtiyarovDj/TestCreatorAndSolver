using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreatorAndSolver
{
    public partial class StudentAuthUserControl : UserControl
    {
        Query q = new Query();
        private MainForm mainForm;

        int timeLeft = 0;
        int questionsCount = 0;

        public StudentAuthUserControl(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            LoadSubjectsFromJson();
            q.FillComboBox("SUBJECT", "TESTS", subjectCombobox);
        }

        private void LoadSubjectsFromJson()
        {
            var allSubjects = q.Select("SELECT id,subject FROM TESTS").Select();
            foreach (DataRow subjects in allSubjects)
            {
                string subjectName = subjects[1].ToString();
                string filePath = TxtReader.GetPathOfTest(subjectName);
                if (!File.Exists(filePath))
                {
                    q.Delete($"DELETE FROM TESTS WHERE ID = {subjects[0]}");
                    TxtReader.RemoveSubjectFromJSON(subjectName);
                }
            }

        }

        private void subjectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var table = q.Select($"SELECT COUNT,TIME FROM TESTS WHERE SUBJECT = '{subjectCombobox.SelectedItem}'");
            questionsCount = int.Parse(table.Rows[0][0].ToString());
            timeLeft = int.Parse(table.Rows[0][1].ToString());
            questionsCountLabel.Text = questionsCount + "ta savol";
            timeLeftLabel.Text = timeLeft + " daqiqa";
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (subjectCombobox.SelectedIndex == -1)
            {
                subjectCombobox.Focus();
                errorLabel.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(studentNameTxtbox.Text))
            {
                studentNameTxtbox.Focus();
                errorLabel.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(studentGroupTxtBox.Text))
            {
                studentGroupTxtBox.Focus();
                errorLabel.Visible = true;
            }
            else
            {
                mainForm.Student_Open(studentNameTxtbox.Text,studentGroupTxtBox.Text,subjectCombobox.SelectedItem.ToString(), questionsCount, timeLeft);
            }
        }

        private void exitBtn2_Click(object sender, EventArgs e)
        {
            mainForm.Menu_Open();
        }
        
    }
}
