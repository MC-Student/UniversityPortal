namespace UniversityPortal.Instructor_Portal
{
    partial class LoggedInInstructorPortal
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
            this.instPortalTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dropdownSemesters = new System.Windows.Forms.ComboBox();
            this.allSectionsView = new System.Windows.Forms.DataGridView();
            this.section_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_num_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inst_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prereq_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coreq_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.semesterDropdown = new System.Windows.Forms.ComboBox();
            this.studentInstView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instPortalTabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSectionsView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInstView)).BeginInit();
            this.SuspendLayout();
            // 
            // instPortalTabs
            // 
            this.instPortalTabs.Controls.Add(this.tabPage1);
            this.instPortalTabs.Controls.Add(this.tabPage2);
            this.instPortalTabs.Controls.Add(this.tabPage3);
            this.instPortalTabs.Controls.Add(this.tabPage4);
            this.instPortalTabs.Controls.Add(this.tabPage5);
            this.instPortalTabs.Location = new System.Drawing.Point(5, 14);
            this.instPortalTabs.Name = "instPortalTabs";
            this.instPortalTabs.SelectedIndex = 0;
            this.instPortalTabs.Size = new System.Drawing.Size(790, 422);
            this.instPortalTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dropdownSemesters);
            this.tabPage2.Controls.Add(this.allSectionsView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Sections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dropdownSemesters
            // 
            this.dropdownSemesters.FormattingEnabled = true;
            this.dropdownSemesters.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.dropdownSemesters.Location = new System.Drawing.Point(616, 14);
            this.dropdownSemesters.MaxDropDownItems = 4;
            this.dropdownSemesters.Name = "dropdownSemesters";
            this.dropdownSemesters.Size = new System.Drawing.Size(151, 28);
            this.dropdownSemesters.TabIndex = 1;
            this.dropdownSemesters.Text = "choose semester";
            this.dropdownSemesters.SelectedValueChanged += new System.EventHandler(this.SemesterSelected);
            // 
            // allSectionsView
            // 
            this.allSectionsView.AllowUserToAddRows = false;
            this.allSectionsView.AllowUserToDeleteRows = false;
            this.allSectionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allSectionsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.section_name_col,
            this.section_num_col,
            this.inst_col,
            this.day_col,
            this.time_col,
            this.prereq_col,
            this.coreq_col,
            this.reg_col});
            this.allSectionsView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allSectionsView.Location = new System.Drawing.Point(3, 64);
            this.allSectionsView.Name = "allSectionsView";
            this.allSectionsView.ReadOnly = true;
            this.allSectionsView.RowHeadersVisible = false;
            this.allSectionsView.RowHeadersWidth = 51;
            this.allSectionsView.RowTemplate.Height = 29;
            this.allSectionsView.Size = new System.Drawing.Size(776, 322);
            this.allSectionsView.TabIndex = 0;
            // 
            // section_name_col
            // 
            this.section_name_col.HeaderText = "Section Name";
            this.section_name_col.MinimumWidth = 6;
            this.section_name_col.Name = "section_name_col";
            this.section_name_col.ReadOnly = true;
            this.section_name_col.Width = 125;
            // 
            // section_num_col
            // 
            this.section_num_col.HeaderText = "Section Code";
            this.section_num_col.MinimumWidth = 6;
            this.section_num_col.Name = "section_num_col";
            this.section_num_col.ReadOnly = true;
            this.section_num_col.Width = 125;
            // 
            // inst_col
            // 
            this.inst_col.HeaderText = "Instructor Name";
            this.inst_col.MinimumWidth = 6;
            this.inst_col.Name = "inst_col";
            this.inst_col.ReadOnly = true;
            this.inst_col.Width = 125;
            // 
            // day_col
            // 
            this.day_col.HeaderText = "Day";
            this.day_col.MinimumWidth = 6;
            this.day_col.Name = "day_col";
            this.day_col.ReadOnly = true;
            this.day_col.Width = 125;
            // 
            // time_col
            // 
            this.time_col.HeaderText = "Time Slot";
            this.time_col.MinimumWidth = 6;
            this.time_col.Name = "time_col";
            this.time_col.ReadOnly = true;
            this.time_col.Width = 125;
            // 
            // prereq_col
            // 
            this.prereq_col.HeaderText = "Prerequisites";
            this.prereq_col.MinimumWidth = 6;
            this.prereq_col.Name = "prereq_col";
            this.prereq_col.ReadOnly = true;
            this.prereq_col.Width = 125;
            // 
            // coreq_col
            // 
            this.coreq_col.HeaderText = "Corequisites";
            this.coreq_col.MinimumWidth = 6;
            this.coreq_col.Name = "coreq_col";
            this.coreq_col.ReadOnly = true;
            this.coreq_col.Width = 125;
            // 
            // reg_col
            // 
            this.reg_col.HeaderText = "# Registered";
            this.reg_col.MinimumWidth = 6;
            this.reg_col.Name = "reg_col";
            this.reg_col.ReadOnly = true;
            this.reg_col.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.semesterDropdown);
            this.tabPage3.Controls.Add(this.studentInstView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(782, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Students";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // semesterDropdown
            // 
            this.semesterDropdown.FormattingEnabled = true;
            this.semesterDropdown.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.semesterDropdown.Location = new System.Drawing.Point(614, 23);
            this.semesterDropdown.MaxDropDownItems = 4;
            this.semesterDropdown.Name = "semesterDropdown";
            this.semesterDropdown.Size = new System.Drawing.Size(151, 28);
            this.semesterDropdown.TabIndex = 2;
            this.semesterDropdown.Text = "choose semester";
            this.semesterDropdown.SelectedValueChanged += new System.EventHandler(this.SemesterOfStudentsSelected);
            // 
            // studentInstView
            // 
            this.studentInstView.AllowUserToAddRows = false;
            this.studentInstView.AllowUserToDeleteRows = false;
            this.studentInstView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInstView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.studentInstView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentInstView.Location = new System.Drawing.Point(0, 67);
            this.studentInstView.Name = "studentInstView";
            this.studentInstView.ReadOnly = true;
            this.studentInstView.RowHeadersVisible = false;
            this.studentInstView.RowHeadersWidth = 51;
            this.studentInstView.RowTemplate.Height = 29;
            this.studentInstView.Size = new System.Drawing.Size(782, 322);
            this.studentInstView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(782, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "My Schedule";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(782, 389);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Instruction History";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Major";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Minor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Honors";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Year Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Section Title";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // LoggedInInstructorPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instPortalTabs);
            this.Name = "LoggedInInstructorPortal";
            this.Text = "My Instructor Portal";
            this.instPortalTabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allSectionsView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentInstView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl instPortalTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView allSectionsView;
        private ComboBox dropdownSemesters;
        private DataGridViewTextBoxColumn section_name_col;
        private DataGridViewTextBoxColumn section_num_col;
        private DataGridViewTextBoxColumn inst_col;
        private DataGridViewTextBoxColumn day_col;
        private DataGridViewTextBoxColumn time_col;
        private DataGridViewTextBoxColumn prereq_col;
        private DataGridViewTextBoxColumn coreq_col;
        private DataGridViewTextBoxColumn reg_col;
        private DataGridView studentInstView;
        private ComboBox semesterDropdown;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}