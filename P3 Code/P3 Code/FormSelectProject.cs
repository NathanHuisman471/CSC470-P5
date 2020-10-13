using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class FormSelectProject : Form
    {
        public string whoCalledTheMethod = "";
        public FormSelectProject(string caller)
        {
            whoCalledTheMethod = caller;
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

            foreach(var Project in list)
            {
                string projectsListed = (Project.Id + " - " + Project.Name);
                listBox1.Items.Add(projectsListed);
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
                if (whoCalledTheMethod == "Modify")
                {
                    string selectedItem = listBox1.SelectedItem.ToString();
                    string result = selectedItem.Substring(4, selectedItem.Length - 4);

                    if( result == Properties.Settings.Default.Preference)
                    {
                        MessageBox.Show("Cannot modify your current session project.");
                        this.Hide();
                        this.Close();

                    }
                    else
                    {
                        char idInCharacterForm = selectedItem[0];
                        int selectedId = idInCharacterForm - '0';
                        this.Hide();
                        ModifyProject modifyProject = new ModifyProject(selectedId);
                        modifyProject.Show();
                        this.Close();

                    }
                }
                else if(whoCalledTheMethod == "Main" || whoCalledTheMethod == "Login")
                {
                    string selectedItem = listBox1.SelectedItem.ToString();
                    string result = selectedItem.Substring(4, selectedItem.Length - 4);
                    Properties.Settings.Default.Preference = result;
                    string preference = Properties.Settings.Default.Preference;
                    char idInCharacterForm = selectedItem[0];
                    string UserName = Properties.Settings.Default.Username; 
                    FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                    preferenceRepository.SetPreference(UserName, result, Char.ToString(selectedItem[0]));
                    
                    FakePreferenceRepository pref = new FakePreferenceRepository();
                    pref.GetPreference(UserName, result);



                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                    this.Close();
                }
                else if(whoCalledTheMethod == "Remove")
                {

                    string selectedItem = listBox1.SelectedItem.ToString();
                    string result = selectedItem.Substring(4, selectedItem.Length - 4);

                    if( result == Properties.Settings.Default.Preference)
                    {
                        MessageBox.Show("Cannot remove your current session project.");
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        char idInCharacterForm = selectedItem[0];
                        int selectedId = idInCharacterForm - '0';
                        this.Hide();
                        RemoveProject removeProject = new RemoveProject(selectedId);
                        removeProject.Show();
                        this.Close();
                    }
                }
            }
        }

        int numOfTimesClicked;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            numOfTimesClicked++;
            if(numOfTimesClicked == 1)
            {
                this.Hide();
                MessageBox.Show("A project must be selected.");
                this.Show();
            } 
            else
            {
                Application.Exit();
            }
        }
    }
}
