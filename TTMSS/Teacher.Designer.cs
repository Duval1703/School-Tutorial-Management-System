namespace TTMSS
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMark = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_mark1 = new TTMSS.Teacher_UC.UC_mark();
            this.uC_result1 = new TTMSS.Teacher_UC.UC_result();
            this.uC_ViewDeleteQuetsion1 = new TTMSS.Teacher_UC.UC_ViewDeleteQuetsion();
            this.uC_updateQuestion1 = new TTMSS.Teacher_UC.UC_updateQuestion();
            this.uC_AddNewQuestion1 = new TTMSS.Teacher_UC.UC_AddNewQuestion();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnMark);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnViewDeleteQuestions);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 768);
            this.panel1.TabIndex = 2;
            // 
            // btnMark
            // 
            this.btnMark.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMark.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnMark.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMark.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMark.FillColor = System.Drawing.Color.Transparent;
            this.btnMark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnMark.ForeColor = System.Drawing.Color.Black;
            this.btnMark.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMark.Image = ((System.Drawing.Image)(resources.GetObject("btnMark.Image")));
            this.btnMark.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMark.Location = new System.Drawing.Point(0, 518);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(342, 45);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Mark Students";
            this.btnMark.Visible = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(11, 713);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(0, 656);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(342, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnResult
            // 
            this.btnResult.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnResult.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnResult.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnResult.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResult.FillColor = System.Drawing.Color.Transparent;
            this.btnResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.HoverState.FillColor = System.Drawing.Color.White;
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.ImageSize = new System.Drawing.Size(30, 30);
            this.btnResult.Location = new System.Drawing.Point(4, 590);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(337, 45);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "All Student Result";
            this.btnResult.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnViewDeleteQuestions
            // 
            this.btnViewDeleteQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDeleteQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDeleteQuestions.FillColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteQuestions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDeleteQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteQuestions.Image")));
            this.btnViewDeleteQuestions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewDeleteQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDeleteQuestions.Location = new System.Drawing.Point(-1, 453);
            this.btnViewDeleteQuestions.Name = "btnViewDeleteQuestions";
            this.btnViewDeleteQuestions.Size = new System.Drawing.Size(339, 45);
            this.btnViewDeleteQuestions.TabIndex = 3;
            this.btnViewDeleteQuestions.Text = " View & Delete Questions ";
            this.btnViewDeleteQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewDeleteQuestions.Click += new System.EventHandler(this.btnViewDeleteQuestions_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateQuestion.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.Image")));
            this.btnUpdateQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateQuestion.Location = new System.Drawing.Point(0, 382);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(342, 45);
            this.btnUpdateQuestion.TabIndex = 2;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewQuestion.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewQuestion.Image")));
            this.btnAddNewQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewQuestion.Location = new System.Drawing.Point(0, 308);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(338, 45);
            this.btnAddNewQuestion.TabIndex = 0;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(65, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_mark1);
            this.panel2.Controls.Add(this.uC_result1);
            this.panel2.Controls.Add(this.uC_ViewDeleteQuetsion1);
            this.panel2.Controls.Add(this.uC_updateQuestion1);
            this.panel2.Controls.Add(this.uC_AddNewQuestion1);
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 768);
            this.panel2.TabIndex = 3;
            // 
            // uC_mark1
            // 
            this.uC_mark1.BackColor = System.Drawing.Color.White;
            this.uC_mark1.Location = new System.Drawing.Point(0, 0);
            this.uC_mark1.Name = "uC_mark1";
            this.uC_mark1.Size = new System.Drawing.Size(1095, 768);
            this.uC_mark1.TabIndex = 4;
            // 
            // uC_result1
            // 
            this.uC_result1.BackColor = System.Drawing.Color.White;
            this.uC_result1.Location = new System.Drawing.Point(0, 0);
            this.uC_result1.Name = "uC_result1";
            this.uC_result1.Size = new System.Drawing.Size(1095, 768);
            this.uC_result1.TabIndex = 3;
            // 
            // uC_ViewDeleteQuetsion1
            // 
            this.uC_ViewDeleteQuetsion1.BackColor = System.Drawing.Color.White;
            this.uC_ViewDeleteQuetsion1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewDeleteQuetsion1.Name = "uC_ViewDeleteQuetsion1";
            this.uC_ViewDeleteQuetsion1.Size = new System.Drawing.Size(1095, 768);
            this.uC_ViewDeleteQuetsion1.TabIndex = 2;
            this.uC_ViewDeleteQuetsion1.Load += new System.EventHandler(this.uC_ViewDeleteQuetsion1_Load);
            // 
            // uC_updateQuestion1
            // 
            this.uC_updateQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_updateQuestion1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uC_updateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_updateQuestion1.Name = "uC_updateQuestion1";
            this.uC_updateQuestion1.Size = new System.Drawing.Size(1095, 789);
            this.uC_updateQuestion1.TabIndex = 1;
            // 
            // uC_AddNewQuestion1
            // 
            this.uC_AddNewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewQuestion1.ForeColor = System.Drawing.Color.Black;
            this.uC_AddNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewQuestion1.Name = "uC_AddNewQuestion1";
            this.uC_AddNewQuestion1.Size = new System.Drawing.Size(1095, 768);
            this.uC_AddNewQuestion1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteQuestions;
        private Guna.UI2.WinForms.Guna2Button btnUpdateQuestion;
        private Guna.UI2.WinForms.Guna2Button btnAddNewQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Teacher_UC.UC_AddNewQuestion uC_AddNewQuestion1;
        private Teacher_UC.UC_ViewDeleteQuetsion uC_ViewDeleteQuetsion1;
        private Teacher_UC.UC_updateQuestion uC_updateQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button btnMark;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Teacher_UC.UC_mark uC_mark1;
        private Teacher_UC.UC_result uC_result1;
    }
}