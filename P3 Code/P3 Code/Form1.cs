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
    public partial class FormLogin : Form       // Login Form class
    {
        public FormLogin()
        {
            InitializeComponent();      // Initialize login form first upon running program
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();       // If you click cancel button, the program terminates
        }

        string Username;
        string Password;
        bool credentialsAccepted;
        public void LoginButton_Click(object sender, EventArgs e)       // Reacts upon fulfilling or failing credentials conditions, intent to Login iwith proper credentials
        {
            Username = UserNameTextBox.Text;
            Password = PasswordTextBox.Text;
            FakeAppUserRepository fr = new FakeAppUserRepository();
            credentialsAccepted = fr.Login(Username, Password);     // Confirms login info is correct
//           System.Windows.Forms.MessageBox.Show(credentialsAccepted.ToString());
//            System.Windows.Forms.MessageBox.Show(Username);
//            System.Windows.Forms.MessageBox.Show(Password);
            if (credentialsAccepted == true)
            {
                this.Hide();        // Login form goes away for main form to take center stage
                MainForm ss = new MainForm();       // If login info is correct, opens MainForm
                ss.Show();
            } 
            
            else

            {
                System.Windows.Forms.MessageBox.Show("Incorrect Username/Password");        // If incorrect user/pass, display text detailing wrong login
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';     // Sets PasswordTextBox input to be *, you can set symbol to be whatever you want from here
            CenterToScreen();       // Center login screen
        }
    }
}
