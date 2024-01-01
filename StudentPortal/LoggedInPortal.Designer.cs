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
            tab_grades = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            semester_list_year = new ListBox();
            get_courses_button = new Button();
            semester_list_seaon = new ListBox();
            data_grid_view_courses = new DataGridView();
            course_title = new DataGridViewTextBoxColumn();
            course_num = new DataGridViewTextBoxColumn();
            instructor_full_name = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            start_time = new DataGridViewTextBoxColumn();
            end_time = new DataGridViewTextBoxColumn();
            pre_reqs = new DataGridViewTextBoxColumn();
            coReqs = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            tab_grades.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid_view_courses).BeginInit();
            SuspendLayout();
            this.tab_grades = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gradesSplit = new System.Windows.Forms.SplitContainer();
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
            this.tab_grades.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesSplit)).BeginInit();
            this.gradesSplit.Panel1.SuspendLayout();
            this.gradesSplit.Panel2.SuspendLayout();
            this.gradesSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeView)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_grades
            // 
            this.tab_grades.Controls.Add(this.tabPage1);
            this.tab_grades.Controls.Add(this.tabPage2);
            this.tab_grades.Controls.Add(this.tabPage3);
            this.tab_grades.Location = new System.Drawing.Point(12, 12);
            this.tab_grades.Name = "tab_grades";
            this.tab_grades.SelectedIndex = 0;
            this.tab_grades.Size = new System.Drawing.Size(776, 426);
            this.tab_grades.TabIndex = 0;
            this.tab_grades.Selected += new System.Windows.Forms.TabControlEventHandler(this.InfoTabLoadSelected);
            tab_grades.Controls.Add(tabPage1);
            tab_grades.Controls.Add(tabPage2);
            tab_grades.Controls.Add(tabPage3);
            tab_grades.Location = new Point(19, 19);
            tab_grades.Margin = new Padding(5);
            tab_grades.Name = "tab_grades";
            tab_grades.SelectedIndex = 0;
            tab_grades.Size = new Size(1212, 665);
            tab_grades.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1204, 627);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "My Information";
            tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(semester_list_year);
            tabPage2.Controls.Add(get_courses_button);
            tabPage2.Controls.Add(semester_list_seaon);
            tabPage2.Controls.Add(data_grid_view_courses);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1204, 627);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // semester_list_year
            // 
            semester_list_year.FormattingEnabled = true;
            semester_list_year.ItemHeight = 25;
            semester_list_year.Items.AddRange(new object[] { "2020", "2021" });
            semester_list_year.Location = new Point(214, 56);
            semester_list_year.Name = "semester_list_year";
            semester_list_year.Size = new Size(109, 54);
            semester_list_year.TabIndex = 4;
            // 
            // get_courses_button
            // 
            get_courses_button.Location = new Point(370, 65);
            get_courses_button.Name = "get_courses_button";
            get_courses_button.Size = new Size(156, 34);
            get_courses_button.TabIndex = 2;
            get_courses_button.Text = "Get Courses";
            get_courses_button.UseVisualStyleBackColor = true;
            get_courses_button.Click += get_courses_button_Click;
            // 
            // semester_list_seaon
            // 
            semester_list_seaon.FormattingEnabled = true;
            semester_list_seaon.ItemHeight = 25;
            semester_list_seaon.Items.AddRange(new object[] { "Spring ", "Fall" });
            semester_list_seaon.Location = new Point(60, 56);
            semester_list_seaon.Name = "semester_list_seaon";
            semester_list_seaon.Size = new Size(110, 54);
            semester_list_seaon.TabIndex = 1;
            // 
            // data_grid_view_courses
            // 
            data_grid_view_courses.AllowUserToAddRows = false;
            data_grid_view_courses.AllowUserToDeleteRows = false;
            data_grid_view_courses.AllowUserToResizeColumns = false;
            data_grid_view_courses.AllowUserToResizeRows = false;
            data_grid_view_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_grid_view_courses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid_view_courses.ColumnHeadersHeight = 34;
            data_grid_view_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_grid_view_courses.Columns.AddRange(new DataGridViewColumn[] { course_title, course_num, instructor_full_name, day, start_time, end_time, pre_reqs, coReqs });
            data_grid_view_courses.Location = new Point(3, 160);
            data_grid_view_courses.Name = "data_grid_view_courses";
            data_grid_view_courses.RowHeadersVisible = false;
            data_grid_view_courses.RowHeadersWidth = 62;
            data_grid_view_courses.RowTemplate.Height = 33;
            data_grid_view_courses.ShowEditingIcon = false;
            data_grid_view_courses.Size = new Size(969, 337);
            data_grid_view_courses.TabIndex = 0;
            data_grid_view_courses.Visible = false;
            // 
            // course_title
            // 
            course_title.HeaderText = "Course Title";
            course_title.MinimumWidth = 8;
            course_title.Name = "course_title";
            course_title.ReadOnly = true;
            course_title.Width = 140;
            // 
            // course_num
            // 
            course_num.HeaderText = "Course Number";
            course_num.MinimumWidth = 8;
            course_num.Name = "course_num";
            course_num.ReadOnly = true;
            course_num.Width = 173;
            // 
            // instructor_full_name
            // 
            instructor_full_name.HeaderText = "Instructor Name";
            instructor_full_name.MinimumWidth = 8;
            instructor_full_name.Name = "instructor_full_name";
            instructor_full_name.ReadOnly = true;
            instructor_full_name.Width = 176;
            // 
            // day
            // 
            day.HeaderText = "Day";
            day.MinimumWidth = 8;
            day.Name = "day";
            day.ReadOnly = true;
            day.Width = 79;
            // 
            // start_time
            // 
            start_time.HeaderText = "Start Time";
            start_time.MinimumWidth = 8;
            start_time.Name = "start_time";
            start_time.ReadOnly = true;
            start_time.Width = 127;
            // 
            // end_time
            // 
            end_time.HeaderText = "End Time";
            end_time.MinimumWidth = 8;
            end_time.Name = "end_time";
            end_time.ReadOnly = true;
            end_time.Width = 121;
            // 
            // pre_reqs
            // 
            pre_reqs.HeaderText = "PreReqs";
            pre_reqs.MinimumWidth = 8;
            pre_reqs.Name = "pre_reqs";
            pre_reqs.ReadOnly = true;
            pre_reqs.Width = 111;
            // 
            // coReqs
            // 
            coReqs.HeaderText = "CoReqs";
            coReqs.MinimumWidth = 8;
            coReqs.Name = "coReqs";
            coReqs.ReadOnly = true;
            coReqs.Width = 108;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gradesSplit);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1204, 627);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "My Grades";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // LoggedInPortal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(tab_grades);
            Margin = new Padding(4);
            Name = "LoggedInPortal";
            Text = "LoggedInPortal";
            tab_grades.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_grid_view_courses).EndInit();
            ResumeLayout(false);

            this.tabPage3.Controls.Add(this.dropdownSemesters);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gradesSplit
            // 
            this.gradesSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradesSplit.Location = new System.Drawing.Point(3, 3);
            this.gradesSplit.Name = "gradesSplit";
            // 
            // gradesSplit.Panel1
            // 
            this.gradesSplit.Panel1.Controls.Add(this.transcriptLabel);
            this.gradesSplit.Panel1.Controls.Add(this.transcriptButton);
            this.gradesSplit.Panel1.Controls.Add(this.endLabel);
            this.gradesSplit.Panel1.Controls.Add(this.startLabel);
            this.gradesSplit.Panel1.Controls.Add(this.endSemList);
            this.gradesSplit.Panel1.Controls.Add(this.startSemList);
            // 
            // gradesSplit.Panel2
            // 
            this.gradesSplit.Panel2.Controls.Add(this.gradeViewLabel);
            this.gradesSplit.Panel2.Controls.Add(this.dropdownSemesters);
            this.gradesSplit.Panel2.Controls.Add(this.gradeView);
            this.gradesSplit.Size = new System.Drawing.Size(762, 387);
            this.gradesSplit.SplitterDistance = 253;
            this.gradesSplit.TabIndex = 5;
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
            this.transcriptButton.Click += new System.EventHandler(this.transcriptButton_Click);
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
            this.gradeView.Location = new System.Drawing.Point(0, 102);
            this.gradeView.Name = "gradeView";
            this.gradeView.RowHeadersVisible = false;
            this.gradeView.RowHeadersWidth = 51;
            this.gradeView.RowTemplate.Height = 29;
            this.gradeView.Size = new System.Drawing.Size(505, 285);
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
            this.Controls.Add(this.tab_grades);
            this.Name = "LoggedInPortal";
            this.Text = "LoggedInPortal";
            this.tab_grades.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gradesSplit.Panel1.ResumeLayout(false);
            this.gradesSplit.Panel1.PerformLayout();
            this.gradesSplit.Panel2.ResumeLayout(false);
            this.gradesSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesSplit)).EndInit();
            this.gradesSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tab_grades;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox registration_semester_list;
        private Label registration_instructions;
        private Button view_courses_button;
        private TableLayoutPanel courses_table;
        private Label course_title_header_table;
        private ListBox semester_list_seaon;
        private DataGridView data_grid_view_courses;
        private Button get_courses_button;
        private ListBox semester_list_year;
        private DataGridViewTextBoxColumn course_title;
        private DataGridViewTextBoxColumn course_num;
        private DataGridViewTextBoxColumn instructor_full_name;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn pre_reqs;
        private DataGridViewTextBoxColumn coReqs;
        private ComboBox dropdownSemesters;
        private SplitContainer gradesSplit;
        private DataGridView gradeView;
        private Label gradeViewLabel;
        private Label endLabel;
        private Label startLabel;
        private ComboBox endSemList;
        private ComboBox startSemList;
        private Label transcriptLabel;
        private Button transcriptButton;
        private SaveFileDialog saveFileDialog;
    }
}