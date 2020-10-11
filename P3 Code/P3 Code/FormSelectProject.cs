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
    public partial class FormSelectProject : Form
    {
        public FormSelectProject()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSelectProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakeProjectRepository fp = new FakeProjectRepository();
            List<Project> list = fp.GetAll();

            foreach(var Name in list)
            {
                listBox1.Items.Add(list[1]);
            }
        }

        private void buttonSelectProject_Click(object sender, EventArgs e)
        {

            if(listBox1.SelectedItem == null)
            {
                MessageBox.Show("Must select a project to continue");
            }
            else
            {
                

                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
        }

        int numOfTimesClicked;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            numOfTimesClicked++;
            if(numOfTimesClicked == 1)
            {
                this.Hide();
                MessageBox.Show("A project must be selected");
                this.Show();
            } 
            else
            {
                Application.Exit();
            }
        }
    }
}
