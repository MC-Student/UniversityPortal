using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentPortal
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void click_cancel(object sender, EventArgs e)
        {
            StudentPortal parent = (StudentPortal)this.Owner;
            parent.SetUser("");
            this.Close();
        }

        private void click_ok(object sender, EventArgs e)
        {
            if (un_input.Text.Length > 2 && pw_input.Text.Length > 7)
            {
                String text = un_input.Text;
                StudentPortal parent = (StudentPortal)this.Owner;
                parent.SetUser(text);
                this.Close();
            }
            else if (un_input.Text.Length < 3 && pw_input.Text.Length < 8) 
            {
                MessageBox.Show("Invalid username and password: fix input length");
            }
            else if (un_input.Text.Length < 3)
            {
                MessageBox.Show("Invalid username: must enter at least 3 characters");
            }
            else
            {
                MessageBox.Show("Invalid password: must enter at least 8 characters");
            }
        }
    }
}
