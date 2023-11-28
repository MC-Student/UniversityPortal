using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StudentPortal
{
    public partial class StudentPortal : Form
    {
        private SqlConnection sqlCon;
        private DataSet dataSet;
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            if (CreateConnection())
            {
                dataSet = new DataSet();
                MessageBox.Show("Connected to university database");
            }
        }

        private Boolean CreateConnection()
        {
            try
            {
                string strServer = Environment.GetEnvironmentVariable("SQL_Server_Name", EnvironmentVariableTarget.User);
                string strDatabase = Environment.GetEnvironmentVariable("University_DB_Name", EnvironmentVariableTarget.User);

                string strConnect = $"Server={strServer};Database={strDatabase};Trusted_Connection=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + "  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Form login = new Form();
            login.Width = 500;
            login.Height = 300;
            login.Text = "Student Log In";
            Label username = new Label() { Left = 90, Top = 50, Text = "Username" };
            Label password = new Label() { Left = 90, Top = 90, Text = "Password" };
            TextBox user = new TextBox() { Left = 250, Top = 50, BorderStyle = BorderStyle.FixedSingle, 
                ReadOnly = false, PlaceholderText = "username"};
            TextBox pw = new TextBox() { Left = 250, Top = 90, BorderStyle = BorderStyle.FixedSingle, 
                ReadOnly = false, PlaceholderText = "password", PasswordChar = '\u25CF'};
            login.Controls.Add(username);
            login.Controls.Add(password);
            login.Controls.Add(user);
            login.Controls.Add(pw);
            Button ok = new Button() { Text = "Ok", Left = 150, Width = 50, Height = 40, Top = 150 };
            Button cancel = new Button() { Text = "Cancel", Left = 250, Width = 70, Height = 40, Top = 150 };
            ok.Click += (sender, e) => { /* put in stored procedure to log in */ };
            cancel.Click += (sender, e) => { login.Close(); };
            login.Controls.Add(ok);
            login.Controls.Add(cancel);
            login.ShowDialog();
        }
    }
}