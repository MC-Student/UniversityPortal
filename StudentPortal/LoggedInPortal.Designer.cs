namespace StudentPortal
{
    partial class LoggedInPortal
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.studentPortalTabs.SuspendLayout();
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
            this.studentPortalTabs.Location = new System.Drawing.Point(14, 14);
            this.studentPortalTabs.Margin = new System.Windows.Forms.Padding(5);
            this.studentPortalTabs.Name = "studentPortalTabs";
            this.studentPortalTabs.SelectedIndex = 0;
            this.studentPortalTabs.Size = new System.Drawing.Size(772, 427);
            this.studentPortalTabs.TabIndex = 0;
            this.studentPortalTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.InfoTabLoadSelected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Information";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(764, 394);
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
            this.tabPage3.Size = new System.Drawing.Size(764, 394);
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
            this.gradesTabSplit.Size = new System.Drawing.Size(758, 388);
            this.gradesTabSplit.SplitterDistance = 251;
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
            this.gradeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradeView.Location = new System.Drawing.Point(0, 103);
            this.gradeView.Name = "gradeView";
            this.gradeView.RowHeadersVisible = false;
            this.gradeView.RowHeadersWidth = 51;
            this.gradeView.RowTemplate.Height = 29;
            this.gradeView.Size = new System.Drawing.Size(503, 285);
            this.gradeView.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save transcript as...";
            // 
            // LoggedInPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentPortalTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoggedInPortal";
            this.Text = "LoggedInPortal";
            this.studentPortalTabs.ResumeLayout(false);
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
    }
}