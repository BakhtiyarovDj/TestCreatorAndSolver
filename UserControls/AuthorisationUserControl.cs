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
    public partial class AuthorisationUserControl : UserControl
    {
        private MainForm mainForm;
        Query q = new Query();
        public AuthorisationUserControl()
        {
            InitializeComponent();
        }
        public AuthorisationUserControl(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginTxt.Text) || !string.IsNullOrWhiteSpace(parolTxt.Text))
            {
                if (int.Parse(q.Select($"SELECT COUNT(*) FROM ADMINS WHERE LOGIN = '{loginTxt.Text}' AND PAROL = '{parolTxt.Text}'").Rows[0][0].ToString()) > 0)
                {
                    mainForm.AdminPanel_Open();
                }
                else
                {
                    ErrorLabel.Text = "Login yoki parol notog'ri";
                    ErrorLabel.Visible = true;
                }
            }
            else
            {
                ErrorLabel.Text = "Maydonlarni to'ldiring";
                ErrorLabel.Visible = true;
            }
            
        }

        private void exitBtn3_Click(object sender, EventArgs e)
        {
            mainForm.Menu_Open();
        }
    }
}
