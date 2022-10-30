using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class Dashboard : Form
    {
        string ConnectionString; 
        SqlConnection Connection; 
        SqlDataAdapter Adapter; 

        public Dashboard()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["DataBaseProject.Properties.Settings.StoryDatabaseConnectionString"].ConnectionString;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (Connection = new SqlConnection(ConnectionString)) 
            using (Adapter = new SqlDataAdapter("SELECT Id, Title FROM StoryTable", ConnectionString))
            {
                Connection.Open();
                DataTable TitleTable = new DataTable(); 
                Adapter.Fill(TitleTable); 
                SelectionBox.ValueMember = "Id"; 
                SelectionBox.DisplayMember = "Title";
                SelectionBox.DataSource = TitleTable;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) //Read data from database
        {
            int Id = (int)SelectionBox.SelectedValue - 1;
            using (Connection = new SqlConnection(ConnectionString))
            using (Adapter = new SqlDataAdapter("SELECT * FROM StoryTable", ConnectionString))
            {
                Connection.Open();
                var TextTable = new DataSet();
                Adapter.Fill(TextTable);
                StoryTextbox.Text = TextTable.Tables[0].Rows[Id]["Story"].ToString();
                AuthorLabel.Text = TextTable.Tables[0].Rows[Id]["Author"].ToString();
                TitleLabel.Text = TextTable.Tables[0].Rows[Id]["Title"].ToString();
            }
        }

        

        private void SaveButton_Click(object sender, EventArgs e) //Write data to database
        {
            string WriteSql = "INSERT INTO StoryTable ([Author], [Title], [Story]) values(@author, @title, @story)";
            if ((AuthorTextbox.Text != "") && (TitleTextbox.Text != "") && (StoryTextbox.Text != ""))
            {
                using (Connection = new SqlConnection(ConnectionString))
                using (SqlCommand DoSomething = new SqlCommand(WriteSql, Connection)) 
                {
                    Connection.Open();
                    DoSomething.Parameters.Add("@author", SqlDbType.NVarChar).Value = AuthorTextbox.Text;
                    DoSomething.Parameters.Add("@title", SqlDbType.NVarChar).Value = TitleTextbox.Text;
                    DoSomething.Parameters.Add("@story", SqlDbType.NVarChar).Value = StoryTextbox.Text;
                    int RowAdded = DoSomething.ExecuteNonQuery();
                    if (RowAdded > 0)
                    {
                        AuthorTextbox.Clear();
                        TitleTextbox.Clear();
                        StoryTextbox.Clear();
                        LoadData();
                        MessageBox.Show("Succesfully added your story!");
                    }
                    else MessageBox.Show("Something went wrong...");
                }
            }
            else MessageBox.Show("Please enter a Name, Title and Story...");
        }
    }
}
