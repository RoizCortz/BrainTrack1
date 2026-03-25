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
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BrainTrack_data.mdb");
        OleDbCommand cmd;//                         Reconnect ^ if on another device

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
            connection.Open();//                Column      Data        Data        Data          Data                 Values         Var
            cmd = new OleDbCommand("INSERT INTO account ([fullname], [username], [password], [dateofbirth]) VALUES (?, ?, ?, ?)", connection);
            cmd.Parameters.AddWithValue("@fullname", FullnameBox.Text); //input value of fullname 
            cmd.Parameters.AddWithValue("@username", usernameBox.Text); //input value of username
            cmd.Parameters.AddWithValue("@password", passwordBox.Text); //input value of password
            cmd.Parameters.Add("@dateofbirth", OleDbType.DBDate).Value = DateBirth.Value;
            //            "@" Declares column                            DatePicker&Value 
            int tof = cmd.ExecuteNonQuery();//needs to declare, then it writes on DB,
            
            if (tof > 0)
            {
                MessageBox.Show("Registration successful!");
                LogInPage LIP = new LogInPage();
                LIP.Show();
                this.Close();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
                connection.Close();
            }
        }
    }
}
