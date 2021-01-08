using System.Collections.Generic;
using P3_Code;

namespace E3_Code
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;
        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                // Add some default employees to work with
                AppUsers.Add("davebish", new AppUser
                {
                    UserName = "davebish",
                    Password = "Socialloaf",
                    LastName = "Bishop",
                    FirstName = "Dave",
                    EmailAddress = "davebish@trojans.dsu.edu",
                    IsAuthenticated = true

                });
                AppUsers.Add("moliver", new AppUser

                {
                    UserName = "moliver",
                    Password = "Needsleep",
                    LastName = "Oliver",
                    FirstName = "Matthew",
                    EmailAddress = "matthew.oliver@trojans.dsu.edu",
                    IsAuthenticated = true

                }); AppUsers.Add("a", new AppUser

                {
                    UserName = "a",
                    Password = "b",
                    LastName = "c",
                    FirstName = "d",
                    EmailAddress = "nathan.huisman@trojans.dsu.edu",
                    IsAuthenticated = true

                });
            }
        }
        public bool Login(string GivenUserName, string GivenPassword)
        {
            bool match = false;
            AppUser appUser;
            if (AppUsers.TryGetValue(GivenUserName, out appUser))
            {
                match = appUser.Password == GivenPassword;
            }
            return match;
        }
        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> appuser in AppUsers)
            {
                users.Add(appuser.Value);
            }
            return users;
        }

        public bool SetAuthentication(string UserName, bool IsAuthenticated)
        {
            bool authentication = false;
            AppUser appuser;
            if (AppUsers.TryGetValue(UserName, out appuser))
            {
                authentication = appuser.IsAuthenticated;
            }
            return authentication;
        }
        public AppUser GetByUserName(string UserName)
        {
            AppUser appuser;
            bool ignore = AppUsers.TryGetValue(UserName, out appuser);
            return appuser;
        }
    }
}