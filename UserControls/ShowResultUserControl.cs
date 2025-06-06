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
    public partial class ShowResultUserControl : UserControl
    {
        private MainForm mainForm;

        public ShowResultUserControl(MainForm mainForm, string name, string time1, int ball1, int questions_count)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            fish.Text += name;
            time.Text += time1;
            ball.Text += ball1+" / "+ questions_count;
            double persent = ((double)ball1 / questions_count) * 100;
            guna2CircleProgressBar1.Value = (int)persent;
            if(persent > 60)
            {
                guna2CircleProgressBar1.ProgressColor = Color.Green;
                guna2CircleProgressBar1.ProgressColor2 = Color.GreenYellow;
            }
            else
            {
                guna2CircleProgressBar1.ProgressColor = Color.Maroon;
                guna2CircleProgressBar1.ProgressColor2 = Color.Red;
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            mainForm.Menu_Open();
        }

    }
}
