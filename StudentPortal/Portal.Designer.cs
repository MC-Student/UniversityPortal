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
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(338, 177);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(120, 29);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Student Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
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
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}