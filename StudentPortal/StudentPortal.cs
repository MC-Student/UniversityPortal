using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Microsoft.VisualBasic.ApplicationServices;

namespace StudentPortal
{
    public partial class StudentPortal : Form
    {
        private SqlConnection sqlCon;
        private DataSet dataSet;
        private String user;
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            if (CreateConnection())
            {
                dataSet = new DataSet();
                MessageBox.Show("Connected to university database");
            }
        }

        private Boolean CreateConnection()
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

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LoginPage lg = new LoginPage(ref user);
//            lg.Name = "Student Log In";
            lg.Show();
            //DialogResult result = lg.ShowDialog();

            /*if (result == DialogResult.OK)
            { 
            }
            else {lg.Close(); }*/

        }
    }
}