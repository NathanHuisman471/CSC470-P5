using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists";
        public const string NO_PROJECT_FOUND_ERROR = "No project found";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank";
        private static List<Project> projects;
        public int nextId = 4;


        public FakeProjectRepository()
        {
            if(projects == null)
            {
                projects = new List<Project>();

                projects.Add(new Project
                {
                    Id = 1,
                    Name = "Hello1"
                });
                projects.Add(new Project
                {
                    Id = 2,
                    Name = "Hello2"
                });
                projects.Add(new Project
                {
                    Id = 3,
                    Name = "Hello3"
                });
                projects.Add(new Project
                {
                    Id = 4,
                    Name = "Hello4"
                });
            }

        }

        public int GetNextID()
        {
            int currentId;
            foreach (var Project in projects)
            {
                currentId = Project.Id;
                if(currentId >= nextId)
                {
                    nextId = currentId;
                }
            }
            nextId++;
            return (nextId);
        }

        public string Add(Project project, out int Id)
        {
            Id = GetNextID();

            MessageBox.Show(Id.ToString());

            //make sure user given name is valid
            project.Name = project.Name.Trim();
            project.Name.Trim(); //removes leading and trailing white spaces
            if (project.Name == null)
            {
                return (EMPTY_PROJECT_NAME_ERROR);
            }
            var isDuplicate = IsDuplicateName(project.Name);
            if(isDuplicate == true)
            {
                return (DUPLICATE_PROJECT_NAME_ERROR);
            }


            //add new project to list
            projects.Add(new Project
            {
                Id = Id,
                Name = project.Name
            });
            return (NO_ERROR);
        }

        public List<Project> GetAll()
        {
            return projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            foreach (var Project in projects)
            {
                if (Project.Name == projectName)
                {
                    return (true);
                }
            }
            return (false);
        }

        public string Modify(int projectId, Project project)
        {
            int initialProjectId = projectId;

            project.Name = project.Name.Trim();
            project.Name.Trim(); //removes leading and trailing white spaces
            if (project.Name == null)
            {
                return (EMPTY_PROJECT_NAME_ERROR);
            }
            var isDuplicate = IsDuplicateName(project.Name);
            if (isDuplicate == true)
            {
                return (DUPLICATE_PROJECT_NAME_ERROR);
            }

            bool projectFound = false;
            int listIndex = 0;
            foreach (var Project in projects)
            {
                if(Project.Id == projectId)
                {
                    projects[listIndex].Name = project.Name;
                    projectFound = true;
                }
                if(projectFound == true)
                {
                    return (NO_ERROR);
                }
                listIndex++;
            }

            //since the user has no way to modify the id, is this just a sanity check???? but it's required
            if(projectFound == false)
            {
                return (MODIFIED_PROJECT_ID_ERROR);
            }

            return (NO_ERROR);
        }

        public string Remove(int projectId)
        {
            var itemToRemove = projects.SingleOrDefault(r => r.Id == projectId);
            if (itemToRemove != null)
            {
                projects.Remove(itemToRemove);
            }
            else
            {
                return (NO_PROJECT_FOUND_ERROR);
            }
            return (NO_ERROR);
        }
    }
}
