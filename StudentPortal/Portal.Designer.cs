namespace StudentPortal
{
    partial class Portal
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.portal_title = new System.Windows.Forms.Label();
            this.instructorButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(146, 202);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(120, 29);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Student Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.StudentLogInButton_Clicked);
            // 
            // portal_title
            // 
            this.portal_title.AutoSize = true;
            this.portal_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portal_title.Location = new System.Drawing.Point(323, 132);
            this.portal_title.Name = "portal_title";
            this.portal_title.Size = new System.Drawing.Size(154, 25);
            this.portal_title.TabIndex = 2;
            this.portal_title.Text = "University Portal";
            // 
            // instructorButton
            // 
            this.instructorButton.Location = new System.Drawing.Point(333, 202);
            this.instructorButton.Name = "instructorButton";
            this.instructorButton.Size = new System.Drawing.Size(134, 29);
            this.instructorButton.TabIndex = 3;
            this.instructorButton.Text = "Instructor Log In";
            this.instructorButton.UseVisualStyleBackColor = true;
            this.instructorButton.Click += new System.EventHandler(this.InstLogInButton_Clicked);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(535, 202);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(157, 29);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "Administrator Log In";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.AdminLogInButton_Clicked);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.instructorButton);
            this.Controls.Add(this.portal_title);
            this.Controls.Add(this.LogInButton);
            this.Name = "Portal";
            this.Text = "University Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LogInButton;
        private Label portal_title;
        private Button instructorButton;
        private Button adminButton;
    }
}