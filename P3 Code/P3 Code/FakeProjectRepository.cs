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
    }
}
