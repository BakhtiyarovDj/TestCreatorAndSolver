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
    public partial class MenuUserControl : UserControl
    {
        MainForm mainForm = null;
        public MenuUserControl()
        {
            InitializeComponent();
        }
        public MenuUserControl(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            mainForm.LogIn_Open();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            mainForm.StudentRegister_Open();
        }
    }
}
