namespace StudentPortal
{
    partial class LoginPage
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
            this.un_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.un_input = new System.Windows.Forms.TextBox();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // un_label
            // 
            this.un_label.AutoSize = true;
            this.un_label.Location = new System.Drawing.Point(126, 67);
            this.un_label.Name = "un_label";
            this.un_label.Size = new System.Drawing.Size(75, 20);
            this.un_label.TabIndex = 0;
            this.un_label.Text = "Username";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(131, 111);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(70, 20);
            this.pw_label.TabIndex = 1;
            this.pw_label.Text = "Password";
            // 
            // un_input
            // 
            this.un_input.Location = new System.Drawing.Point(250, 67);
            this.un_input.Name = "un_input";
            this.un_input.Size = new System.Drawing.Size(125, 27);
            this.un_input.TabIndex = 2;
            // 
            // pw_input
            // 
            this.pw_input.Location = new System.Drawing.Point(250, 111);
            this.pw_input.Name = "pw_input";
            this.pw_input.PasswordChar = '●';
            this.pw_input.Size = new System.Drawing.Size(125, 27);
            this.pw_input.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(250, 175);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(70, 29);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.click_ok);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(348, 175);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(72, 29);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.click_cancel);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 275);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.un_input);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.un_label);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label un_label;
        private Label pw_label;
        private TextBox un_input;
        private TextBox pw_input;
        private Button login_button;
        private Button cancel_button;
    }
}