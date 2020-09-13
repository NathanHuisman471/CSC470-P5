using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public interface IEmployeeRepository
    {
        int Save(Employee Emp);
        List<Employee> GetAll();
        decimal GetSalary(int Id);
    }
}
