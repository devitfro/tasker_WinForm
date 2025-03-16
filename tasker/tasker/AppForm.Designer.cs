namespace tasker
{
    partial class AppForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priorityTrack = new System.Windows.Forms.TrackBar();
            this.priority = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.textTaskDescr = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.task_name = new System.Windows.Forms.DataGridViewButtonColumn();
            this.task_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.helloBox = new System.Windows.Forms.GroupBox();
            this.helloUserLogin = new System.Windows.Forms.Label();
            this.helloName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userPhotoBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.helloBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gentium Book Basic", 28.14545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(655, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Manager App";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(196, 588);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(0, 0);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.groupBox2.Controls.Add(this.priorityTrack);
            this.groupBox2.Controls.Add(this.priority);
            this.groupBox2.Controls.Add(this.bttnDelete);
            this.groupBox2.Controls.Add(this.monthCalendar);
            this.groupBox2.Controls.Add(this.bttnEdit);
            this.groupBox2.Controls.Add(this.textTaskDescr);
            this.groupBox2.Controls.Add(this.bttnAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textTaskName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(441, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 370);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "to do:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // priorityTrack
            // 
            this.priorityTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.priorityTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priorityTrack.Location = new System.Drawing.Point(136, 213);
            this.priorityTrack.Name = "priorityTrack";
            this.priorityTrack.Size = new System.Drawing.Size(295, 50);
            this.priorityTrack.TabIndex = 22;
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.ForeColor = System.Drawing.Color.Black;
            this.priority.Location = new System.Drawing.Point(17, 226);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(91, 28);
            this.priority.TabIndex = 21;
            this.priority.Text = "priority";
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.bttnDelete.Location = new System.Drawing.Point(323, 297);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(108, 49);
            this.bttnDelete.TabIndex = 20;
            this.bttnDelete.TabStop = false;
            this.bttnDelete.Text = "delete";
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.monthCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.monthCalendar.Location = new System.Drawing.Point(549, 79);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 10;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.Desktop;
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.Gray;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // bttnEdit
            // 
            this.bttnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.bttnEdit.Location = new System.Drawing.Point(172, 297);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(108, 49);
            this.bttnEdit.TabIndex = 19;
            this.bttnEdit.Text = "edit";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            this.bttnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttn_MouseDown);
            this.bttnEdit.MouseEnter += new System.EventHandler(this.bttn_MouseEnter);
            this.bttnEdit.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            this.bttnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttn_MouseUp);
            // 
            // textTaskDescr
            // 
            this.textTaskDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTaskDescr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textTaskDescr.Location = new System.Drawing.Point(15, 160);
            this.textTaskDescr.Name = "textTaskDescr";
            this.textTaskDescr.Size = new System.Drawing.Size(416, 35);
            this.textTaskDescr.TabIndex = 17;
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.bttnAdd.Location = new System.Drawing.Point(22, 297);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(108, 49);
            this.bttnAdd.TabIndex = 16;
            this.bttnAdd.Text = "add";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            this.bttnAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttn_MouseDown);
            this.bttnAdd.MouseEnter += new System.EventHandler(this.bttn_MouseEnter);
            this.bttnAdd.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            this.bttnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttn_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(554, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "task deadline:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "task description:";
            // 
            // textTaskName
            // 
            this.textTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTaskName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textTaskName.Location = new System.Drawing.Point(15, 79);
            this.textTaskName.Margin = new System.Windows.Forms.Padding(15);
            this.textTaskName.Name = "textTaskName";
            this.textTaskName.Size = new System.Drawing.Size(416, 35);
            this.textTaskName.TabIndex = 11;
            this.textTaskName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "task name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(210)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gentium Book Basic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task_name,
            this.task_description,
            this.deadline,
            this.priority_task});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gentium Book Basic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(10, 585);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gentium Book Basic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidth = 47;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(5)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(5)))), ((int)(((byte)(69)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.Size = new System.Drawing.Size(1617, 285);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // task_name
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.task_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.task_name.HeaderText = "task name";
            this.task_name.MinimumWidth = 6;
            this.task_name.Name = "task_name";
            this.task_name.ReadOnly = true;
            this.task_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.task_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // task_description
            // 
            this.task_description.HeaderText = "task description";
            this.task_description.MinimumWidth = 6;
            this.task_description.Name = "task_description";
            this.task_description.ReadOnly = true;
            // 
            // deadline
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deadline.DefaultCellStyle = dataGridViewCellStyle4;
            this.deadline.HeaderText = "deadline";
            this.deadline.MinimumWidth = 6;
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // priority_task
            // 
            this.priority_task.HeaderText = "priority";
            this.priority_task.MinimumWidth = 6;
            this.priority_task.Name = "priority_task";
            this.priority_task.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(210)))));
            this.flowLayoutPanel1.Controls.Add(this.helloBox);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 585);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // helloBox
            // 
            this.helloBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.helloBox.Controls.Add(this.helloUserLogin);
            this.helloBox.Controls.Add(this.helloName);
            this.helloBox.Controls.Add(this.label7);
            this.helloBox.Controls.Add(this.userPhotoBox);
            this.helloBox.Location = new System.Drawing.Point(3, 3);
            this.helloBox.Name = "helloBox";
            this.helloBox.Size = new System.Drawing.Size(187, 278);
            this.helloBox.TabIndex = 19;
            this.helloBox.TabStop = false;
            this.helloBox.Enter += new System.EventHandler(this.helloBox_Enter);
            // 
            // helloUserLogin
            // 
            this.helloUserLogin.AutoSize = true;
            this.helloUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.helloUserLogin.Location = new System.Drawing.Point(92, 178);
            this.helloUserLogin.Name = "helloUserLogin";
            this.helloUserLogin.Size = new System.Drawing.Size(71, 28);
            this.helloUserLogin.TabIndex = 3;
            this.helloUserLogin.Text = "label8";
            // 
            // helloName
            // 
            this.helloName.AutoSize = true;
            this.helloName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.helloName.Location = new System.Drawing.Point(92, 178);
            this.helloName.Name = "helloName";
            this.helloName.Size = new System.Drawing.Size(0, 28);
            this.helloName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hello,";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // userPhotoBox
            // 
            this.userPhotoBox.Location = new System.Drawing.Point(33, 34);
            this.userPhotoBox.Name = "userPhotoBox";
            this.userPhotoBox.Size = new System.Drawing.Size(117, 117);
            this.userPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhotoBox.TabIndex = 0;
            this.userPhotoBox.TabStop = false;
            this.userPhotoBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 66);
            this.panel3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.button1.Image = global::tasker.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 8);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(254, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "       home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(3, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 69);
            this.panel2.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.button5.Image = global::tasker.Properties.Resources.info;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(251, 56);
            this.button5.TabIndex = 14;
            this.button5.Text = "       info";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Location = new System.Drawing.Point(3, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 69);
            this.panel1.TabIndex = 18;
            // 
            // bttnExit
            // 
            this.bttnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.bttnExit.Image = global::tasker.Properties.Resources.exit;
            this.bttnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnExit.Location = new System.Drawing.Point(-3, 13);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bttnExit.Size = new System.Drawing.Size(234, 56);
            this.bttnExit.TabIndex = 16;
            this.bttnExit.Text = "       exit";
            this.bttnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1627, 870);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gentium Book Basic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AppForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.helloBox.ResumeLayout(false);
            this.helloBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox textTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTaskDescr;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.TrackBar priorityTrack;
        private System.Windows.Forms.DataGridViewButtonColumn task_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority_task;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox helloBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox userPhotoBox;
        private System.Windows.Forms.Label helloName;
        private System.Windows.Forms.Label helloUserLogin;
    }
}

