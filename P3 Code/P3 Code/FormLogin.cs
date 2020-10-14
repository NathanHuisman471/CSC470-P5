using E3_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int numOfTimesClicked;
        private void FormLoginCancelButton_Click(object sender, EventArgs e)
        {
            numOfTimesClicked++;

            if (numOfTimesClicked == 1)
            {
                
                MessageBox.Show("Username and password must be selected");
            }
            else
            {
                Application.Exit();
            }
            
        }

        string Username;
        string Password;
        bool credentialsAccepted;
        public void LoginButton_Click(object sender, EventArgs e)
        {
            Username = UserNameTextBox.Text;
            Password = PasswordTextBox.Text;
            FakeAppUserRepository fr = new FakeAppUserRepository();
            credentialsAccepted = fr.Login(Username, Password);
            Properties.Settings.Default.Username = Username;
            if (credentialsAccepted == true)
            {
                this.Hide();
                FormSelectProject startingproj = new FormSelectProject("Login");
                startingproj.Show();
            } 
            
            else

            {
                System.Windows.Forms.MessageBox.Show("Incorrect Username/Password");
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            CenterToScreen();
        }
    }
}
