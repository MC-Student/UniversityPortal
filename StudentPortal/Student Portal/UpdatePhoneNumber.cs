using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class UpdatePhoneNumber : Form
    {
        private string Username;
        private SqlConnection sqlCon;
        public UpdatePhoneNumber(string User)
        {
            this.Username = User;
            InitializeComponent();
            CreateConnection();
        }
        private void CreateConnection()
        {
            try
            {
                string strServer = Environment.GetEnvironmentVariable("SQL_Server_Name", EnvironmentVariableTarget.User);
                string strDatabase = Environment.GetEnvironmentVariable("University_DB_Name", EnvironmentVariableTarget.User);

                string strConnect = $"Server={strServer};Database={strDatabase};Trusted_Connection=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + "  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            string phone = newPhone.Text;
            UpdateStudentPhone(phone);
            this.Close();

        }

        private void UpdateStudentPhone(string phone)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_UpdatePhoneNumber", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;
            sqlCmd.Parameters.Add("@phonenumber", SqlDbType.VarChar).Value = phone;
            sqlCmd.ExecuteNonQuery();
        }
    }
}
