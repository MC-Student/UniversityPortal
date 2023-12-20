using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using System.Text;
using System.Security.Cryptography;

namespace StudentPortal
{
    public partial class StudentPortal : Form
    {
        private SqlConnection sqlCon;
        private String user;
        public StudentPortal()
        {
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

        private void LogInButton_Click(object sender, EventArgs e)
        {
            using (LoginPage child = new LoginPage())
            {
                child.ShowDialog(this);
            }
        }

        public void SetUser(string s)
        {
            user = s;
            if (!s.Equals("")) 
            {
                MessageBox.Show("Welcome, " + user);
                LoggedInPortal portal = new LoggedInPortal(user);
                portal.ShowDialog();
            }
        }
    }
}