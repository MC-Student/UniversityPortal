using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace StudentPortal
{
    public partial class StudentLoginPage : Form
    {
        private SqlConnection sqlCon;
        public StudentLoginPage()
        {
            InitializeComponent();
        }

        private bool CreateConnection()
        {
            try
            {
                string strServer = Environment.GetEnvironmentVariable("SQL_Server_Name", EnvironmentVariableTarget.User);
                string strDatabase = Environment.GetEnvironmentVariable("University_DB_Name", EnvironmentVariableTarget.User);

                string strConnect = $"Server={strServer};Database={strDatabase};Trusted_Connection=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + "  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void click_cancel(object sender, EventArgs e)
        {
            Portal parent = (Portal)this.Owner;
            parent.SetUser("");
            this.Close();
        }

        private void click_ok(object sender, EventArgs e)
        {
            if (un_input.Text.Length > 2 && pw_input.Text.Length > 7)
            {
                string text = un_input.Text;
                Portal parent = (Portal)this.Owner;

                if (ValidatePassword(text))
                {
                    parent.SetUser(text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                    un_input.Clear();
                    pw_input.Clear();
                }
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

        private bool ValidatePassword(string user)
        {
            string encryptedInput = encryptInputPassword(pw_input.Text);
            string actualUserPassword = getStoredPassword(user);
            if (actualUserPassword != null && encryptedInput != null)
            {
                if (actualUserPassword.Equals(encryptedInput))
                {
                    return true;
                }
            }
            else if (encryptedInput == null) 
            {
                MessageBox.Show("Database connection failed");
            }
            else if (actualUserPassword == null)
            {
                MessageBox.Show("Username incorrect");
            }
            return false;
        }

        private string encryptInputPassword(string password) 
        {
            if (CreateConnection())
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT dbo.encryptPw2(@Pw_chars)", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.Add("@Pw_chars", SqlDbType.VarChar).Value = password;
                SqlParameter code1 = new SqlParameter("@code", SqlDbType.Int);
                string encrypted = sqlCmd.ExecuteScalar() as string;
                return encrypted;
            }
          
            return null;
        }
        private string getStoredPassword(string user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetEncryptedUserPw", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@password", SqlDbType.VarChar, int.MaxValue);
            sqlCmd.Parameters["@password"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            string password = sqlCmd.Parameters["@password"].Value.ToString();
            return password;
        }
    }
}
