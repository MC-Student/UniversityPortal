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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentPortal
{
    public partial class UpdateMajor : Form
    {
        private String Username;
        private SqlConnection sqlCon;
        public UpdateMajor(String user)
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
        private void OkButtonClick(object sender, EventArgs e)
        {
            String major = comboBoxMajors.Text;
            UpdateStudentMajor(major);
            this.Close();
        }

        private void UpdateStudentMajor(string major)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_UpdateMajor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;
            sqlCmd.Parameters.Add("@major", SqlDbType.VarChar).Value = major;
            sqlCmd.ExecuteNonQuery();
        }

        private void UpdateMajorLoad(object sender, EventArgs e)
        {
            DisplayMajors();
        }

        private void DisplayMajors()
        {
            SqlCommand sqlCmd = new SqlCommand("spGetMajorList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            DataTable List = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(List);

            foreach (DataRow Row in List.Rows)
            {
                comboBoxMajors.Items.Add(Row.ItemArray.GetValue(0).ToString());
            }
        }
    }
}
