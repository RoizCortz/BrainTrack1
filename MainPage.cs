using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainTrack1
{
    public partial class MainPage : Form
    {
        // Connection string to the Access database (.mdb file)
        // NOTE: Adjust the path if running on another device
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\RoizCortz\BrainTrack1\BrainTrack_data.mdb");
        OleDbCommand cmd; // Used for executing SQL commands
        OleDbDataReader dr; // Used for reading results from queries

        private string CurrentUsername; // Stores the username of the logged-in user

        public MainPage(string username) // Constructor that accepts a username (called after login)
        {
            InitializeComponent();
            UsernameDis.Text = "Welcome, " + username + "!"; // Display welcome message with the current username
            CurrentUsername = username;  // Save username for later use (e.g., filtering tasks)

            SetupGrid(); // Configure DataGridView columns

            LoadTasksForUsername(CurrentUsername); // Load tasks belonging to the current user
        }
        private void SetupGrid() // Configure DataGridView columns manually This prevents extra columns (like ID or Username) from appearing
        {
            dataGridView1.AutoGenerateColumns = false; // Disable auto column generation
            dataGridView1.Columns.Clear(); // Clear any existing columns

            // Add columns with headers and bind them to database fields
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Task", DataPropertyName = "Task" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subject", DataPropertyName = "Subject" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Due Date", DataPropertyName = "DueDate" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Priority", DataPropertyName = "Priority" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
        }

        private void LoadTasksForUsername(string username) // Load tasks from the database for the given username
        {
            string query = "SELECT Task, Subject, DueDate, Priority, Status FROM tasks WHERE Username = @username";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", CurrentUsername); // Bind username parameter to filter tasks

                // Fill DataTable with query results
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tasksTable = new DataTable();
                adapter.Fill(tasksTable);
                dataGridView1.DataSource = tasksTable;  // Bind DataTable to DataGridView
            }
        }

        public MainPage() // Default constructor (not used in login flow, but required by WinForms)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)  // Event handler for DataGridView clicks (currently unused)
        {

        }

        private void AddTask_Click(object sender, EventArgs e)  // Event handler for Add Task button
        {
            // Collect input values from form fields
            string T = TaskTitle.Text;
            string SJ = SubjectType.Text;
            DateTime D = DateTime.Parse(TaskDue.Text); // Parse due date as DateTime
            string P = TaskPriority.Text; 
            string S = Status.Text;

            // Insert into DB with Current User
            string query = "INSERT INTO tasks (Task, Subject, DueDate, Priority, Status, Username) " +
                   "VALUES (@task, @subject, @due, @priority, @status, @username)";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                // Bind parameters to prevent SQL injection and match column types
                cmd.Parameters.AddWithValue("@task", T);
                cmd.Parameters.AddWithValue("@subject", SJ);
                cmd.Parameters.AddWithValue("@due", D);
                cmd.Parameters.AddWithValue("@priority", P);
                cmd.Parameters.AddWithValue("@status", S);
                cmd.Parameters.AddWithValue("@username", CurrentUsername); // Correct parameter name

                // Open connection, execute insert, then close
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            LoadTasksForUsername(CurrentUsername);  // Refresh DataGridView to show updated tasks
        }
    }
}
