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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
//           System.Windows.Forms.MessageBox.Show(credentialsAccepted.ToString());
//            System.Windows.Forms.MessageBox.Show(Username);
//            System.Windows.Forms.MessageBox.Show(Password);
            if (credentialsAccepted == true)
            {
                this.Hide();
                FormSelectProject startingproj = new FormSelectProject();
                startingproj.Show();
            } 
            
            else

            {
                System.Windows.Forms.MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            CenterToScreen();
        }
    }
}
