using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        public const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();



        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";

            if (preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            value = Properties.Settings.Default.Preference;
            return value;
        }

        public string SetPreference(string UserName, string PreferenceName, string Value)
        {

            Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";

            NameValuePair.Add(UserName, Value);

            if (!NameValuePair.ContainsKey(UserName))
            {
                preferences.Add(PreferenceName, NameValuePair);
            }

            
            return value;
        }
    }
}
