using ceTe.DynamicPDF.PageElements;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        #region methods for tabPage2 - All Sections
        private void SemesterSelected(object sender, EventArgs e)
        {
            ShowSectionsForSelectedSemester();
        }

        private void ShowSectionsForSelectedSemester()
        {
            allSectionsView.Rows.Clear();
            string semester = dropdownSemesters.Text;
            string season = semester.Split(" ")[0];
            string year = semester.Split(" ")[1];

            allSectionsView.AutoGenerateColumns = true;

            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("SP_GetInstructorAvailableCourses", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@Season", SqlDbType.VarChar).Value = season;
            myCmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;

            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);
            adapter.Fill(dt);

            ArrayList list = new ArrayList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    list.Add(dt.Rows[i][column].ToString());
                }

                allSectionsView.Rows.Add(list[0], list[1], list[2], list[3], list[4], list[5], list[6], list[7]);
                list.Clear();
            }

            for (int i = 0; i <= allSectionsView.Columns.Count - 1; i++)
            {
                allSectionsView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                allSectionsView.Columns[i].Width = allSectionsView.Columns[i].Width;
            }

            allSectionsView.Visible = true;
        }

        /*private void OnTranscriptButtonClick(object sender, EventArgs e)
        {
            string startSem = startSemList.Text;
            string endSem = endSemList.Text;

            string startSeason = startSem.Split(" ")[0];
            string startYear = startSem.Split(" ")[1];
            string endSeason = endSem.Split(" ")[0];
            string endYear = endSem.Split(" ")[1];

            if (RequestValid(startSeason, startYear, endSeason, endYear))
            {
                DataTable info = GetTranscriptInfo(startSeason, startYear, endSeason, endYear);

                Table2 table = CreateTableWithTranscriptInfo(info);

                Document document = new Document();
                Page page = new Page();
                document.Pages.Add(page);
                page.Elements.Add(table);

                SetSaveDialogSettings();

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                    document.Draw(fileStream);
                    fileStream.Close();
                }
            }
        }

        private static bool RequestValid(string startSeason, string startYear, string endSeason, string endYear)
        {
            int start = int.Parse(startYear);
            int end = int.Parse(endYear);

            bool result = false;
            if (start <= end)
            {
                if (start == end)
                {
                    if (startSeason.Equals(endSeason))
                    {
                        result = true;
                    }
                    else if (startSeason.Equals("Spring"))
                    {
                        result = true;
                    }
                }
                else if (start < end)
                {
                    result = true;
                }
            }

            return result;
        }

        private DataTable GetTranscriptInfo(string startSeason, string startYear, string endSeason, string endYear)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("sp_GetTranscriptInfo", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@StartSeason", SqlDbType.VarChar).Value = startSeason;
            myCmd.Parameters.Add("@StartYear", SqlDbType.VarChar).Value = startYear;
            myCmd.Parameters.Add("@EndSeason", SqlDbType.VarChar).Value = endSeason;
            myCmd.Parameters.Add("@EndYear", SqlDbType.VarChar).Value = endYear;
            myCmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);
            adapter.Fill(dt);
            return dt;
        }

        private static Table2 CreateTableWithTranscriptInfo(DataTable info)
        {
            Table2 table = new(20, 100, 600, 600);
            table.Columns.Add(100);
            table.Columns.Add(100);
            table.Columns.Add(100);
            table.Columns.Add(100);
            int i, j;
            i = j = 0;

            Row2 headerRow = table.Rows.Add(20, ceTe.DynamicPDF.Font.Helvetica, 12);
            headerRow.Cells.Add("Semester");
            headerRow.Cells.Add("Section Code");
            headerRow.Cells.Add("Section Name");
            headerRow.Cells.Add("Grade");

            foreach (Cell2 cell in headerRow.Cells)
            {
                cell.Underline = true;
            }

            while (i < info.Rows.Count)
            {
                Row2 newRow = table.Rows.Add(20, ceTe.DynamicPDF.Font.Helvetica, 12);
                while (j < info.Columns.Count)
                {
                    newRow.Cells.Add(info.Rows[i][j].ToString());
                    j++;
                }
                j = 0;
                i++;
            }
            return table;
        }

        private void SetSaveDialogSettings()
        {
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            saveFileDialog.FileName = username + " transcript " + monthName + " " + DateTime.Now.Year.ToString();
        }*/
        #endregion

        #region methods for tabPage3 - Students
        private void SemesterOfStudentsSelected(object sender, EventArgs e)
        {
            ShowStudentsForSelectedSemester();
        }

        private void ShowStudentsForSelectedSemester()
        {
            studentInstView.Rows.Clear();
            string semester = dropdownSemesters.Text;
            string season = semester.Split(" ")[0];
            string year = semester.Split(" ")[1];

            studentInstView.AutoGenerateColumns = true;

            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("SP_InstructorStudentInfo", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@InstructorUsername", SqlDbType.VarChar).Value = username;
            myCmd.Parameters.Add("@Season", SqlDbType.VarChar).Value = season;
            myCmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;

            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);
            adapter.Fill(dt);

            ArrayList list = new ArrayList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    list.Add(dt.Rows[i][column].ToString());
                }

                studentInstView.Rows.Add(list[0], list[1], list[2], list[3], list[4], list[5], list[6]);
                list.Clear();
            }

            for (int i = 0; i <= studentInstView.Columns.Count - 1; i++)
            {
                studentInstView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                studentInstView.Columns[i].Width = allSectionsView.Columns[i].Width;
            }

            studentInstView.Visible = true;
        }
        #endregion
    }
}
