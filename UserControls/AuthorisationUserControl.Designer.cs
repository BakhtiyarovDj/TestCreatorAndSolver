namespace TestCreatorAndSolver
{
    partial class AuthorisationUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorisationUserControl));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.loginTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.parolTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitBtn3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(112, 313);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(186, 59);
            this.guna2GradientButton1.TabIndex = 2;
            this.guna2GradientButton1.Text = "G O";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // loginTxt
            // 
            this.loginTxt.BorderColor = System.Drawing.Color.Silver;
            this.loginTxt.BorderRadius = 8;
            this.loginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxt.DefaultText = "";
            this.loginTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTxt.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.loginTxt.ForeColor = System.Drawing.Color.Black;
            this.loginTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTxt.Location = new System.Drawing.Point(82, 217);
            this.loginTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.PasswordChar = '\0';
            this.loginTxt.PlaceholderText = "Login";
            this.loginTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTxt.SelectedText = "";
            this.loginTxt.Size = new System.Drawing.Size(247, 38);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 25F);
            this.label1.Location = new System.Drawing.Point(94, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(145, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 131);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // parolTxt
            // 
            this.parolTxt.BorderColor = System.Drawing.Color.Silver;
            this.parolTxt.BorderRadius = 8;
            this.parolTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parolTxt.DefaultText = "";
            this.parolTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.parolTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.parolTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.parolTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.parolTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parolTxt.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.parolTxt.ForeColor = System.Drawing.Color.Black;
            this.parolTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parolTxt.Location = new System.Drawing.Point(82, 265);
            this.parolTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.parolTxt.Name = "parolTxt";
            this.parolTxt.PasswordChar = '\0';
            this.parolTxt.PlaceholderText = "Password";
            this.parolTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parolTxt.SelectedText = "";
            this.parolTxt.Size = new System.Drawing.Size(247, 38);
            this.parolTxt.TabIndex = 1;
            this.parolTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitBtn3
            // 
            this.exitBtn3.Animated = true;
            this.exitBtn3.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn3.BorderColor = System.Drawing.Color.White;
            this.exitBtn3.BorderRadius = 15;
            this.exitBtn3.BorderThickness = 1;
            this.exitBtn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn3.FillColor = System.Drawing.Color.Maroon;
            this.exitBtn3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitBtn3.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.exitBtn3.ForeColor = System.Drawing.Color.White;
            this.exitBtn3.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.exitBtn3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.exitBtn3.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn3.Image")));
            this.exitBtn3.ImageOffset = new System.Drawing.Point(0, 1);
            this.exitBtn3.ImageSize = new System.Drawing.Size(32, 32);
            this.exitBtn3.Location = new System.Drawing.Point(306, 410);
            this.exitBtn3.Name = "exitBtn3";
            this.exitBtn3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn3.Size = new System.Drawing.Size(104, 45);
            this.exitBtn3.TabIndex = 3;
            this.exitBtn3.TextOffset = new System.Drawing.Point(-15, 0);
            this.exitBtn3.Click += new System.EventHandler(this.exitBtn3_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(105, 378);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(187, 25);
            this.ErrorLabel.TabIndex = 36;
            this.ErrorLabel.Text = "Maydonlarni to\'ldiring";
            this.ErrorLabel.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.exitBtn3);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.guna2GradientButton1);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(414, 459);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox loginTxt;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox parolTxt;
        private Guna.UI2.WinForms.Guna2GradientButton exitBtn3;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLabel;
    }
}
