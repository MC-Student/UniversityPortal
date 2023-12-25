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
            tab_grades = new TabControl();
            tabPage1 = new TabPage();
            honorsCheck = new CheckBox();
            honorInput = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            addressInput = new Label();
            statusInput = new Label();
            minorInput = new Label();
            numberInput = new Label();
            DOBInput = new Label();
            emailInput = new Label();
            majorInput = new Label();
            studentNameInput = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dropdownSemesters = new ComboBox();
            tab_grades.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();

            this.tab_grades = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dropdownSemesters = new System.Windows.Forms.ComboBox();
            this.tab_grades.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_grades
            // 
            tab_grades.Controls.Add(tabPage1);
            tab_grades.Controls.Add(tabPage2);
            tab_grades.Controls.Add(tabPage3);
            tab_grades.Location = new Point(10, 9);
            tab_grades.Margin = new Padding(3, 2, 3, 2);
            tab_grades.Name = "tab_grades";
            tab_grades.SelectedIndex = 0;
            tab_grades.Size = new Size(679, 320);
            tab_grades.TabIndex = 0;
            tab_grades.Selected += InfoTabLoadSelected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(honorsCheck);
            tabPage1.Controls.Add(honorInput);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(addressInput);
            tabPage1.Controls.Add(statusInput);
            tabPage1.Controls.Add(minorInput);
            tabPage1.Controls.Add(numberInput);
            tabPage1.Controls.Add(DOBInput);
            tabPage1.Controls.Add(emailInput);
            tabPage1.Controls.Add(majorInput);
            tabPage1.Controls.Add(studentNameInput);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(671, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "My Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // honorsCheck
            // 
            honorsCheck.AutoSize = true;
            honorsCheck.Location = new Point(176, 250);
            honorsCheck.Name = "honorsCheck";
            honorsCheck.Size = new Size(15, 14);
            honorsCheck.TabIndex = 29;
            honorsCheck.UseVisualStyleBackColor = true;
            // 
            // honorInput
            // 
            honorInput.AutoSize = true;
            honorInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            honorInput.Location = new Point(24, 246);
            honorInput.Name = "honorInput";
            honorInput.Size = new Size(118, 21);
            honorInput.TabIndex = 28;
            honorInput.Text = "Honors Student";
            // 
            // button4
            // 
            button4.Location = new Point(478, 184);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 27;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(478, 244);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(176, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 25;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(176, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // addressInput
            // 
            addressInput.AutoSize = true;
            addressInput.BackColor = Color.Transparent;
            addressInput.BorderStyle = BorderStyle.FixedSingle;
            addressInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressInput.Location = new Point(368, 244);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(2, 23);
            addressInput.TabIndex = 23;
            // 
            // statusInput
            // 
            statusInput.AutoSize = true;
            statusInput.BackColor = Color.Transparent;
            statusInput.BorderStyle = BorderStyle.FixedSingle;
            statusInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusInput.Location = new Point(33, 204);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(2, 23);
            statusInput.TabIndex = 22;
            // 
            // minorInput
            // 
            minorInput.AutoSize = true;
            minorInput.BackColor = Color.Transparent;
            minorInput.BorderStyle = BorderStyle.FixedSingle;
            minorInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minorInput.Location = new Point(33, 138);
            minorInput.Name = "minorInput";
            minorInput.Size = new Size(2, 23);
            minorInput.TabIndex = 21;
            // 
            // numberInput
            // 
            numberInput.AutoSize = true;
            numberInput.BackColor = Color.Transparent;
            numberInput.BorderStyle = BorderStyle.FixedSingle;
            numberInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberInput.Location = new Point(368, 184);
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(2, 23);
            numberInput.TabIndex = 20;
            // 
            // DOBInput
            // 
            DOBInput.AutoSize = true;
            DOBInput.BackColor = Color.Transparent;
            DOBInput.BorderStyle = BorderStyle.FixedSingle;
            DOBInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBInput.Location = new Point(368, 42);
            DOBInput.Name = "DOBInput";
            DOBInput.Size = new Size(2, 23);
            DOBInput.TabIndex = 19;
            // 
            // emailInput
            // 
            emailInput.AutoSize = true;
            emailInput.BackColor = Color.Transparent;
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(368, 118);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(2, 23);
            emailInput.TabIndex = 18;
            // 
            // majorInput
            // 
            majorInput.AutoSize = true;
            majorInput.BackColor = Color.Transparent;
            majorInput.BorderStyle = BorderStyle.FixedSingle;
            majorInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            majorInput.Location = new Point(33, 78);
            majorInput.Name = "majorInput";
            majorInput.Size = new Size(2, 23);
            majorInput.TabIndex = 17;
            // 
            // studentNameInput
            // 
            studentNameInput.AutoSize = true;
            studentNameInput.BackColor = Color.Transparent;
            studentNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentNameInput.Location = new Point(33, 23);
            studentNameInput.Name = "studentNameInput";
            studentNameInput.Size = new Size(0, 21);
            studentNameInput.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(357, 207);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 11;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(357, 151);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 10;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(357, 77);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 9;
            label6.Text = "School Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(357, 18);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 8;
            label5.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 183);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 6;
            label4.Text = "Student Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 4;
            label3.Text = "Declared Minor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Declared Major";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 2);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(671, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dropdownSemesters);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(671, 292);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "My Grades";
            tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.dropdownSemesters);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(532, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // dropdownSemesters
            // 
            dropdownSemesters.FormattingEnabled = true;
            dropdownSemesters.Items.AddRange(new object[] { "Fall 2021", "Spring 2021", "Fall 2020", "Spring 2020" });
            dropdownSemesters.Location = new Point(535, 4);
            dropdownSemesters.Margin = new Padding(3, 2, 3, 2);
            dropdownSemesters.MaxDropDownItems = 4;
            dropdownSemesters.Name = "dropdownSemesters";
            dropdownSemesters.Size = new Size(133, 23);
            dropdownSemesters.TabIndex = 0;
            dropdownSemesters.Text = "choose semester";
            // 
            // LoggedInPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tab_grades);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoggedInPortal";
            Text = "LoggedInPortal";
            tab_grades.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            this.dropdownSemesters.FormattingEnabled = true;
            this.dropdownSemesters.Items.AddRange(new object[] {
            "Fall 2021",
            "Spring 2021",
            "Fall 2020",
            "Spring 2020"});
            this.dropdownSemesters.Location = new System.Drawing.Point(611, 6);
            this.dropdownSemesters.MaxDropDownItems = 4;
            this.dropdownSemesters.Name = "dropdownSemesters";
            this.dropdownSemesters.Size = new System.Drawing.Size(151, 28);
            this.dropdownSemesters.TabIndex = 0;
            this.dropdownSemesters.Text = "choose semester";
            this.dropdownSemesters.SelectedValueChanged += new System.EventHandler(this.SemesterSelected);
            // 
            // LoggedInPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_grades);
            this.Name = "LoggedInPortal";
            this.Text = "LoggedInPortal";
            this.tab_grades.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tab_grades;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox dropdownSemesters;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label studentNameInput;
        private Label statusInput;
        private Label minorInput;
        private Label numberInput;
        private Label DOBInput;
        private Label emailInput;
        private Label majorInput;
        private Label addressInput;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox honorsCheck;
        private Label honorInput;
        private DataGridView dataGridView1;
    }
}