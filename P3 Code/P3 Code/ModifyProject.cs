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
    public partial class ModifyProject : Form
    {
        public int idToBeModified;
        public ModifyProject(int Id)
        {
            idToBeModified = Id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void ModifyProjectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProjectModifyButton_Click(object sender, EventArgs e)
        {
            
            string newName = ModifyProjectTextBox.Text;
            string oldName = Properties.Settings.Default.Preference;
            string UserName = Properties.Settings.Default.Username;
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string pref = preferenceRepository.GetPreference(UserName, oldName);
            if(pref == "")
            {
                MessageBox.Show("Couldn't find user or preference" + pref);
            }
            FakeProjectRepository projectRepository = new FakeProjectRepository();
            //string newName = ModifyProjectTextBox.Text;
            string result = projectRepository.Modify(idToBeModified, new Project { Name = newName });
            if (result != FakePreferenceRepository.NO_ERROR)
            {
                MessageBox.Show("Error modifying project. " + result);
            }
            else
            {
                MessageBox.Show("Successfully modified project");
            }
            this.Close();

        }
    }
}
