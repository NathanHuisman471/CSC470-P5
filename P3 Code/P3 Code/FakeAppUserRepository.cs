using System.Collections.Generic;
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
                AppUsers.Add(davebish, new AppUser
                {
                    UserName = davebish,
                    Password = SocialLoafing,
                    LastName = "Bishop",
                    FirstName = "Barb",
                    EmailAddress = davebish@trojans.dsu.edu
                    IsAuthenticated = true

                });
                AppUsers.Add(moliver, new AppUser

                {
                    UserName = moliver,
                    Password = SleepAllDayPlease,
                    LastName = "Oliver",
                    FirstName = "Matthew",
                    EmailAddress = matthew.oliver@trojans.dsu.edu,
                    IsAuthenticated = true

                });
        }
            private string GetNextUserName()
            {
                int curMaxUserName = 0;

                foreach (KeyValuePair<int, AppUser> keyValuePair in AppUsers)
                {
                    if (keyValuePair.Key > curMaxUserName)
                    {
                        curMaxUserName = keyValuePair.Key;
                    }
                }
                return ++curMaxUserName;
            }
            public bool Login(string UserName, string Password)
            {
                string UserName = GetNextUserName();
                appUser.UserName = UserName;
                AppUsers.Add(appUser.Username, appUser);
                return UserName;
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
            AppUsers appuser;
            bool ignore = AppUsers.TryGetValue(UserName, out appuser);
            return appuser;
        }
    }
}