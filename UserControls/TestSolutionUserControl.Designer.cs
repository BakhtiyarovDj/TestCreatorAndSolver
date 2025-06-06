using System.Web.UI;

namespace TestCreatorAndSolver
{
    partial class TestSolutionUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSolutionUserControl));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.D_answer = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.C_answer = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.B_answer = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.A_answer = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.answerD_text = new System.Windows.Forms.RichTextBox();
            this.answerC_text = new System.Windows.Forms.RichTextBox();
            this.answerB_text = new System.Windows.Forms.RichTextBox();
            this.answerA_text = new System.Windows.Forms.RichTextBox();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.questionRichtextbox = new System.Windows.Forms.RichTextBox();
            this.previewQuestionBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.questionNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timeLeftLABEL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.guna2Separator1);
            this.guna2GroupBox1.Controls.Add(this.D_answer);
            this.guna2GroupBox1.Controls.Add(this.C_answer);
            this.guna2GroupBox1.Controls.Add(this.B_answer);
            this.guna2GroupBox1.Controls.Add(this.A_answer);
            this.guna2GroupBox1.Controls.Add(this.answerD_text);
            this.guna2GroupBox1.Controls.Add(this.answerC_text);
            this.guna2GroupBox1.Controls.Add(this.answerB_text);
            this.guna2GroupBox1.Controls.Add(this.answerA_text);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator4);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator3);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator2);
            this.guna2GroupBox1.Controls.Add(this.questionRichtextbox);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2, 40, 2, 20);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(195, 65);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(961, 508);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(-8, 130);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(977, 10);
            this.guna2Separator1.TabIndex = 9;
            // 
            // D_answer
            // 
            this.D_answer.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.D_answer.CheckedState.BorderThickness = 3;
            this.D_answer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D_answer.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.D_answer.CheckedState.InnerOffset = 10;
            this.D_answer.Location = new System.Drawing.Point(22, 426);
            this.D_answer.Name = "D_answer";
            this.D_answer.Size = new System.Drawing.Size(41, 41);
            this.D_answer.TabIndex = 8;
            this.D_answer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.D_answer.UncheckedState.BorderThickness = 2;
            this.D_answer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.D_answer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // C_answer
            // 
            this.C_answer.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.C_answer.CheckedState.BorderThickness = 3;
            this.C_answer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.C_answer.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.C_answer.CheckedState.InnerOffset = 10;
            this.C_answer.Location = new System.Drawing.Point(22, 335);
            this.C_answer.Name = "C_answer";
            this.C_answer.Size = new System.Drawing.Size(41, 41);
            this.C_answer.TabIndex = 7;
            this.C_answer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.C_answer.UncheckedState.BorderThickness = 2;
            this.C_answer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.C_answer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // B_answer
            // 
            this.B_answer.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.B_answer.CheckedState.BorderThickness = 3;
            this.B_answer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.B_answer.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.B_answer.CheckedState.InnerOffset = 10;
            this.B_answer.Location = new System.Drawing.Point(22, 247);
            this.B_answer.Name = "B_answer";
            this.B_answer.Size = new System.Drawing.Size(41, 41);
            this.B_answer.TabIndex = 6;
            this.B_answer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.B_answer.UncheckedState.BorderThickness = 2;
            this.B_answer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.B_answer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // A_answer
            // 
            this.A_answer.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.A_answer.CheckedState.BorderThickness = 3;
            this.A_answer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.A_answer.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.A_answer.CheckedState.InnerOffset = 10;
            this.A_answer.Location = new System.Drawing.Point(22, 160);
            this.A_answer.Name = "A_answer";
            this.A_answer.Size = new System.Drawing.Size(41, 41);
            this.A_answer.TabIndex = 5;
            this.A_answer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.A_answer.UncheckedState.BorderThickness = 2;
            this.A_answer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.A_answer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // answerD_text
            // 
            this.answerD_text.BackColor = System.Drawing.Color.White;
            this.answerD_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerD_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerD_text.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.answerD_text.Location = new System.Drawing.Point(79, 406);
            this.answerD_text.Name = "answerD_text";
            this.answerD_text.ReadOnly = true;
            this.answerD_text.Size = new System.Drawing.Size(877, 79);
            this.answerD_text.TabIndex = 3;
            this.answerD_text.Text = "";
            this.answerD_text.Click += new System.EventHandler(this.answerD_text_Click);
            // 
            // answerC_text
            // 
            this.answerC_text.BackColor = System.Drawing.Color.White;
            this.answerC_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerC_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerC_text.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.answerC_text.Location = new System.Drawing.Point(79, 317);
            this.answerC_text.Name = "answerC_text";
            this.answerC_text.ReadOnly = true;
            this.answerC_text.Size = new System.Drawing.Size(877, 79);
            this.answerC_text.TabIndex = 3;
            this.answerC_text.Text = "";
            this.answerC_text.Click += new System.EventHandler(this.answerC_text_Click);
            // 
            // answerB_text
            // 
            this.answerB_text.BackColor = System.Drawing.Color.White;
            this.answerB_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerB_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerB_text.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.answerB_text.Location = new System.Drawing.Point(79, 229);
            this.answerB_text.Name = "answerB_text";
            this.answerB_text.ReadOnly = true;
            this.answerB_text.Size = new System.Drawing.Size(877, 79);
            this.answerB_text.TabIndex = 3;
            this.answerB_text.Text = "";
            this.answerB_text.Click += new System.EventHandler(this.answerB_text_Click);
            // 
            // answerA_text
            // 
            this.answerA_text.BackColor = System.Drawing.Color.White;
            this.answerA_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerA_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerA_text.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.answerA_text.Location = new System.Drawing.Point(79, 140);
            this.answerA_text.Name = "answerA_text";
            this.answerA_text.ReadOnly = true;
            this.answerA_text.Size = new System.Drawing.Size(877, 79);
            this.answerA_text.TabIndex = 2;
            this.answerA_text.Text = "";
            this.answerA_text.Click += new System.EventHandler(this.answerA_text_Click);
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator4.Location = new System.Drawing.Point(-7, 395);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(982, 10);
            this.guna2Separator4.TabIndex = 1;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator3.Location = new System.Drawing.Point(-7, 307);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(978, 10);
            this.guna2Separator3.TabIndex = 1;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Location = new System.Drawing.Point(-7, 218);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(977, 10);
            this.guna2Separator2.TabIndex = 1;
            // 
            // questionRichtextbox
            // 
            this.questionRichtextbox.BackColor = System.Drawing.Color.White;
            this.questionRichtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionRichtextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.questionRichtextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionRichtextbox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.questionRichtextbox.Location = new System.Drawing.Point(2, 40);
            this.questionRichtextbox.Name = "questionRichtextbox";
            this.questionRichtextbox.ReadOnly = true;
            this.questionRichtextbox.Size = new System.Drawing.Size(957, 96);
            this.questionRichtextbox.TabIndex = 0;
            this.questionRichtextbox.Text = "";
            // 
            // previewQuestionBtn
            // 
            this.previewQuestionBtn.Animated = true;
            this.previewQuestionBtn.BackColor = System.Drawing.Color.Transparent;
            this.previewQuestionBtn.BorderRadius = 8;
            this.previewQuestionBtn.BorderThickness = 1;
            this.previewQuestionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.previewQuestionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.previewQuestionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.previewQuestionBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.previewQuestionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.previewQuestionBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.previewQuestionBtn.FillColor2 = System.Drawing.Color.White;
            this.previewQuestionBtn.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.previewQuestionBtn.ForeColor = System.Drawing.Color.White;
            this.previewQuestionBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.previewQuestionBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.previewQuestionBtn.HoverState.FillColor2 = System.Drawing.Color.Silver;
            this.previewQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("previewQuestionBtn.Image")));
            this.previewQuestionBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.previewQuestionBtn.Location = new System.Drawing.Point(298, 588);
            this.previewQuestionBtn.Name = "previewQuestionBtn";
            this.previewQuestionBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previewQuestionBtn.Size = new System.Drawing.Size(131, 59);
            this.previewQuestionBtn.TabIndex = 26;
            this.previewQuestionBtn.Click += new System.EventHandler(this.Preview);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Silver;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2GradientButton1.Location = new System.Drawing.Point(627, 588);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2GradientButton1.Size = new System.Drawing.Size(131, 59);
            this.guna2GradientButton1.TabIndex = 27;
            this.guna2GradientButton1.Click += new System.EventHandler(this.Next);
            // 
            // questionNumber
            // 
            this.questionNumber.BackColor = System.Drawing.Color.Transparent;
            this.questionNumber.Font = new System.Drawing.Font("Times New Roman", 32.25F);
            this.questionNumber.Location = new System.Drawing.Point(83, 1);
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Size = new System.Drawing.Size(25, 51);
            this.questionNumber.TabIndex = 28;
            this.questionNumber.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.questionNumber);
            this.panel1.Location = new System.Drawing.Point(435, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 54);
            this.panel1.TabIndex = 29;
            // 
            // endButton
            // 
            this.endButton.Animated = true;
            this.endButton.BackColor = System.Drawing.Color.Transparent;
            this.endButton.BorderRadius = 8;
            this.endButton.BorderThickness = 2;
            this.endButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.endButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.endButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.endButton.FillColor = System.Drawing.Color.Green;
            this.endButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.endButton.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.endButton.ForeColor = System.Drawing.Color.White;
            this.endButton.Image = ((System.Drawing.Image)(resources.GetObject("endButton.Image")));
            this.endButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endButton.ImageOffset = new System.Drawing.Point(15, 0);
            this.endButton.ImageSize = new System.Drawing.Size(34, 34);
            this.endButton.Location = new System.Drawing.Point(1131, 647);
            this.endButton.Name = "endButton";
            this.endButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endButton.Size = new System.Drawing.Size(211, 57);
            this.endButton.TabIndex = 30;
            this.endButton.Text = "Yakunlash";
            this.endButton.TextOffset = new System.Drawing.Point(-15, 0);
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.YellowGreen;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton2.ImageOffset = new System.Drawing.Point(15, 0);
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2GradientButton2.Location = new System.Drawing.Point(849, 588);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2GradientButton2.Size = new System.Drawing.Size(202, 59);
            this.guna2GradientButton2.TabIndex = 31;
            this.guna2GradientButton2.Text = "Tasdiqlash";
            this.guna2GradientButton2.Click += new System.EventHandler(this.Comfirm);
            // 
            // timeLeftLABEL
            // 
            this.timeLeftLABEL.BackColor = System.Drawing.Color.Transparent;
            this.timeLeftLABEL.Font = new System.Drawing.Font("Times New Roman", 32.25F);
            this.timeLeftLABEL.Location = new System.Drawing.Point(6, 660);
            this.timeLeftLABEL.Name = "timeLeftLABEL";
            this.timeLeftLABEL.Size = new System.Drawing.Size(3, 2);
            this.timeLeftLABEL.TabIndex = 29;
            this.timeLeftLABEL.Text = null;
            // 
            // Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timeLeftLABEL);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.previewQuestionBtn);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1356, 717);
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.RichTextBox questionRichtextbox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.RichTextBox answerA_text;
        private System.Windows.Forms.RichTextBox answerD_text;
        private System.Windows.Forms.RichTextBox answerC_text;
        private System.Windows.Forms.RichTextBox answerB_text;
        private Guna.UI2.WinForms.Guna2CustomRadioButton A_answer;
        private Guna.UI2.WinForms.Guna2CustomRadioButton D_answer;
        private Guna.UI2.WinForms.Guna2CustomRadioButton C_answer;
        private Guna.UI2.WinForms.Guna2CustomRadioButton B_answer;
        private Guna.UI2.WinForms.Guna2GradientButton previewQuestionBtn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel questionNumber;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton endButton;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2HtmlLabel timeLeftLABEL;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
