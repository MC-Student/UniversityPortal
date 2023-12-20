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
            register_button = new Button();
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
            Add_or_drop = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            semester_list_year = new ListBox();
            tab_grades.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid_view_courses).BeginInit();
            SuspendLayout();
            // 
            // tab_grades
            // 
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
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(semester_list_year);
            tabPage2.Controls.Add(register_button);
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
            // register_button
            // 
            register_button.Location = new Point(583, 65);
            register_button.Name = "register_button";
            register_button.Size = new Size(156, 34);
            register_button.TabIndex = 3;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = true;
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
            data_grid_view_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_view_courses.Columns.AddRange(new DataGridViewColumn[] { course_title, course_num, instructor_full_name, day, start_time, end_time, pre_reqs, coReqs, Add_or_drop });
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
            course_title.Width = 150;
            // 
            // course_num
            // 
            course_num.HeaderText = "Course Number";
            course_num.MinimumWidth = 8;
            course_num.Name = "course_num";
            course_num.ReadOnly = true;
            course_num.Width = 150;
            // 
            // instructor_full_name
            // 
            instructor_full_name.HeaderText = "Instructor Name";
            instructor_full_name.MinimumWidth = 8;
            instructor_full_name.Name = "instructor_full_name";
            instructor_full_name.ReadOnly = true;
            instructor_full_name.Width = 150;
            // 
            // day
            // 
            day.HeaderText = "Day";
            day.MinimumWidth = 8;
            day.Name = "day";
            day.ReadOnly = true;
            day.Width = 150;
            // 
            // start_time
            // 
            start_time.HeaderText = "Start Time";
            start_time.MinimumWidth = 8;
            start_time.Name = "start_time";
            start_time.ReadOnly = true;
            start_time.Width = 150;
            // 
            // end_time
            // 
            end_time.HeaderText = "End Time";
            end_time.MinimumWidth = 8;
            end_time.Name = "end_time";
            end_time.ReadOnly = true;
            end_time.Width = 150;
            // 
            // pre_reqs
            // 
            pre_reqs.HeaderText = "PreReqs";
            pre_reqs.MinimumWidth = 8;
            pre_reqs.Name = "pre_reqs";
            pre_reqs.ReadOnly = true;
            pre_reqs.Width = 150;
            // 
            // coReqs
            // 
            coReqs.HeaderText = "CoReqs";
            coReqs.MinimumWidth = 8;
            coReqs.Name = "coReqs";
            coReqs.ReadOnly = true;
            coReqs.Width = 150;
            // 
            // Add_or_drop
            // 
            Add_or_drop.HeaderText = "Add / Drop";
            Add_or_drop.MinimumWidth = 8;
            Add_or_drop.Name = "Add_or_drop";
            Add_or_drop.Width = 150;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1204, 627);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "My Grades";
            tabPage3.UseVisualStyleBackColor = true;
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
        private DataGridViewTextBoxColumn course_title;
        private DataGridViewTextBoxColumn course_num;
        private DataGridViewTextBoxColumn instructor_full_name;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn pre_reqs;
        private DataGridViewTextBoxColumn coReqs;
        private DataGridViewTextBoxColumn Add_or_drop;
        private Button register_button;
        private ListBox semester_list_year;
    }
}