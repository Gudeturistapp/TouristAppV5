using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    public class UserData
    {
        private static string _userName;
        private static string _email;
        private static string _phone;

        public string UserName
        {
            get { return _userName; }
            set
            {
                CheckUserName(value);
                _userName = value;
            }
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

        private void CheckUserName(string UserName)
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                throw new ArgumentException("Error! Username is null.");
            }
        }
        public UserData(string username, string email, string phone)
        {
            _userName = username;
            _email = email;
            _phone = phone;
        }
    }
}
