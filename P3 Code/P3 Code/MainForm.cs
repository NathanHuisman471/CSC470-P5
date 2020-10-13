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
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            //ModifyProject mp = new ModifyProject();
            //mp.Show();
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject selectproj = new FormSelectProject("Remove");
            selectproj.Show();
            //RemoveProject rp = new RemoveProject();
            //rp.Show();
        }
    }
}
