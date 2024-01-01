using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            for (int i = 0; i <= gradeView.Columns.Count - 1; i++)
            {
                gradeView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gradeView.Columns[i].Width = gradeView.Columns[i].Width;
            }

            gradeView.Visible = true;
        }

        private void transcriptButton_Click(object sender, EventArgs e)
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

                Document document = new Document();
                Page page = new Page();
                document.Pages.Add(page);
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

                page.Elements.Add(table);

                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
                saveFileDialog.FileName = username + " transcript " + monthName + " " + DateTime.Now.Year.ToString();

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK) 
                {
                    FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                    document.Draw(fileStream);
                    fileStream.Close();
                }               
            }
        }

        private DataTable GetTranscriptInfo(string startSeason, string startYear, string endSeason, string endYear)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("sp_GetTranscriptInfo", sqlCon);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Add("@StartSeason", System.Data.SqlDbType.VarChar).Value = startSeason;
            myCmd.Parameters.Add("@StartYear", System.Data.SqlDbType.VarChar).Value = startYear;
            myCmd.Parameters.Add("@EndSeason", System.Data.SqlDbType.VarChar).Value = endSeason;
            myCmd.Parameters.Add("@EndYear", System.Data.SqlDbType.VarChar).Value = endYear;
            myCmd.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(myCmd);
            adapter.Fill(dt);
            return dt;
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
    }
}