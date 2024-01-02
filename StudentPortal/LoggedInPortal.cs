using System;
﻿using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;

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

        private void InfoTabLoadSelected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                gradeView.Columns.Add("col_sectionCode", "Section Code");
                gradeView.Columns.Add("col_sectionName", "Section Name");
                gradeView.Columns.Add("col_sectionGrade", "Grade");
                gradeView.Visible = true;
            } 
        }

        private void DisplayCoursesOnButtonClick(object sender, EventArgs e)
        {
            GetCourses();

            // Add a CellClick handler to handle clicks in the button column.
            coursesView.CellClick +=
               new DataGridViewCellEventHandler(ReactToButtonColumnClicks);
        }

        private void ReactToButtonColumnClicks(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int studentId = 0;
                studentId = GetStudentID(studentId);

                String course = coursesView.Rows[e.RowIndex].Cells["course_title"].Value as String;
                int sectionId = GetSectionID(course);

                bool currentlyEnrolled = GetEnrollmentStatus(studentId, sectionId) != 0 ? true : false;

                if (senderGrid.Columns[e.ColumnIndex].Name.ToString().Equals("Add Course"))
                {
                    int slotsLeft = GetNumOfSlotsLeft(sectionId);

                    if (slotsLeft < 1)
                    {
                        MessageBox.Show("The course is full");
                    }
                    else if (currentlyEnrolled == false)
                    {
                        RegisterStudentForSection(studentId, sectionId);
                    }
                    else
                    {
                        MessageBox.Show("Already enrolled in this course");
                    }
                }

                else if (senderGrid.Columns[e.ColumnIndex].Name.ToString().Equals("Drop Course"))
                {
                    if (currentlyEnrolled)
                    {
                        DropStudentFromSection(studentId, sectionId);
                    }
                    else
                    {
                        MessageBox.Show("Not currently enrolled - cannot drop");
                    }
                }
            }
        }

        private void GetCourses()
        {
            coursesView.Rows.Clear();
            String season = seasonList.SelectedItem.ToString();
            String year = yearList.SelectedItem.ToString();
            coursesView.AutoGenerateColumns = true;

            //get the course info using SP given a specific semester and fill data grid view
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("GetAvailableCourses", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;

            myCmd.Parameters.Add("@Season", System.Data.SqlDbType.VarChar).Value = season;
            myCmd.Parameters.Add("@Year", System.Data.SqlDbType.VarChar).Value = year;

            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);

            adapter.Fill(dt);

            ArrayList list = new ArrayList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    list.Add(dt.Rows[i][column].ToString());
                }

                coursesView.Rows.Add(list[0], list[1], list[2], list[3], list[4]
                    , list[5], list[6], list[7]);
                list.Clear();
            }

            if (coursesView.Columns.Contains("Add Course") == false)
            {
                DataGridViewButtonColumn buttonColumn =
                   new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Add";
                buttonColumn.Name = "Add Course";
                buttonColumn.Text = "Add Course";
                buttonColumn.UseColumnTextForButtonValue = true;

                coursesView.Columns.Add(buttonColumn);


                // Add a button column. 
                DataGridViewButtonColumn buttonColumn1 =
                    new DataGridViewButtonColumn();
                buttonColumn1.HeaderText = "Drop";
                buttonColumn1.Name = "Drop Course";
                buttonColumn1.Text = "Drop Course";
                buttonColumn1.UseColumnTextForButtonValue = true;

                coursesView.Columns.Add(buttonColumn1);
            }

            coursesView.Visible = true;

        }

        private int GetStudentID(int studentId)
        {
            //call SP getStudentID to get the username for the user
            SqlCommand sqlCmd = new SqlCommand("getStudentID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.username;

            // Execute the command and get the result
            using (SqlDataReader reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Access the value returned by the stored procedure
                    studentId = reader.GetInt32(0);
                }
            }

            return studentId;
        }

        private int GetSectionID(string course)
        {
            int id = 0;
            SqlCommand cmnd = new SqlCommand("SPGetSectionID", sqlCon);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.Add("@CourseTitle", SqlDbType.VarChar).Value = course;

            // Execute the command and get the result
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Access the value returned by the stored procedure
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }

        private int GetEnrollmentStatus(int studentId, int sectionId)
        {
            int returnedVal = 0;

            SqlCommand theCommand = new SqlCommand("SP_CurrentEnrollment", sqlCon);
            theCommand.CommandType = CommandType.StoredProcedure;
            theCommand.Parameters.Add("@studentId", SqlDbType.Int).Value = studentId;
            theCommand.Parameters.Add("@sectionId", SqlDbType.Int).Value = sectionId;

            // Execute the command and get the result
            using (SqlDataReader reader = theCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Access the value returned by the stored procedure
                    returnedVal = reader.GetInt32(0);
                }
            }

            return returnedVal;
        }

        private int GetNumOfSlotsLeft(int sectionId)
        {
            int slotsLeft = 0;

            SqlCommand command = new SqlCommand("SPGetSlotsLeft", sqlCon);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@sectionId", SqlDbType.Int).Value = sectionId;

            // Execute the command and get the result
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Access the value returned by the stored procedure
                    slotsLeft = reader.GetInt32(0);
                }
            }

            return slotsLeft;
        }

        private void RegisterStudentForSection(int studentId, int sectionId)
        {
            SqlCommand addCourseCmnd = new SqlCommand("SP_InsertRegistration", sqlCon);
            addCourseCmnd.CommandType = CommandType.StoredProcedure;
            addCourseCmnd.Parameters.Add("@SectionId", SqlDbType.Int).Value = sectionId;
            addCourseCmnd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;

            try
            {
                addCourseCmnd.ExecuteNonQuery();
                MessageBox.Show("Added Course Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Course.");
            }
        }

        private void DropStudentFromSection(int studentId, int sectionId)
        {
            SqlCommand dropCourseCmnd = new SqlCommand("SP_DropCourse", sqlCon);
            dropCourseCmnd.CommandType = CommandType.StoredProcedure;
            dropCourseCmnd.Parameters.Add("@SectionId", SqlDbType.Int).Value = sectionId;
            dropCourseCmnd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;

            try
            {
                dropCourseCmnd.ExecuteNonQuery();
                MessageBox.Show("Dropped Course Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Dropping Course.");
            }
        }

        private void SemesterSelected(object sender, EventArgs e)
        {
            ShowGradesForSelectedSemester();
        }

        private void ShowGradesForSelectedSemester() 
        {
            gradeView.Rows.Clear();
            String semester = dropdownSemesters.Text;
            String season = semester.Split(" ")[0];
            String year = semester.Split(" ")[1];
            
            gradeView.AutoGenerateColumns = true;

            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("sp_GetSemesterGrades", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@Season", SqlDbType.VarChar).Value = season;
            myCmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;
            myCmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);
            adapter.Fill(dt);

            ArrayList list = new ArrayList();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    list.Add(dt.Rows[i][column].ToString());
                }

                gradeView.Rows.Add(list[0], list[1], list[2]);
                list.Clear();
            }

            for (int i = 0; i <= gradeView.Columns.Count - 1; i++)
            {
                gradeView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gradeView.Columns[i].Width = gradeView.Columns[i].Width;
            }

            gradeView.Visible = true;
        }

        private void OnTranscriptButtonClick(object sender, EventArgs e)
        {
            String startSem = startSemList.Text;
            String endSem = endSemList.Text;

            String startSeason = startSem.Split(" ")[0];
            String startYear = startSem.Split(" ")[1];
            String endSeason = endSem.Split(" ")[0];
            String endYear = endSem.Split(" ")[1];

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

        private Boolean RequestValid(string startSeason, string startYear, string endSeason, string endYear)
        {
            int start = Int32.Parse(startYear);
            int end = Int32.Parse(endYear);

            Boolean result = false;
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

        private Table2 CreateTableWithTranscriptInfo(DataTable info)
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
        }
    }
}