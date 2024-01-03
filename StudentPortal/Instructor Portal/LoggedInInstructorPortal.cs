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

namespace UniversityPortal.Instructor_Portal
{
    public partial class LoggedInInstructorPortal : Form
    {
        private string username;
        private SqlConnection sqlCon;
        public LoggedInInstructorPortal(string user)
        {
            InitializeComponent();
            this.username = user;
            CreateConnection();
            PopulateInstructorInformation(username);
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

        private void PopulateInstructorInformation(string username)
        {
            /*studentNameInput.Text = GetStudentName(username);
            studentNameInput.BorderStyle = BorderStyle.FixedSingle;
            string major = GetStudentMajor(username);
            if (major == "")
            {
                majorInput.Text = "Undeclared";
            }
            else
            {
                majorInput.Text = major;
            }
            string minor = GetStudentMinor(username);
            if (minor == "")
            {
                minorInput.Text = "Undeclared";
            }
            else
            {
                minorInput.Text = minor;
            }
            DOBInput.Text = GetStudentDOB(username);
            string status = GetStudentHonorStatus(username);
            if (status == "1")
            {
                honorsCheck.Checked = true;
            }
            else
            {
                honorsCheck.Checked = false;
            }
            string email = GetStudentEmail(username);
            emailInput.Text = email + "@student.edu";
            statusInput.Text = GetStudentYearStatus(username);

            string address = GetStudentAddress(username);
            if (address == "")
            {
                addressInput.Text = "N/A";
            }
            else
            {
                addressInput.Text = address;
            }

            string number = GetStudentPhone(username);
            if (number == "")
            {
                numberInput.Text = "N/A";
            }
            else
            {
                numberInput.Text = number;
            }*/

        }
    }
}
