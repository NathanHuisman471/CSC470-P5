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
    public partial class RemoveProject : Form
    {
        public int projectToBeRemoved;
        public RemoveProject(int id)
        {
            projectToBeRemoved = id;
            InitializeComponent();
        }

        private void RemoveProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FakeProjectRepository projectRepository = new FakeProjectRepository();
            List<Project> list = projectRepository.GetAll();

            foreach (var Project in list)
            {
                if(projectToBeRemoved == Project.Id)
                {
                    ProjectToBeRemovedLabel.Text = Project.Name;
                }
            }
        }

        private void RemoveProjectRemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permenantly remove this project?", "Attention", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                FakeProjectRepository projectRepository = new FakeProjectRepository();
                string result = projectRepository.Remove(projectToBeRemoved);
                if (result != FakePreferenceRepository.NO_ERROR)
                {
                    MessageBox.Show("No project found. " + result);
                }
                else
                {
                    MessageBox.Show("Successfully removed project");
                }
                this.Close();
            }
            else if(dialogResult == DialogResult.No)
            {
                this.Close();
            }

        }

        private void RemoveProjectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
