namespace tasker
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userBirthdayDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordRegistrationRepeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnCreateAccount = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.passwordRegistration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginRegistration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userImgBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.userImgBox);
            this.panel1.Controls.Add(this.userBirthdayDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passwordRegistrationRepeat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bttnCreateAccount);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.passwordRegistration);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginRegistration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(145, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 725);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userBirthdayDate
            // 
            this.userBirthdayDate.Location = new System.Drawing.Point(354, 345);
            this.userBirthdayDate.Name = "userBirthdayDate";
            this.userBirthdayDate.TabIndex = 12;
            this.userBirthdayDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.userBirthday_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(78, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "your birthday:";
            // 
            // passwordRegistrationRepeat
            // 
            this.passwordRegistrationRepeat.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistrationRepeat.Location = new System.Drawing.Point(319, 270);
            this.passwordRegistrationRepeat.Name = "passwordRegistrationRepeat";
            this.passwordRegistrationRepeat.Size = new System.Drawing.Size(261, 35);
            this.passwordRegistrationRepeat.TabIndex = 10;
            this.passwordRegistrationRepeat.TextChanged += new System.EventHandler(this.passwordRegistrationRepeat_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(65, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "repeat password:";
            // 
            // bttnCreateAccount
            // 
            this.bttnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(168)))), ((int)(((byte)(133)))));
            this.bttnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCreateAccount.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.bttnCreateAccount.Location = new System.Drawing.Point(229, 607);
            this.bttnCreateAccount.Name = "bttnCreateAccount";
            this.bttnCreateAccount.Padding = new System.Windows.Forms.Padding(10);
            this.bttnCreateAccount.Size = new System.Drawing.Size(261, 77);
            this.bttnCreateAccount.TabIndex = 8;
            this.bttnCreateAccount.Text = "create an account";
            this.bttnCreateAccount.UseVisualStyleBackColor = false;
            this.bttnCreateAccount.Click += new System.EventHandler(this.bttnCreateAcc_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.linkLabel2.Location = new System.Drawing.Point(224, 413);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 28);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "you don\'t have an account";
            // 
            // passwordRegistration
            // 
            this.passwordRegistration.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistration.Location = new System.Drawing.Point(319, 205);
            this.passwordRegistration.Name = "passwordRegistration";
            this.passwordRegistration.Size = new System.Drawing.Size(261, 35);
            this.passwordRegistration.TabIndex = 4;
            this.passwordRegistration.TextChanged += new System.EventHandler(this.passwordRegistration_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(65, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginRegistration
            // 
            this.loginRegistration.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistration.Location = new System.Drawing.Point(319, 133);
            this.loginRegistration.Name = "loginRegistration";
            this.loginRegistration.Size = new System.Drawing.Size(261, 35);
            this.loginRegistration.TabIndex = 2;
            this.loginRegistration.TextChanged += new System.EventHandler(this.loginRegistration_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(78, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(88, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userImgBox
            // 
            this.userImgBox.Location = new System.Drawing.Point(901, 316);
            this.userImgBox.Name = "userImgBox";
            this.userImgBox.Size = new System.Drawing.Size(143, 140);
            this.userImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userImgBox.TabIndex = 13;
            this.userImgBox.TabStop = false;
            this.userImgBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(168)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(1039, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 56);
            this.button1.TabIndex = 14;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(639, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "you can load your profile image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.label7.Location = new System.Drawing.Point(678, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "your image:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1462, 870);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox passwordRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnCreateAccount;
        private System.Windows.Forms.TextBox passwordRegistrationRepeat;
        private System.Windows.Forms.MonthCalendar userBirthdayDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox userImgBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}