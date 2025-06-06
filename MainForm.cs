using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreatorAndSolver
{
    public partial class MainForm : Form
    {
        private MenuUserControl menu = null;
        private AuthorisationUserControl logIn = null;
        private ManageTestsUserControl adminPanel = null;
        private TestSolutionUserControl student = null;
        private StudentAuthUserControl studentRegistration = null;
        private ShowResultUserControl result = null;
        public bool testing = false;
        public MainForm()
        {
            InitializeComponent();
            Menu_Open();
        }

        public void Menu_Open() 
        {
            menu = new MenuUserControl(this);
            testing = false;
            mainPanel.Controls.Clear();
            menu.Location = new Point((mainPanel.Width - menu.Width) / 2, (mainPanel.Height - menu.Height) / 2);
            mainPanel.Controls.Add(menu);
        }
        public void LogIn_Open()
        {
            logIn = new AuthorisationUserControl(this);
            testing = false;
            mainPanel.Controls.Clear();
            logIn.Location = new Point((mainPanel.Width - logIn.Width) / 2, (mainPanel.Height - logIn.Height) / 2);
            mainPanel.Controls.Add(logIn);
        }
        public void AdminPanel_Open()
        {
            adminPanel = new ManageTestsUserControl(this);
            testing = false;
            mainPanel.Controls.Clear();
            adminPanel.Location = new Point((mainPanel.Width - adminPanel.Width) / 2, (mainPanel.Height - adminPanel.Height) / 2);
            mainPanel.Controls.Add(adminPanel);
        }
        public void Student_Open(string student_name,string student_group,string test_name, int questionsCount, int timeLeft)
        {
            testing = true;
            student = new TestSolutionUserControl(this, student_name, student_group, test_name, questionsCount, timeLeft);
            mainPanel.Controls.Clear();
            student.Location = new Point((mainPanel.Width - student.Width) / 2, (mainPanel.Height - student.Height) / 2);
            mainPanel.Controls.Add(student);
        }
        public void StudentRegister_Open()
        {
            studentRegistration = new StudentAuthUserControl(this);
            testing = false;
            mainPanel.Controls.Clear();
            studentRegistration.Location = new Point((mainPanel.Width - studentRegistration.Width) / 2, (mainPanel.Height - studentRegistration.Height) / 2);
            mainPanel.Controls.Add(studentRegistration);
        }
        public void Result_Open(string name,string time,int ball,int quest_count)
        {
            testing = false;
            result = new ShowResultUserControl(this,name,time,ball, quest_count);
            mainPanel.Controls.Clear();
            result.Location = new Point((mainPanel.Width - result.Width) / 2, (mainPanel.Height - result.Height) / 2);
            mainPanel.Controls.Add(result);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (testing){ student.The_End(); }
            else 
            {
                Application.Exit(); 
            }
        }
    }
}
