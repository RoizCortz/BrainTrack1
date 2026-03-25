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
    public partial class LogInPage : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BrainTrack_data.mdb");
        OleDbCommand cmd;//                         Reconnect ^ if on another device
        OleDbDataReader dr;

        public LogInPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Signupbutton1_Click(object sender, EventArgs e)
        {
            RegisterPage RP = new RegisterPage();
            RP.Show();
            this.Close();
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new OleDbCommand("SELECT * FROM account WHERE username='" + usernameBox.Text + "' AND password='" + passwordBox.Text + "'", connection);
            dr = cmd.ExecuteReader();//            Table          Column             Data                Column            Data                  Var

            if (dr.Read())
            {
                MessageBox.Show("Login Successful");
                MainPage mP = new MainPage();
                mP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
                connection.Close();
                //must close connection if login failed, otherwise it will cause an error. yes
            }
        }
    }
}
