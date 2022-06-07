namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblQuestion = new System.Windows.Forms.Label();
            this.VariantA = new System.Windows.Forms.RadioButton();
            this.VariantD = new System.Windows.Forms.RadioButton();
            this.VariantB = new System.Windows.Forms.RadioButton();
            this.VariantC = new System.Windows.Forms.RadioButton();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.PnlExam = new System.Windows.Forms.Panel();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.BtnStartQuiz = new System.Windows.Forms.Button();
            this.PnlStartQuiz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TlbLogin = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlExam.SuspendLayout();
            this.PnlStartQuiz.SuspendLayout();
            this.TlbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.ForeColor = System.Drawing.Color.White;
            this.LblQuestion.Location = new System.Drawing.Point(3, 19);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(71, 37);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "Sual";
            // 
            // VariantA
            // 
            this.VariantA.AutoSize = true;
            this.VariantA.ForeColor = System.Drawing.Color.White;
            this.VariantA.Location = new System.Drawing.Point(90, 114);
            this.VariantA.Name = "VariantA";
            this.VariantA.Size = new System.Drawing.Size(102, 24);
            this.VariantA.TabIndex = 1;
            this.VariantA.TabStop = true;
            this.VariantA.Text = "A) Cavab 1";
            this.VariantA.UseVisualStyleBackColor = true;
            // 
            // VariantD
            // 
            this.VariantD.AutoSize = true;
            this.VariantD.ForeColor = System.Drawing.Color.White;
            this.VariantD.Location = new System.Drawing.Point(406, 160);
            this.VariantD.Name = "VariantD";
            this.VariantD.Size = new System.Drawing.Size(103, 24);
            this.VariantD.TabIndex = 2;
            this.VariantD.TabStop = true;
            this.VariantD.Text = "D) Cavab 4";
            this.VariantD.UseVisualStyleBackColor = true;
            // 
            // VariantB
            // 
            this.VariantB.AutoSize = true;
            this.VariantB.ForeColor = System.Drawing.Color.White;
            this.VariantB.Location = new System.Drawing.Point(406, 114);
            this.VariantB.Name = "VariantB";
            this.VariantB.Size = new System.Drawing.Size(101, 24);
            this.VariantB.TabIndex = 3;
            this.VariantB.TabStop = true;
            this.VariantB.Text = "B) Cavab 2";
            this.VariantB.UseVisualStyleBackColor = true;
            // 
            // VariantC
            // 
            this.VariantC.AutoSize = true;
            this.VariantC.ForeColor = System.Drawing.Color.White;
            this.VariantC.Location = new System.Drawing.Point(90, 160);
            this.VariantC.Name = "VariantC";
            this.VariantC.Size = new System.Drawing.Size(101, 24);
            this.VariantC.TabIndex = 4;
            this.VariantC.TabStop = true;
            this.VariantC.Text = "C) Cavab 3";
            this.VariantC.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.BtnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(90, 225);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(121, 34);
            this.BtnAccept.TabIndex = 5;
            this.BtnAccept.Text = "Cavabla";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // PnlExam
            // 
            this.PnlExam.BackColor = System.Drawing.Color.Transparent;
            this.PnlExam.Controls.Add(this.LblQuestion);
            this.PnlExam.Controls.Add(this.BtnAccept);
            this.PnlExam.Controls.Add(this.VariantA);
            this.PnlExam.Controls.Add(this.VariantC);
            this.PnlExam.Controls.Add(this.VariantD);
            this.PnlExam.Controls.Add(this.VariantB);
            this.PnlExam.Location = new System.Drawing.Point(1233, 12);
            this.PnlExam.Name = "PnlExam";
            this.PnlExam.Size = new System.Drawing.Size(549, 412);
            this.PnlExam.TabIndex = 6;
            this.PnlExam.Visible = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(983, 332);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(17, 20);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "0";
            // 
            // BtnStartQuiz
            // 
            this.BtnStartQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.BtnStartQuiz.FlatAppearance.BorderSize = 0;
            this.BtnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.BtnStartQuiz.Location = new System.Drawing.Point(66, 352);
            this.BtnStartQuiz.Name = "BtnStartQuiz";
            this.BtnStartQuiz.Size = new System.Drawing.Size(121, 34);
            this.BtnStartQuiz.TabIndex = 6;
            this.BtnStartQuiz.Text = "Imtahana basla";
            this.BtnStartQuiz.UseVisualStyleBackColor = false;
            this.BtnStartQuiz.Click += new System.EventHandler(this.BtnStartQuiz_Click);
            // 
            // PnlStartQuiz
            // 
            this.PnlStartQuiz.BackColor = System.Drawing.Color.Transparent;
            this.PnlStartQuiz.Controls.Add(this.label1);
            this.PnlStartQuiz.Controls.Add(this.BtnStartQuiz);
            this.PnlStartQuiz.Location = new System.Drawing.Point(1214, 439);
            this.PnlStartQuiz.Name = "PnlStartQuiz";
            this.PnlStartQuiz.Size = new System.Drawing.Size(568, 412);
            this.PnlStartQuiz.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Imtahan Haqqinda";
            // 
            // TlbLogin
            // 
            this.TlbLogin.BackColor = System.Drawing.Color.White;
            this.TlbLogin.ColumnCount = 2;
            this.TlbLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TlbLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlbLogin.Controls.Add(this.pictureBox1, 0, 0);
            this.TlbLogin.Controls.Add(this.panel2, 1, 0);
            this.TlbLogin.Location = new System.Drawing.Point(3, -3);
            this.TlbLogin.Name = "TlbLogin";
            this.TlbLogin.RowCount = 1;
            this.TlbLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlbLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlbLogin.Size = new System.Drawing.Size(951, 538);
            this.TlbLogin.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(668, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 532);
            this.panel2.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(253, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 24);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Location = new System.Drawing.Point(45, 332);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(207, 43);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(45, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.Transparent;
            this.TxtPassword.Location = new System.Drawing.Point(45, 265);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(207, 27);
            this.TxtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.Color.Transparent;
            this.TxtEmail.Location = new System.Drawing.Point(45, 194);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(207, 27);
            this.TxtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign in to your account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(53, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome !";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUserName.ForeColor = System.Drawing.Color.Snow;
            this.LblUserName.Location = new System.Drawing.Point(993, 25);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(123, 32);
            this.LblUserName.TabIndex = 10;
            this.LblUserName.Text = "userName";
            this.LblUserName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1838, 928);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TlbLogin);
            this.Controls.Add(this.PnlStartQuiz);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.PnlExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlExam.ResumeLayout(false);
            this.PnlExam.PerformLayout();
            this.PnlStartQuiz.ResumeLayout(false);
            this.PnlStartQuiz.PerformLayout();
            this.TlbLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblQuestion;
        private RadioButton VariantA;
        private RadioButton VariantD;
        private RadioButton VariantB;
        private RadioButton VariantC;
        private Button BtnAccept;
        private Panel PnlExam;
        private Label lblCorrect;
        private Button BtnStartQuiz;
        private Panel PnlStartQuiz;
        private Label label1;
        private TableLayoutPanel TlbLogin;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button BtnClose;
        private Button BtnLogin;
        private Label label4;
        private TextBox TxtPassword;
        private Label label3;
        private TextBox TxtEmail;
        private Label label2;
        private Label label5;
        private Label LblUserName;
    }
}