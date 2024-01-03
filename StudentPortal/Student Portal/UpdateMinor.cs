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
    public partial class UpdateMinor : Form
    {
        private string Username;
        private SqlConnection sqlCon;
        public UpdateMinor(string user)
        {
            this.Username = user;
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


        private void OKButtonClicked(object sender, EventArgs e)
        {
            string minor = comboBoxMinors.Text;
            UpdateStudentMinor(minor);
            this.Close();
        }

        private void UpdateStudentMinor(string minor)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_UpdateMinor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;
            sqlCmd.Parameters.Add("@minor", SqlDbType.VarChar).Value = minor;
            sqlCmd.ExecuteNonQuery();
        }

        private void UpdateMinorLoad(object sender, EventArgs e)
        {
            DisplayMinors();
        }
        private void DisplayMinors()
        {
            SqlCommand sqlCmd = new SqlCommand("spGetMinorList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            DataTable List = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(List);

            foreach (DataRow Row in List.Rows)
            {
                comboBoxMinors.Items.Add(Row.ItemArray.GetValue(0).ToString());
            }
        }
    }
}
