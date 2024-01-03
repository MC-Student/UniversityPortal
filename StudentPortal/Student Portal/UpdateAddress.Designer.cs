namespace StudentPortal
{
    partial class UpdateAddress
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
            updateLabel = new Label();
            newAddress = new TextBox();
            updateButton1 = new Button();
            SuspendLayout();
            // 
            // updateLabel
            // 
            updateLabel.AutoSize = true;
            updateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateLabel.Location = new Point(73, 47);
            updateLabel.Name = "updateLabel";
            updateLabel.Size = new Size(214, 21);
            updateLabel.TabIndex = 0;
            updateLabel.Text = "Enter New Address to Update";
            // 
            // newAddress
            // 
            newAddress.Location = new Point(73, 109);
            newAddress.Name = "newAddress";
            newAddress.Size = new Size(214, 23);
            newAddress.TabIndex = 1;
            // 
            // updateButton1
            // 
            updateButton1.Location = new Point(141, 167);
            updateButton1.Name = "updateButton1";
            updateButton1.Size = new Size(75, 23);
            updateButton1.TabIndex = 2;
            updateButton1.Text = "OK";
            updateButton1.UseVisualStyleBackColor = true;
            updateButton1.Click += OKClick;
            // 
            // UpdateAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 223);
            Controls.Add(updateButton1);
            Controls.Add(newAddress);
            Controls.Add(updateLabel);
            Name = "UpdateAddress";
            Text = "UpdateAddress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label updateLabel;
        private TextBox newAddress;
        private Button updateButton1;
    }
}