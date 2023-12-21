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
                new DataGridViewCellEventHandler(data_grid_view_courses_CellClick);
        }

        void data_grid_view_courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Add Courses" or "Drop Courses" column           
            if (e.RowIndex >= 0 &&
                (e.ColumnIndex == data_grid_view_courses.Columns["Add Courses"].Index ||
                 e.ColumnIndex == data_grid_view_courses.Columns["Drop Courses"].Index))
            {
                // Retrieve the values from the clicked row
                String course = data_grid_view_courses.Rows[e.RowIndex].Cells["course_title"].Value as String;
                MessageBox.Show(course);

                String courseNum = data_grid_view_courses.Rows[e.RowIndex].Cells["course_num"].Value as String;
                MessageBox.Show(courseNum);
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

            // Add a button column. 
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

            data_grid_view_courses.Visible = true;
        }

    }
}
