namespace StudentPortal
{
    partial class UpdateMajor
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
            comboBoxMajors = new ComboBox();
            majorUpdateLabel = new Label();
            OKButton = new Button();
            SuspendLayout();
            // 
            // comboBoxMajors
            // 
            comboBoxMajors.FormattingEnabled = true;
            comboBoxMajors.Location = new Point(82, 70);
            comboBoxMajors.Name = "comboBoxMajors";
            comboBoxMajors.Size = new Size(121, 23);
            comboBoxMajors.TabIndex = 0;
            // 
            // majorUpdateLabel
            // 
            majorUpdateLabel.AutoSize = true;
            majorUpdateLabel.Location = new Point(12, 34);
            majorUpdateLabel.Name = "majorUpdateLabel";
            majorUpdateLabel.Size = new Size(81, 15);
            majorUpdateLabel.TabIndex = 1;
            majorUpdateLabel.Text = "Choose major";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(104, 130);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OkButtonClick;
            // 
            // UpdateMajor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 190);
            Controls.Add(OKButton);
            Controls.Add(majorUpdateLabel);
            Controls.Add(comboBoxMajors);
            Name = "UpdateMajor";
            Text = "UpdateMajor";
            Load += UpdateMajorLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMajors;
        private Label majorUpdateLabel;
        private Button OKButton;
    }
}