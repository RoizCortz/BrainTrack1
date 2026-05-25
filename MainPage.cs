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

/*
-------------------------------------------
 BrainTrack1 - MainPage.cs
 Variable List & Purpose
-------------------------------------------

connection      → OleDbConnection object holding the connection string to the Access database.
cmd             → OleDbCommand object used to execute SQL queries (INSERT, DELETE, SELECT).
dr              → OleDbDataReader object for reading query results row by row (not heavily used here).
CurrentUsername → Stores the username of the currently logged-in user; used to filter tasks per user.

UsernameDis     → Label control that displays "Welcome, [username]!" on the Main form.
dataGridView1   → DataGridView control that displays tasks from the database.
tasksTable      → DataTable object that temporarily holds query results before binding to the grid.

TaskTitle       → TextBox input for the task name.
SubjectType     → ComboBox/TextBox input for the subject category.
TaskDue         → TextBox/DateTime input for the due date.
TaskPriority    → ComboBox/TextBox input for the priority level.
Status          → ComboBox/TextBox input for the task status.

taskId          → Integer variable storing the unique ID of the selected task (used for deletion).
result          → DialogResult variable storing the user’s response from confirmation dialogs (Yes/No).

Event Handlers:
SetupGrid()                      → Configures DataGridView columns (adds hidden ID + visible task fields).
LoadTasksForUsername()           → Loads tasks from the database filtered by CurrentUsername and binds them to the grid.
AddTask_Click()                  → Inserts a new task into the database using values from the input fields, then refreshes the grid.
DeleteTask_Click()               → Deletes the currently selected task (by hidden ID) from the database, then refreshes the grid.
ClearCompleted_Click()           → Deletes ALL tasks belonging to the current user from the database, then refreshes the grid.
dataGridView1_CellContentClick() → Event handler for clicks inside the DataGridView (currently unused).
____________________________________________
*/

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

            // Add hidden ID column for Delete Button in the DataBase
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                Name = "ID",
                Visible = false
            });

            // Add columns with headers and bind them to database fields
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Task", DataPropertyName = "Task" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subject", DataPropertyName = "Subject" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Due Date", DataPropertyName = "DueDate" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Priority", DataPropertyName = "Priority" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
        }

        private void LoadTasksForUsername(string username) // Load tasks from the database for the given username
        {
            string query = "SELECT ID, Task, Subject, DueDate, Priority, Status FROM tasks WHERE Username = @username";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", CurrentUsername); // Bind username parameter to filter tasks

                // Fill DataTable with query results
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tasksTable = new DataTable();
                adapter.Fill(tasksTable);
                dataGridView1.DataSource = tasksTable;  // Bind DataTable to DataGridView
            }

            if (dataGridView1.Columns["ID"] != null)
            {
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        public MainPage() // Default constructor (not used in login flow, but it is required by WinForms)
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

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the hidden ID value
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                string query = "DELETE FROM tasks WHERE ID = @id AND Username = @username";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.Parameters.AddWithValue("@username", CurrentUsername);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                // Refresh grid
                LoadTasksForUsername(CurrentUsername);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void ClearCompleted_Click(object sender, EventArgs e)
        {
            // Ask user for confirmation before wiping everything
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL your tasks?",
                "Confirm Clear All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM tasks WHERE Username = @username";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", CurrentUsername);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                // Refresh grid to show it's empty
                LoadTasksForUsername(CurrentUsername);
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult LGResult = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (LGResult == DialogResult.Yes)
            {
                LogInPage LIP = new LogInPage();
                LIP.Show();
                this.Close();
            }
        }
    }
}
