using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class Userdata
    {

        //The main user dictionary where username and login is stored. 
        private static Dictionary<string, string> userDictionary = new Dictionary<string, string>(); 

        public Dictionary<string, string> UserDictionary
        {
            get { return userDictionary; }
            set { userDictionary = value; }
        }



        //Corner of the page shows login name after log in.
        private static string loginName;

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        //If isLoggedIn=true, collapse vissiblity of loginButton and usernameButton.
        private bool isLoggedIn;
        

        public void Login()
        {
            //if (UserDictionary.ContainsKey(NameBox.Text) && UserDictionary.ContainsValue(PassBox.Password)
            //{
                    //Success
                    //isLoggedIn = true;
            //}
        }

        public void CreateUser()
        {
            //if (!UserDictionary.ContainsKey(NameBox.Text)
            //{
                    //UserDictionary.Add(NameBox.Text, PassBox.Password);
                    

            //}
            //else
            //{
                    //Error. User already exists. 
            //}
        }




    }
}
