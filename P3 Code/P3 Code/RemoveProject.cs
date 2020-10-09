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
        public RemoveProject()
        {
            InitializeComponent();
        }

        private void RemoveProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permenantly remove this project?", "Attention", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //do something
            }else if(dialogResult == DialogResult.No)
            {
                //do something
            }

        }
    }
}
