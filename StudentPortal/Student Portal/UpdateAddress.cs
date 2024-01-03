using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace StudentPortal
{
    public partial class UpdateAddress : Form
    {
        private string Username;
        private SqlConnection sqlCon;
        public UpdateAddress(string User)
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

        private void OKClick(object sender, EventArgs e)
        {
            string address = newAddress.Text;
            UpdateStudentAddress(address);
            this.Close();
        }

        private void UpdateStudentAddress(string updated)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_UpdateAddress", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;
            sqlCmd.Parameters.Add("@address", SqlDbType.VarChar).Value = updated;
            sqlCmd.ExecuteNonQuery();
        }
    }
}
