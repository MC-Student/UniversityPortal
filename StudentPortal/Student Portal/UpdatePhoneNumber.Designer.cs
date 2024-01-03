namespace StudentPortal
{
    partial class UpdatePhoneNumber
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
            updatePhoneLabel = new Label();
            newPhone = new TextBox();
            updateButton1 = new Button();
            SuspendLayout();
            // 
            // updatePhoneLabel
            // 
            updatePhoneLabel.AutoSize = true;
            updatePhoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updatePhoneLabel.Location = new Point(57, 37);
            updatePhoneLabel.Name = "updatePhoneLabel";
            updatePhoneLabel.Size = new Size(264, 21);
            updatePhoneLabel.TabIndex = 1;
            updatePhoneLabel.Text = "Enter New Phone Number to Update";
            // 
            // newPhone
            // 
            newPhone.Location = new Point(76, 88);
            newPhone.Name = "newPhone";
            newPhone.Size = new Size(214, 23);
            newPhone.TabIndex = 2;
            // 
            // updateButton1
            // 
            updateButton1.Location = new Point(138, 147);
            updateButton1.Name = "updateButton1";
            updateButton1.Size = new Size(75, 23);
            updateButton1.TabIndex = 3;
            updateButton1.Text = "OK";
            updateButton1.UseVisualStyleBackColor = true;
            updateButton1.Click += OkButtonClick;
            // 
            // UpdatePhoneNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 199);
            Controls.Add(updateButton1);
            Controls.Add(newPhone);
            Controls.Add(updatePhoneLabel);
            Name = "UpdatePhoneNumber";
            Text = "UpdatePhoneNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label updatePhoneLabel;
        private TextBox newPhone;
        private Button updateButton1;
    }
}