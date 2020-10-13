using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Project_Id";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project_Name";
        public const string NO_PROJECT_FOUND_ERROR = "";
        public const string EMPTY_PROJECT_NAME_ERROR = "";
        private static List<Project> projects;


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

        public string Add(Project project, out int Id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            return projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            throw new NotImplementedException();
        }

        public string Modify(int projectId, Project project)
        {
            throw new NotImplementedException();
        }

        public string Remove(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
