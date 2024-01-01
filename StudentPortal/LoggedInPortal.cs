using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggedInPortal_Load(object sender, EventArgs e)
        {
            ShowInitialInfo();
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

        private void get_courses_button_Click(object sender, EventArgs e)
        {
            GetCourses();

            // Add a CellClick handler to handle clicks in the button column.
            data_grid_view_courses.CellClick +=
               new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int studentId = 0;
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

                // Call SP to get Section ID given the selected title
                int sectionId = 1;
                String course = data_grid_view_courses.Rows[e.RowIndex].Cells["course_title"].Value as String;

                SqlCommand cmnd = new SqlCommand("SPGetSectionID", sqlCon);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.Parameters.Add("@CourseTitle", SqlDbType.VarChar).Value = course;

                // Execute the command and get the result
                using (SqlDataReader reader = cmnd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Access the value returned by the stored procedure
                        sectionId = reader.GetInt32(0);
                    }
                }

                //Call stored procedure to make set enrollment status
                bool currentlyEnrolled = false;
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
                if (returnedVal != 0)
                {
                    currentlyEnrolled = true;
                }


                if (senderGrid.Columns[e.ColumnIndex].Name.ToString().Equals("Add Course"))
                {

                    //Call SP to get registration limit - if its greater than 0
                    //AND not currently enrolled then can register
                    int slotsLeft = 0;

                    SqlCommand command = new SqlCommand("SPGetSlotsLeft", sqlCon);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@sectionId", SqlDbType.Int).Value = sectionId;

                    // Execute the command and get the result
                    using (SqlDataReader reader = cmnd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Access the value returned by the stored procedure
                            slotsLeft = reader.GetInt32(0);
                        }
                    }
                    if (slotsLeft < 1)
                    {
                        //If cannot register let user know
                        MessageBox.Show("The course is full");
                    }
                    else if (currentlyEnrolled == false)
                    {
                        //Once can register, call SP to register, let user know that registered
                        SqlCommand addCourseCmnd = new SqlCommand("SP_InsertRegistration", sqlCon);

                        // Specify that the command is a stored procedure
                        addCourseCmnd.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        addCourseCmnd.Parameters.Add("@SectionId", SqlDbType.Int).Value = sectionId;
                        addCourseCmnd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;


                        try
                        {
                            // Execute the stored procedure
                            addCourseCmnd.ExecuteNonQuery();
                            MessageBox.Show("Added Course Successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Adding Course.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Already enrolled in this course");
                    }
                }

                else if (senderGrid.Columns[e.ColumnIndex].Name.ToString().Equals("Drop Course"))
                {
                    //Call SP to make sure that registered for the course 
                    if (currentlyEnrolled)
                    {
                        //once confirmed that currently enrolled, call SP to drop it, once dropped let user know done
                        SqlCommand dropCourseCmnd = new SqlCommand("SP_DropCourse", sqlCon);

                        // Specify that the command is a stored procedure
                        dropCourseCmnd.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        dropCourseCmnd.Parameters.Add("@SectionId", SqlDbType.Int).Value = sectionId;
                        dropCourseCmnd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;


                        try
                        {
                            // Execute the stored procedure
                            dropCourseCmnd.ExecuteNonQuery();
                            MessageBox.Show("Dropped Course Successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Dropping Course.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not currently Enrolled, so cannot drop");
                    }
                }

            }
        }


        private void GetCourses()
        {
            data_grid_view_courses.Rows.Clear();
            String season = semester_list_seaon.SelectedItem.ToString();
            String year = semester_list_year.SelectedItem.ToString();
            data_grid_view_courses.AutoGenerateColumns = true;

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

                data_grid_view_courses.Rows.Add(list[0], list[1], list[2], list[3], list[4]
                    , list[5], list[6], list[7]);
                list.Clear();
            }

            if (data_grid_view_courses.Columns.Contains("Add Course") == false)
            {
                DataGridViewButtonColumn buttonColumn =
                   new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Add";
                buttonColumn.Name = "Add Course";
                buttonColumn.Text = "Add Course";
                buttonColumn.UseColumnTextForButtonValue = true;

                data_grid_view_courses.Columns.Add(buttonColumn);


                // Add a button column. 
                DataGridViewButtonColumn buttonColumn1 =
                    new DataGridViewButtonColumn();
                buttonColumn1.HeaderText = "Drop";
                buttonColumn1.Name = "Drop Course";
                buttonColumn1.Text = "Drop Course";
                buttonColumn1.UseColumnTextForButtonValue = true;

                data_grid_view_courses.Columns.Add(buttonColumn1);
            }


            data_grid_view_courses.Visible = true;

        }
        private void SemesterSelected(object sender, EventArgs e)
        {

        }
    }
}
