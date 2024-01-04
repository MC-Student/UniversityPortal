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
using UniversityPortal.Instructor_Portal;
using UniversityPortal.Administrator_Portal;

namespace StudentPortal
{
    public partial class Portal : Form
    {
        private SqlConnection sqlCon;
        private string user;
        private int login_type;
        private readonly int STUDENT_LOGIN_TYPE = 1;
        private readonly int INST_LOGIN_TYPE = 2;
        private readonly int ADMIN_LOGIN_TYPE = 3;
        public Portal()
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

        private void StudentLogInButton_Clicked(object sender, EventArgs e)
        {
            using (StudentLoginPage child = new StudentLoginPage())
            {
                child.ShowDialog(this);
            }
        }

        private void InstLogInButton_Clicked(object sender, EventArgs e)
        {
            using (InstructorLoginPage child = new InstructorLoginPage())
            {
                child.ShowDialog(this);
            }
        }

        private void AdminLogInButton_Clicked(object sender, EventArgs e)
        {
            using (AdminLoginPage child = new AdminLoginPage()) 
            {
                child.ShowDialog(this);
            }
        }

        public void SetUser(string s, int t)
        {
            user = s;
            login_type = t;

            if (!s.Equals("")) 
            {
                MessageBox.Show("Welcome, " + user);

                if (t == STUDENT_LOGIN_TYPE)
                {
                    LoggedInStudentPortal studentPortal = new LoggedInStudentPortal(user);
                    studentPortal.ShowDialog();
                }
                else if (t == INST_LOGIN_TYPE)
                {
                    LoggedInInstructorPortal instructorPortal = new LoggedInInstructorPortal(user);
                    instructorPortal.ShowDialog();
                }
                else if (t == ADMIN_LOGIN_TYPE) 
                {
                    LoggedInAdminPortal adminPortal = new LoggedInAdminPortal(user);
                    adminPortal.ShowDialog();
                }
            }
        }
    }
}