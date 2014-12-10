using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    public class Login
    {
        private static Dictionary<string, UserData> loginDictionary = new Dictionary<string, UserData>();

        private static bool isLoggedIn = false;


        public Dictionary<string, UserData> LoginDictionary
        {
            get { return loginDictionary; }
            set { loginDictionary = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
    }
}
