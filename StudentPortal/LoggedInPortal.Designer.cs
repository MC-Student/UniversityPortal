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
            this.studentPortalTabs.Location = new System.Drawing.Point(12, 12);
            this.studentPortalTabs.Name = "studentPortalTabs";
            this.studentPortalTabs.SelectedIndex = 0;
            this.studentPortalTabs.Size = new System.Drawing.Size(776, 426);
            this.studentPortalTabs.TabIndex = 0;
            this.studentPortalTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.InfoTabLoadSelected);
            // 
            // tabPage1
            // 
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gradesTabSplit);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
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
            this.gradesTabSplit.Size = new System.Drawing.Size(762, 387);
            this.gradesTabSplit.SplitterDistance = 253;
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
            this.Controls.Add(this.studentPortalTabs);
            this.Name = "LoggedInPortal";
            this.Text = "LoggedInPortal";
            this.studentPortalTabs.ResumeLayout(false);
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
    }
}