namespace tasker
{
    partial class WelcomeForm
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
            this.bttnEnterWelcome = new System.Windows.Forms.Button();
            this.passwordWelcome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginWelcome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.bttnEnterWelcome);
            this.panel1.Controls.Add(this.passwordWelcome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginWelcome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(445, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttnEnterWelcome
            // 
            this.bttnEnterWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(168)))), ((int)(((byte)(133)))));
            this.bttnEnterWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnterWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnEnterWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEnterWelcome.Location = new System.Drawing.Point(116, 338);
            this.bttnEnterWelcome.Name = "bttnEnterWelcome";
            this.bttnEnterWelcome.Padding = new System.Windows.Forms.Padding(10);
            this.bttnEnterWelcome.Size = new System.Drawing.Size(268, 77);
            this.bttnEnterWelcome.TabIndex = 6;
            this.bttnEnterWelcome.Text = "enter to account";
            this.bttnEnterWelcome.UseVisualStyleBackColor = false;
            this.bttnEnterWelcome.Click += new System.EventHandler(this.bttnEnterWelcome_Click);
            // 
            // passwordWelcome
            // 
            this.passwordWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordWelcome.Location = new System.Drawing.Point(171, 234);
            this.passwordWelcome.Name = "passwordWelcome";
            this.passwordWelcome.Size = new System.Drawing.Size(261, 35);
            this.passwordWelcome.TabIndex = 4;
            this.passwordWelcome.TextChanged += new System.EventHandler(this.txtPasswordWelcome_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(28, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginWelcome
            // 
            this.loginWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWelcome.Location = new System.Drawing.Point(171, 162);
            this.loginWelcome.Name = "loginWelcome";
            this.loginWelcome.Size = new System.Drawing.Size(261, 35);
            this.loginWelcome.TabIndex = 2;
            this.loginWelcome.TextChanged += new System.EventHandler(this.txtLoginWelcome_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(55, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "login:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to app";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.linkLabel2.Location = new System.Drawing.Point(111, 442);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 28);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "you don\'t have an account";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1462, 870);
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordWelcome;
        private System.Windows.Forms.Button bttnEnterWelcome;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}