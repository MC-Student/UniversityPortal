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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.instPortalTabs.SuspendLayout();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Sections";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl instPortalTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}