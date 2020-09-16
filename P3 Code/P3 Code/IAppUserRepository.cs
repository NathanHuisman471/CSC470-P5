using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public interface IAppUserRepository
    {
        List<AppUser> GetAll();
        AppUser GetByUserName(string UserName);
        bool Login(string UserName, string Password);
        bool SetAuthentication(string UserName, bool IsAuthenticated);
    }
}
