namespace StudentPortal
{
    partial class LoggedInStudentPortal
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
            this.studentPortalTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.honorsCheck = new System.Windows.Forms.CheckBox();
            this.honorInput = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addressInput = new System.Windows.Forms.Label();
            this.statusInput = new System.Windows.Forms.Label();
            this.minorInput = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.Label();
            this.DOBInput = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.Label();
            this.majorInput = new System.Windows.Forms.Label();
            this.studentNameInput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yearList = new System.Windows.Forms.ListBox();
            this.getCoursesButton = new System.Windows.Forms.Button();
            this.seasonList = new System.Windows.Forms.ListBox();
            this.coursesView = new System.Windows.Forms.DataGridView();
            this.course_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_reqs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coReqs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gradesTabSplit = new System.Windows.Forms.SplitContainer();
            this.transcriptLabel = new System.Windows.Forms.Label();
            this.transcriptButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endSemList = new System.Windows.Forms.ComboBox();
            this.startSemList = new System.Windows.Forms.ComboBox();
            this.gradeViewLabel = new System.Windows.Forms.Label();
            this.dropdownSemesters = new System.Windows.Forms.ComboBox();
            this.gradeView = new System.Windows.Forms.DataGridView();
            this.col_SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SectionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SectionGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.studentPortalTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesTabSplit)).BeginInit();
            this.gradesTabSplit.Panel1.SuspendLayout();
            this.gradesTabSplit.Panel2.SuspendLayout();
            this.gradesTabSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPortalTabs
            // 
            this.studentPortalTabs.Controls.Add(this.tabPage1);
            this.studentPortalTabs.Controls.Add(this.tabPage2);
            this.studentPortalTabs.Controls.Add(this.tabPage3);
            this.studentPortalTabs.Location = new System.Drawing.Point(5, 14);
            this.studentPortalTabs.Margin = new System.Windows.Forms.Padding(5);
            this.studentPortalTabs.Name = "studentPortalTabs";
            this.studentPortalTabs.SelectedIndex = 0;
            this.studentPortalTabs.Size = new System.Drawing.Size(790, 422);
            this.studentPortalTabs.TabIndex = 0;
            this.studentPortalTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.InfoTabLoadSelected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.honorsCheck);
            this.tabPage1.Controls.Add(this.honorInput);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addressInput);
            this.tabPage1.Controls.Add(this.statusInput);
            this.tabPage1.Controls.Add(this.minorInput);
            this.tabPage1.Controls.Add(this.numberInput);
            this.tabPage1.Controls.Add(this.DOBInput);
            this.tabPage1.Controls.Add(this.emailInput);
            this.tabPage1.Controls.Add(this.majorInput);
            this.tabPage1.Controls.Add(this.studentNameInput);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(782, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // honorsCheck
            // 
            this.honorsCheck.AutoCheck = false;
            this.honorsCheck.AutoSize = true;
            this.honorsCheck.Location = new System.Drawing.Point(306, 357);
            this.honorsCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.honorsCheck.Name = "honorsCheck";
            this.honorsCheck.Size = new System.Drawing.Size(18, 17);
            this.honorsCheck.TabIndex = 29;
            this.honorsCheck.UseVisualStyleBackColor = true;
            // 
            // honorInput
            // 
            this.honorInput.AutoSize = true;
            this.honorInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.honorInput.Location = new System.Drawing.Point(112, 347);
            this.honorInput.Name = "honorInput";
            this.honorInput.Size = new System.Drawing.Size(149, 28);
            this.honorInput.TabIndex = 28;
            this.honorInput.Text = "Honors Student";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 34);
            this.button4.TabIndex = 27;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnEditPhoneClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnEditAddressClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnEditMinorClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnEditMajorClick);
            // 
            // addressInput
            // 
            this.addressInput.AutoSize = true;
            this.addressInput.BackColor = System.Drawing.Color.Transparent;
            this.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressInput.Location = new System.Drawing.Point(564, 301);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(2, 30);
            this.addressInput.TabIndex = 23;
            this.addressInput.VisibleChanged += new System.EventHandler(this.RefreshAddress);
            // 
            // statusInput
            // 
            this.statusInput.AutoSize = true;
            this.statusInput.BackColor = System.Drawing.Color.Transparent;
            this.statusInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusInput.Location = new System.Drawing.Point(150, 301);
            this.statusInput.Name = "statusInput";
            this.statusInput.Size = new System.Drawing.Size(2, 30);
            this.statusInput.TabIndex = 22;
            // 
            // minorInput
            // 
            this.minorInput.AutoSize = true;
            this.minorInput.BackColor = System.Drawing.Color.Transparent;
            this.minorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minorInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minorInput.Location = new System.Drawing.Point(150, 221);
            this.minorInput.Name = "minorInput";
            this.minorInput.Size = new System.Drawing.Size(2, 30);
            this.minorInput.TabIndex = 21;
            this.minorInput.VisibleChanged += new System.EventHandler(this.RefreshMinor);
            // 
            // numberInput
            // 
            this.numberInput.AutoSize = true;
            this.numberInput.BackColor = System.Drawing.Color.Transparent;
            this.numberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberInput.Location = new System.Drawing.Point(564, 221);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(2, 30);
            this.numberInput.TabIndex = 20;
            this.numberInput.VisibleChanged += new System.EventHandler(this.RefreshPhoneNumber);
            // 
            // DOBInput
            // 
            this.DOBInput.AutoSize = true;
            this.DOBInput.BackColor = System.Drawing.Color.Transparent;
            this.DOBInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DOBInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBInput.Location = new System.Drawing.Point(564, 63);
            this.DOBInput.Name = "DOBInput";
            this.DOBInput.Size = new System.Drawing.Size(2, 30);
            this.DOBInput.TabIndex = 19;
            // 
            // emailInput
            // 
            this.emailInput.AutoSize = true;
            this.emailInput.BackColor = System.Drawing.Color.Transparent;
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(564, 139);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(2, 30);
            this.emailInput.TabIndex = 18;
            // 
            // majorInput
            // 
            this.majorInput.AutoSize = true;
            this.majorInput.BackColor = System.Drawing.Color.Transparent;
            this.majorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.majorInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.majorInput.Location = new System.Drawing.Point(150, 139);
            this.majorInput.Name = "majorInput";
            this.majorInput.Size = new System.Drawing.Size(2, 30);
            this.majorInput.TabIndex = 17;
            this.majorInput.VisibleChanged += new System.EventHandler(this.RefreshMajor);
            // 
            // studentNameInput
            // 
            this.studentNameInput.AutoSize = true;
            this.studentNameInput.BackColor = System.Drawing.Color.Transparent;
            this.studentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameInput.Location = new System.Drawing.Point(150, 63);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(2, 30);
            this.studentNameInput.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(521, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(521, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(521, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "School Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Declared Minor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Declared Major";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearList);
            this.tabPage2.Controls.Add(this.getCoursesButton);
            this.tabPage2.Controls.Add(this.seasonList);
            this.tabPage2.Controls.Add(this.coursesView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(782, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yearList
            // 
            this.yearList.FormattingEnabled = true;
            this.yearList.ItemHeight = 20;
            this.yearList.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.yearList.Location = new System.Drawing.Point(214, 56);
            this.yearList.Name = "yearList";
            this.yearList.Size = new System.Drawing.Size(109, 44);
            this.yearList.TabIndex = 4;
            // 
            // getCoursesButton
            // 
            this.getCoursesButton.Location = new System.Drawing.Point(370, 65);
            this.getCoursesButton.Name = "getCoursesButton";
            this.getCoursesButton.Size = new System.Drawing.Size(156, 34);
            this.getCoursesButton.TabIndex = 2;
            this.getCoursesButton.Text = "Get Courses";
            this.getCoursesButton.UseVisualStyleBackColor = true;
            this.getCoursesButton.Click += new System.EventHandler(this.DisplayCoursesOnButtonClick);
            // 
            // seasonList
            // 
            this.seasonList.FormattingEnabled = true;
            this.seasonList.ItemHeight = 20;
            this.seasonList.Items.AddRange(new object[] {
            "Spring ",
            "Fall"});
            this.seasonList.Location = new System.Drawing.Point(60, 56);
            this.seasonList.Name = "seasonList";
            this.seasonList.Size = new System.Drawing.Size(110, 44);
            this.seasonList.TabIndex = 1;
            // 
            // coursesView
            // 
            this.coursesView.AllowUserToAddRows = false;
            this.coursesView.AllowUserToDeleteRows = false;
            this.coursesView.AllowUserToResizeColumns = false;
            this.coursesView.AllowUserToResizeRows = false;
            this.coursesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.coursesView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.coursesView.ColumnHeadersHeight = 34;
            this.coursesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.coursesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_title,
            this.course_num,
            this.instructor_full_name,
            this.day,
            this.start_time,
            this.end_time,
            this.pre_reqs,
            this.coReqs});
            this.coursesView.Location = new System.Drawing.Point(3, 160);
            this.coursesView.Name = "coursesView";
            this.coursesView.RowHeadersVisible = false;
            this.coursesView.RowHeadersWidth = 62;
            this.coursesView.RowTemplate.Height = 33;
            this.coursesView.ShowEditingIcon = false;
            this.coursesView.Size = new System.Drawing.Size(758, 231);
            this.coursesView.TabIndex = 0;
            this.coursesView.Visible = false;
            // 
            // course_title
            // 
            this.course_title.HeaderText = "Course Title";
            this.course_title.MinimumWidth = 8;
            this.course_title.Name = "course_title";
            this.course_title.ReadOnly = true;
            this.course_title.Width = 116;
            // 
            // course_num
            // 
            this.course_num.HeaderText = "Course Number";
            this.course_num.MinimumWidth = 8;
            this.course_num.Name = "course_num";
            this.course_num.ReadOnly = true;
            this.course_num.Width = 141;
            // 
            // instructor_full_name
            // 
            this.instructor_full_name.HeaderText = "Instructor Name";
            this.instructor_full_name.MinimumWidth = 8;
            this.instructor_full_name.Name = "instructor_full_name";
            this.instructor_full_name.ReadOnly = true;
            this.instructor_full_name.Width = 144;
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.MinimumWidth = 8;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 64;
            // 
            // start_time
            // 
            this.start_time.HeaderText = "Start Time";
            this.start_time.MinimumWidth = 8;
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            this.start_time.Width = 106;
            // 
            // end_time
            // 
            this.end_time.HeaderText = "End Time";
            this.end_time.MinimumWidth = 8;
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            // 
            // pre_reqs
            // 
            this.pre_reqs.HeaderText = "PreReqs";
            this.pre_reqs.MinimumWidth = 8;
            this.pre_reqs.Name = "pre_reqs";
            this.pre_reqs.ReadOnly = true;
            this.pre_reqs.Width = 91;
            // 
            // coReqs
            // 
            this.coReqs.HeaderText = "CoReqs";
            this.coReqs.MinimumWidth = 8;
            this.coReqs.Name = "coReqs";
            this.coReqs.ReadOnly = true;
            this.coReqs.Width = 88;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gradesTabSplit);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gradesTabSplit
            // 
            this.gradesTabSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradesTabSplit.Location = new System.Drawing.Point(3, 3);
            this.gradesTabSplit.Name = "gradesTabSplit";
            // 
            // gradesTabSplit.Panel1
            // 
            this.gradesTabSplit.Panel1.Controls.Add(this.transcriptLabel);
            this.gradesTabSplit.Panel1.Controls.Add(this.transcriptButton);
            this.gradesTabSplit.Panel1.Controls.Add(this.endLabel);
            this.gradesTabSplit.Panel1.Controls.Add(this.startLabel);
            this.gradesTabSplit.Panel1.Controls.Add(this.endSemList);
            this.gradesTabSplit.Panel1.Controls.Add(this.startSemList);
            // 
            // gradesTabSplit.Panel2
            // 
            this.gradesTabSplit.Panel2.Controls.Add(this.gradeViewLabel);
            this.gradesTabSplit.Panel2.Controls.Add(this.dropdownSemesters);
            this.gradesTabSplit.Panel2.Controls.Add(this.gradeView);
            this.gradesTabSplit.Size = new System.Drawing.Size(776, 383);
            this.gradesTabSplit.SplitterDistance = 256;
            this.gradesTabSplit.TabIndex = 5;
            // 
            // transcriptLabel
            // 
            this.transcriptLabel.AutoSize = true;
            this.transcriptLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transcriptLabel.Location = new System.Drawing.Point(47, 33);
            this.transcriptLabel.Name = "transcriptLabel";
            this.transcriptLabel.Size = new System.Drawing.Size(106, 28);
            this.transcriptLabel.TabIndex = 3;
            this.transcriptLabel.Text = "Transcript";
            // 
            // transcriptButton
            // 
            this.transcriptButton.Location = new System.Drawing.Point(56, 221);
            this.transcriptButton.Name = "transcriptButton";
            this.transcriptButton.Size = new System.Drawing.Size(129, 29);
            this.transcriptButton.TabIndex = 5;
            this.transcriptButton.Text = "Get Transcript";
            this.transcriptButton.UseVisualStyleBackColor = true;
            this.transcriptButton.Click += new System.EventHandler(this.OnTranscriptButtonClick);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(47, 144);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(99, 20);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End Semester";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(47, 79);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(105, 20);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start Semester";
            // 
            // endSemList
            // 
            this.endSemList.FormattingEnabled = true;
            this.endSemList.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.endSemList.Location = new System.Drawing.Point(47, 167);
            this.endSemList.MaxDropDownItems = 4;
            this.endSemList.Name = "endSemList";
            this.endSemList.Size = new System.Drawing.Size(151, 28);
            this.endSemList.TabIndex = 2;
            this.endSemList.Text = "choose semester";
            // 
            // startSemList
            // 
            this.startSemList.FormattingEnabled = true;
            this.startSemList.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.startSemList.Location = new System.Drawing.Point(47, 102);
            this.startSemList.MaxDropDownItems = 4;
            this.startSemList.Name = "startSemList";
            this.startSemList.Size = new System.Drawing.Size(151, 28);
            this.startSemList.TabIndex = 1;
            this.startSemList.Text = "choose semester";
            // 
            // gradeViewLabel
            // 
            this.gradeViewLabel.AutoSize = true;
            this.gradeViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradeViewLabel.Location = new System.Drawing.Point(20, 33);
            this.gradeViewLabel.Name = "gradeViewLabel";
            this.gradeViewLabel.Size = new System.Drawing.Size(129, 28);
            this.gradeViewLabel.TabIndex = 2;
            this.gradeViewLabel.Text = "View Grades";
            // 
            // dropdownSemesters
            // 
            this.dropdownSemesters.FormattingEnabled = true;
            this.dropdownSemesters.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.dropdownSemesters.Location = new System.Drawing.Point(336, 33);
            this.dropdownSemesters.MaxDropDownItems = 4;
            this.dropdownSemesters.Name = "dropdownSemesters";
            this.dropdownSemesters.Size = new System.Drawing.Size(151, 28);
            this.dropdownSemesters.TabIndex = 0;
            this.dropdownSemesters.Text = "choose semester";
            this.dropdownSemesters.SelectedValueChanged += new System.EventHandler(this.SemesterSelected);
            // 
            // gradeView
            // 
            this.gradeView.AllowUserToAddRows = false;
            this.gradeView.AllowUserToDeleteRows = false;
            this.gradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SectionName,
            this.col_SectionCode,
            this.col_SectionGrade});
            this.gradeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradeView.Location = new System.Drawing.Point(0, 98);
            this.gradeView.Name = "gradeView";
            this.gradeView.RowHeadersVisible = false;
            this.gradeView.RowHeadersWidth = 51;
            this.gradeView.RowTemplate.Height = 29;
            this.gradeView.Size = new System.Drawing.Size(516, 285);
            this.gradeView.TabIndex = 1;
            // 
            // col_SectionName
            // 
            this.col_SectionName.HeaderText = "Section Name";
            this.col_SectionName.MinimumWidth = 6;
            this.col_SectionName.Name = "col_SectionName";
            this.col_SectionName.Width = 145;
            // 
            // col_SectionCode
            // 
            this.col_SectionCode.HeaderText = "Section Code";
            this.col_SectionCode.MinimumWidth = 6;
            this.col_SectionCode.Name = "col_SectionCode";
            this.col_SectionCode.Width = 125;
            // 
            // col_SectionGrade
            // 
            this.col_SectionGrade.HeaderText = "Grade";
            this.col_SectionGrade.MinimumWidth = 6;
            this.col_SectionGrade.Name = "col_SectionGrade";
            this.col_SectionGrade.Width = 125;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save transcript as...";
            // 
            // LoggedInStudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentPortalTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoggedInStudentPortal";
            this.Text = "My Student Portal";
            this.studentPortalTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gradesTabSplit.Panel1.ResumeLayout(false);
            this.gradesTabSplit.Panel1.PerformLayout();
            this.gradesTabSplit.Panel2.ResumeLayout(false);
            this.gradesTabSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesTabSplit)).EndInit();
            this.gradesTabSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl studentPortalTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label studentNameInput;
        private Label statusInput;
        private Label minorInput;
        private Label numberInput;
        private Label DOBInput;
        private Label emailInput;
        private Label majorInput;
        private Label addressInput;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox honorsCheck;
        private Label honorInput;
        private ComboBox dropdownSemesters;
        private SplitContainer gradesTabSplit;
        private DataGridView gradeView;
        private Label gradeViewLabel;
        private Label endLabel;
        private Label startLabel;
        private ComboBox endSemList;
        private ComboBox startSemList;
        private Label transcriptLabel;
        private Button transcriptButton;
        private SaveFileDialog saveFileDialog;
        private ListBox registration_semester_list;
        private Label registration_instructions;
        private Button view_courses_button;
        private TableLayoutPanel courses_table;
        private Label course_title_header_table;
        private ListBox seasonList;
        private DataGridView coursesView;
        private Button getCoursesButton;
        private ListBox yearList;
        private DataGridViewTextBoxColumn course_title;
        private DataGridViewTextBoxColumn course_num;
        private DataGridViewTextBoxColumn instructor_full_name;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn pre_reqs;
        private DataGridViewTextBoxColumn coReqs;
        private DataGridViewTextBoxColumn col_SectionName;
        private DataGridViewTextBoxColumn col_SectionCode;
        private DataGridViewTextBoxColumn col_SectionGrade;
    }
}