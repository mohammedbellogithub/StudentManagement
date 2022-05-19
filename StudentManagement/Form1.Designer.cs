namespace StudentManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sortByclass6 = new System.Windows.Forms.Button();
            this.sortByClass4 = new System.Windows.Forms.Button();
            this.sortByclass5 = new System.Windows.Forms.Button();
            this.sortByclass3 = new System.Windows.Forms.Button();
            this.sortByClass2 = new System.Windows.Forms.Button();
            this.sortByClass1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.studentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.studentClass = new System.Windows.Forms.TextBox();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.studentPhone = new System.Windows.Forms.TextBox();
            this.studentLastname = new System.Windows.Forms.TextBox();
            this.studentFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reloadButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteFromSearch = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.searchPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.randomSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.loadStudentData = new System.Windows.Forms.Button();
            this.randomByClass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.studentDateOfBirth);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.studentClass);
            this.groupBox1.Controls.Add(this.studentEmail);
            this.groupBox1.Controls.Add(this.studentPhone);
            this.groupBox1.Controls.Add(this.studentLastname);
            this.groupBox1.Controls.Add(this.studentFirstname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(54, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 811);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortByclass6);
            this.groupBox2.Controls.Add(this.sortByClass4);
            this.groupBox2.Controls.Add(this.sortByclass5);
            this.groupBox2.Controls.Add(this.sortByclass3);
            this.groupBox2.Controls.Add(this.sortByClass2);
            this.groupBox2.Controls.Add(this.sortByClass1);
            this.groupBox2.Location = new System.Drawing.Point(41, 582);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 200);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by Class";
            // 
            // sortByclass6
            // 
            this.sortByclass6.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByclass6.Location = new System.Drawing.Point(529, 129);
            this.sortByclass6.Name = "sortByclass6";
            this.sortByclass6.Size = new System.Drawing.Size(150, 46);
            this.sortByclass6.TabIndex = 5;
            this.sortByclass6.Text = "Class 6";
            this.sortByclass6.UseVisualStyleBackColor = true;
            this.sortByclass6.Click += new System.EventHandler(this.sortByclass6_Click);
            // 
            // sortByClass4
            // 
            this.sortByClass4.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByClass4.Location = new System.Drawing.Point(27, 129);
            this.sortByClass4.Name = "sortByClass4";
            this.sortByClass4.Size = new System.Drawing.Size(150, 46);
            this.sortByClass4.TabIndex = 4;
            this.sortByClass4.Text = "Class 4";
            this.sortByClass4.UseVisualStyleBackColor = true;
            this.sortByClass4.Click += new System.EventHandler(this.sortByClass4_Click);
            // 
            // sortByclass5
            // 
            this.sortByclass5.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByclass5.Location = new System.Drawing.Point(271, 129);
            this.sortByclass5.Name = "sortByclass5";
            this.sortByclass5.Size = new System.Drawing.Size(150, 46);
            this.sortByclass5.TabIndex = 3;
            this.sortByclass5.Text = "Class 5";
            this.sortByclass5.UseVisualStyleBackColor = true;
            this.sortByclass5.Click += new System.EventHandler(this.sortByclass5_Click);
            // 
            // sortByclass3
            // 
            this.sortByclass3.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByclass3.Location = new System.Drawing.Point(529, 64);
            this.sortByclass3.Name = "sortByclass3";
            this.sortByclass3.Size = new System.Drawing.Size(150, 46);
            this.sortByclass3.TabIndex = 2;
            this.sortByclass3.Text = "Class 3";
            this.sortByclass3.UseVisualStyleBackColor = true;
            this.sortByclass3.Click += new System.EventHandler(this.sortByclass3_Click);
            // 
            // sortByClass2
            // 
            this.sortByClass2.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByClass2.Location = new System.Drawing.Point(271, 64);
            this.sortByClass2.Name = "sortByClass2";
            this.sortByClass2.Size = new System.Drawing.Size(150, 46);
            this.sortByClass2.TabIndex = 1;
            this.sortByClass2.Text = "Class 2";
            this.sortByClass2.UseVisualStyleBackColor = true;
            this.sortByClass2.Click += new System.EventHandler(this.sortByClass2_Click);
            // 
            // sortByClass1
            // 
            this.sortByClass1.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortByClass1.Location = new System.Drawing.Point(27, 64);
            this.sortByClass1.Name = "sortByClass1";
            this.sortByClass1.Size = new System.Drawing.Size(150, 46);
            this.sortByClass1.TabIndex = 0;
            this.sortByClass1.Text = "Class 1";
            this.sortByClass1.UseVisualStyleBackColor = true;
            this.sortByClass1.Click += new System.EventHandler(this.sortByClass1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date of Birth";
            // 
            // studentDateOfBirth
            // 
            this.studentDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentDateOfBirth.Location = new System.Drawing.Point(369, 376);
            this.studentDateOfBirth.Name = "studentDateOfBirth";
            this.studentDateOfBirth.Size = new System.Drawing.Size(387, 39);
            this.studentDateOfBirth.TabIndex = 18;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(257, 499);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 46);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.update_Button);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(661, 499);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 46);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(459, 499);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 46);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(31, 499);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(150, 46);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.register_Button);
            // 
            // studentClass
            // 
            this.studentClass.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentClass.Location = new System.Drawing.Point(369, 306);
            this.studentClass.Name = "studentClass";
            this.studentClass.Size = new System.Drawing.Size(387, 43);
            this.studentClass.TabIndex = 9;
            // 
            // studentEmail
            // 
            this.studentEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentEmail.Location = new System.Drawing.Point(369, 238);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(387, 43);
            this.studentEmail.TabIndex = 8;
            // 
            // studentPhone
            // 
            this.studentPhone.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentPhone.Location = new System.Drawing.Point(369, 183);
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(387, 43);
            this.studentPhone.TabIndex = 7;
            // 
            // studentLastname
            // 
            this.studentLastname.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentLastname.Location = new System.Drawing.Point(369, 116);
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.Size = new System.Drawing.Size(387, 43);
            this.studentLastname.TabIndex = 6;
            // 
            // studentFirstname
            // 
            this.studentFirstname.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentFirstname.Location = new System.Drawing.Point(369, 60);
            this.studentFirstname.Name = "studentFirstname";
            this.studentFirstname.Size = new System.Drawing.Size(387, 43);
            this.studentFirstname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gray;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(767, 138);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 46);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(889, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 393);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Red;
            this.reloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadButton.ForeColor = System.Drawing.Color.Black;
            this.reloadButton.Location = new System.Drawing.Point(1865, 415);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(150, 46);
            this.reloadButton.TabIndex = 18;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteFromSearch);
            this.groupBox3.Controls.Add(this.loadData);
            this.groupBox3.Controls.Add(this.searchPhone);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.searchEmail);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Location = new System.Drawing.Point(1005, 706);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 200);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search with Email and Phone Number";
            // 
            // deleteFromSearch
            // 
            this.deleteFromSearch.BackColor = System.Drawing.Color.Red;
            this.deleteFromSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFromSearch.ForeColor = System.Drawing.Color.Black;
            this.deleteFromSearch.Location = new System.Drawing.Point(767, 76);
            this.deleteFromSearch.Name = "deleteFromSearch";
            this.deleteFromSearch.Size = new System.Drawing.Size(150, 46);
            this.deleteFromSearch.TabIndex = 19;
            this.deleteFromSearch.Text = "Delete";
            this.deleteFromSearch.UseVisualStyleBackColor = false;
            this.deleteFromSearch.Click += new System.EventHandler(this.deleteFromSearch_Click);
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.Gray;
            this.loadData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadData.ForeColor = System.Drawing.Color.Black;
            this.loadData.Location = new System.Drawing.Point(767, 18);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(150, 46);
            this.loadData.TabIndex = 18;
            this.loadData.Text = "Load";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // searchPhone
            // 
            this.searchPhone.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchPhone.Location = new System.Drawing.Point(300, 111);
            this.searchPhone.Name = "searchPhone";
            this.searchPhone.Size = new System.Drawing.Size(387, 43);
            this.searchPhone.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone Number";
            // 
            // searchEmail
            // 
            this.searchEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchEmail.Location = new System.Drawing.Point(300, 58);
            this.searchEmail.Name = "searchEmail";
            this.searchEmail.Size = new System.Drawing.Size(387, 43);
            this.searchEmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.randomSearch);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.loadStudentData);
            this.groupBox4.Controls.Add(this.randomByClass);
            this.groupBox4.Location = new System.Drawing.Point(900, 482);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1115, 200);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Random Search";
            // 
            // randomSearch
            // 
            this.randomSearch.Location = new System.Drawing.Point(275, 90);
            this.randomSearch.Name = "randomSearch";
            this.randomSearch.Size = new System.Drawing.Size(517, 39);
            this.randomSearch.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(6, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Class 1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // loadStudentData
            // 
            this.loadStudentData.BackColor = System.Drawing.SystemColors.Info;
            this.loadStudentData.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadStudentData.Location = new System.Drawing.Point(6, 90);
            this.loadStudentData.Name = "loadStudentData";
            this.loadStudentData.Size = new System.Drawing.Size(150, 46);
            this.loadStudentData.TabIndex = 2;
            this.loadStudentData.Text = "Load";
            this.loadStudentData.UseVisualStyleBackColor = false;
            this.loadStudentData.Click += new System.EventHandler(this.loadStudentData_Click);
            // 
            // randomByClass
            // 
            this.randomByClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randomByClass.Font = new System.Drawing.Font("Yu Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.randomByClass.Location = new System.Drawing.Point(6, 38);
            this.randomByClass.Name = "randomByClass";
            this.randomByClass.Size = new System.Drawing.Size(150, 46);
            this.randomByClass.TabIndex = 1;
            this.randomByClass.Text = "By Class";
            this.randomByClass.UseVisualStyleBackColor = false;
            this.randomByClass.Click += new System.EventHandler(this.randomByClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2030, 963);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox studentClass;
        private TextBox studentEmail;
        private TextBox studentPhone;
        private TextBox studentLastname;
        private TextBox studentFirstname;
        private Button clearButton;
        private Button updateButton;
        private Button searchButton;
        private Button deleteButton;
        private Button registerButton;
        private DataGridView dataGridView1;
        private Label label6;
        private DateTimePicker studentDateOfBirth;
        private Button reloadButton;
        private GroupBox groupBox2;
        private Button sortByclass6;
        private Button sortByClass4;
        private Button sortByclass5;
        private Button sortByclass3;
        private Button sortByClass2;
        private Button sortByClass1;
        private GroupBox groupBox3;
        private TextBox searchPhone;
        private Label label8;
        private TextBox searchEmail;
        private Label label7;
        private Button deleteFromSearch;
        private Button loadData;
        private GroupBox groupBox4;
        private TextBox randomSearch;
        private Button button3;
        private Button loadStudentData;
        private Button randomByClass;
    }
}