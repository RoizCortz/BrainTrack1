using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BrainTrack1
{
    public partial class RegisterPage : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\BrainTrack1\BrainTrack_data.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegBack_Click(object sender, EventArgs e)
        {
            LogInPage LIP = new LogInPage();
            LIP.Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new OleDbCommand("INSERT INTO account ([fullname], [username], [password], [dateofbirth]) VALUES (?, ?, ?, ?)", connection);
            cmd.Parameters.AddWithValue("@fullname", FullnameBox.Text); //value of fullname
            cmd.Parameters.AddWithValue("@username", usernameBox.Text); //value of username
            cmd.Parameters.AddWithValue("@password", passwordBox.Text); //value of password
            cmd.Parameters.Add("@dateofbirth", OleDbType.DBDate).Value = DateBirth.Value;
            //                                                           DatePicker&Value 
            int tof = cmd.ExecuteNonQuery();//needs to declare that it writes then,
            
            if (tof > 0)
            {
                MessageBox.Show("Registration successful!");
                LogInPage LIP = new LogInPage();
                LIP.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
                connection.Close();
            }
        }
    }
}
