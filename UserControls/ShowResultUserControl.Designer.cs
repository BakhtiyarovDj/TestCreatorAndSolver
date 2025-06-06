namespace TestCreatorAndSolver
{
    partial class ShowResultUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowResultUserControl));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.fish = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ball = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.endButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.FillOffset = -2;
            this.guna2CircleProgressBar1.FillThickness = 1;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(536, 192);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.Maroon;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.guna2CircleProgressBar1.ProgressThickness = 116;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShowText = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(226, 226);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.UseTransparentBackground = true;
            this.guna2CircleProgressBar1.Value = 20;
            // 
            // fish
            // 
            this.fish.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fish.BackColor = System.Drawing.Color.Transparent;
            this.fish.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fish.Location = new System.Drawing.Point(7, 30);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(117, 25);
            this.fish.TabIndex = 20;
            this.fish.Text = "Talaba FISH:  ";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(7, 101);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(117, 25);
            this.time.TabIndex = 21;
            this.time.Text = "Qolgan vaqt:  ";
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ball.Location = new System.Drawing.Point(78, 175);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(43, 25);
            this.ball.TabIndex = 22;
            this.ball.Text = "Ball:  ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Separator2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Separator1);
            this.guna2CustomGradientPanel1.Controls.Add(this.ball);
            this.guna2CustomGradientPanel1.Controls.Add(this.time);
            this.guna2CustomGradientPanel1.Controls.Add(this.fish);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(38, 192);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(471, 226);
            this.guna2CustomGradientPanel1.TabIndex = 23;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(7, 145);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(456, 10);
            this.guna2Separator2.TabIndex = 24;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(7, 71);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(456, 10);
            this.guna2Separator1.TabIndex = 23;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.endButton);
            this.guna2CustomGradientPanel2.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CircleProgressBar1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(196)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(806, 521);
            this.guna2CustomGradientPanel2.TabIndex = 24;
            // 
            // endButton
            // 
            this.endButton.Animated = true;
            this.endButton.BackColor = System.Drawing.Color.Transparent;
            this.endButton.BorderColor = System.Drawing.Color.White;
            this.endButton.BorderRadius = 15;
            this.endButton.BorderThickness = 1;
            this.endButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.endButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.endButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.endButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(88)))), ((int)(((byte)(36)))));
            this.endButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(88)))), ((int)(((byte)(36)))));
            this.endButton.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.endButton.ForeColor = System.Drawing.Color.White;
            this.endButton.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.endButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.endButton.Image = ((System.Drawing.Image)(resources.GetObject("endButton.Image")));
            this.endButton.ImageOffset = new System.Drawing.Point(0, 1);
            this.endButton.ImageSize = new System.Drawing.Size(40, 40);
            this.endButton.Location = new System.Drawing.Point(698, 445);
            this.endButton.Name = "endButton";
            this.endButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endButton.Size = new System.Drawing.Size(93, 62);
            this.endButton.TabIndex = 31;
            this.endButton.TextOffset = new System.Drawing.Point(-15, 0);
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Result
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(806, 521);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel fish;
        private Guna.UI2.WinForms.Guna2HtmlLabel ball;
        private Guna.UI2.WinForms.Guna2HtmlLabel time;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton endButton;
    }
}
