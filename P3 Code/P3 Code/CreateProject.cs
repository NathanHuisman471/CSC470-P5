using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void CreateProjectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateProjectAddButton_Click(object sender, EventArgs e)
        {
            FakeProjectRepository projectRepository = new FakeProjectRepository();
            string newName = CreateProjectTextBox.Text;
            string Result = projectRepository.Add(new Project { Name = newName }, out int newId);
            if (Result != FakePreferenceRepository.NO_ERROR)
            {
                MessageBox.Show("Error adding project. " + Result);
            }
            else
            {
                MessageBox.Show("Successfully added project");
            }
            CreateProjectTextBox.Clear();
        }
    }
}
