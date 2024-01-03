namespace StudentPortal
{
    partial class UpdateMinor
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
            majorUpdateLabel = new Label();
            comboBoxMinors = new ComboBox();
            OKButton = new Button();
            SuspendLayout();
            // 
            // majorUpdateLabel
            // 
            majorUpdateLabel.AutoSize = true;
            majorUpdateLabel.Location = new Point(24, 41);
            majorUpdateLabel.Name = "majorUpdateLabel";
            majorUpdateLabel.Size = new Size(82, 15);
            majorUpdateLabel.TabIndex = 2;
            majorUpdateLabel.Text = "Choose minor";
            // 
            // comboBoxMinors
            // 
            comboBoxMinors.FormattingEnabled = true;
            comboBoxMinors.Location = new Point(100, 81);
            comboBoxMinors.Name = "comboBoxMinors";
            comboBoxMinors.Size = new Size(121, 23);
            comboBoxMinors.TabIndex = 3;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(126, 151);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 4;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButtonClicked;
            // 
            // UpdateMinor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 195);
            Controls.Add(OKButton);
            Controls.Add(comboBoxMinors);
            Controls.Add(majorUpdateLabel);
            Name = "UpdateMinor";
            Text = "UpdateMinor";
            Load += UpdateMinorLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label majorUpdateLabel;
        private ComboBox comboBoxMinors;
        private Button OKButton;
    }
}