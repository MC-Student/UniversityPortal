namespace StudentPortal
{
    partial class StudentPortal
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
            this.PortalTitle = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortalTitle
            // 
            this.PortalTitle.Location = new System.Drawing.Point(297, 131);
            this.PortalTitle.Name = "PortalTitle";
            this.PortalTitle.ReadOnly = true;
            this.PortalTitle.Size = new System.Drawing.Size(173, 27);
            this.PortalTitle.TabIndex = 0;
            this.PortalTitle.Text = "University Student Portal";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(338, 177);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(94, 29);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PortalTitle);
            this.Name = "StudentPortal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PortalTitle;
        private Button LogInButton;
    }
}