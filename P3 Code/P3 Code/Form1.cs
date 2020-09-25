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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Username = UserNameTextBox.ToString();
            Password = Password.ToString();
            //Login(Username, Password);
            MainForm ss = new MainForm();
            ss.Show();
        }
    }
}
