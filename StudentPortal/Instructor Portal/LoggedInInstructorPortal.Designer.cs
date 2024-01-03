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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.instPortalTabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSectionsView)).BeginInit();
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
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(782, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Students";
            this.tabPage3.UseVisualStyleBackColor = true;
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
    }
}