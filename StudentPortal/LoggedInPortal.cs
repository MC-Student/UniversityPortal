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
    public partial class LoggedInPortal : Form
    {
        private String username;
        private SqlConnection sqlCon;
        public LoggedInPortal(string user)
        {
            InitializeComponent();
            this.username = user;
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
        private void ShowInitialInfo()
        {
            /*
             * 1. Display current courses’ names and codes with current overall grades for a given semester - use 
             * stored procedure to pull from view of all registration records (student info + section info + grade)
               2. Select start and end semester to obtain transcript; button to get transcript (Stored procedure with 
            start and end semester to get sections’ names and grades)
             */
            //GetCurrentClassNames();
            //GetCurrentClassCodes();
            //GetCurrentGrades();
        }

        private void populateStudentInformation(String username)
        {
            studentNameInput.Text = getStudentName(username);
            studentNameInput.BorderStyle = BorderStyle.FixedSingle;
            String major = getDeclaredMajor(username);
            if(major == "")
            {
                majorInput.Text = "Undeclared";
            }
            else
            {
                majorInput.Text = major;
            }
            String minor = getDeclaredMinor(username);
            if(minor == "")
            {
                minorInput.Text = "Undeclared";
            }
            else
            {
                minorInput.Text = minor;
            }
            DOBInput.Text = getDOB(username);
            String status = getHonorStatus(username);
            if (status == "1")
            {
                honorsCheck.Checked = true;
            }
            else
            {
                honorsCheck.Checked = false;
            }
            String email = getStudentEmail(username);
            emailInput.Text = email + "@student.edu";
            statusInput.Text = getStudentStatus(username);

            String address = getAddress(username);
            if (address == "")
            {
                addressInput.Text = "N/A";
            }
            else
            {
                addressInput.Text = address;
            }

            String number = getNumber(username);
            if (number == "")
            {
                numberInput.Text = "N/A";
            }
            else
            {
                numberInput.Text = number;
            }

        }

        private String getStudentName(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentName", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@name", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@name"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String studentName = sqlCmd.Parameters["@name"].Value.ToString();
            return studentName;
        }

        private String getDeclaredMajor(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentMajor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@major", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@major"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String studentMajor = sqlCmd.Parameters["@major"].Value.ToString();
            return studentMajor;
        }

        private String getDeclaredMinor(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentMinor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@minor", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@minor"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String studentMinor = sqlCmd.Parameters["@minor"].Value.ToString();
            return studentMinor;
        }

        private String getHonorStatus(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentHonorStatus", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@honors", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@honors"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String honorStatus = sqlCmd.Parameters["@honors"].Value.ToString();
            return honorStatus;
        }
        private String getDOB(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentDOB", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@dob", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@dob"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String dobResult = sqlCmd.Parameters["@dob"].Value.ToString();
            return dobResult;
        }

        private String getStudentEmail(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentEmail", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@email", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@email"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String email = sqlCmd.Parameters["@email"].Value.ToString();
            return email;
        }

        private String getStudentStatus(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentStatus", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@status", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@status"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String status = sqlCmd.Parameters["@status"].Value.ToString();
            return status;
        }
        private String getAddress(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentAddress", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@address", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@address"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String address = sqlCmd.Parameters["@address"].Value.ToString();
            return address;
        }

        private String getNumber(String user)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_GetStudentNumber", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@number", SqlDbType.VarChar, 70);
            sqlCmd.Parameters["@number"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            String studentnumber = sqlCmd.Parameters["@number"].Value.ToString();
            return studentnumber;
        }



        private void InfoTabLoadSelected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                populateStudentInformation(username);
            }
        }
        private void SemesterSelected(object sender, EventArgs e)
        {

        }

    }
}
