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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            string username = Properties.Settings.Default.Username;
            string project = Properties.Settings.Default.Preference;

            FakePreferenceRepository pref = new FakePreferenceRepository();

            string title = pref.GetPreference(username, project);
            this.Text = "Main - " + project;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormSelectProject selectproj = new FormSelectProject("Main");
            selectproj.Show();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProject cp = new CreateProject();
            cp.Show();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject selectproj = new FormSelectProject("Modify");
            selectproj.Show();
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject selectproj = new FormSelectProject("Remove");
            selectproj.Show();
        }
    }
}
