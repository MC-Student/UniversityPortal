using System;
using System.Collections;
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

        private void SemesterSelected(object sender, EventArgs e)
        {
            ShowGrades();
        }

        private void ShowGrades() 
        {
            gradeView.Rows.Clear();
            String semester = dropdownSemesters.Text;
            String season = semester.Split(" ")[0];
            String year = semester.Split(" ")[1];
            
            gradeView.AutoGenerateColumns = true;

            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("sp_GetSemesterGrades", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@Season", System.Data.SqlDbType.VarChar).Value = season;
            myCmd.Parameters.Add("@Year", System.Data.SqlDbType.VarChar).Value = year;
            myCmd.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = username;

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

            gradeView.Visible = true;
        }
    }
}
