using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public interface IProjectRepository
    {
        string Add(Project project, int out Id);
        string Remove(int projectId);
        string Modify(int projectId, Project projectId);
        List<Project> GetAll();
        bool IsDuplicateName(string projectName);
    }
}
