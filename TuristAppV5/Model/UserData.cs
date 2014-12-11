using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    public class UserData
    {
        private static string _password;
        private static string _email;
        private static string _phone;

        public string UserPassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public string UserEmail
        {
            get { return _email; }
            set { _email = value; }
        }

        public string UserPhone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public UserData(string password, string email, string phone)
        {
            _password = password;
            _email = email;
            _phone = phone;
        }
    }
}
