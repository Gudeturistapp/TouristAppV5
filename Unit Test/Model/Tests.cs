using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Model;
using TuristAppV5.ViewModel;
using TuristAppV5.View;
using TuristAppV5.Common;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Unit_Test.Model;

namespace UnitTesting
{
    [TestClass]
    public class Tests
    {
        private Login login;
        private UserData data;
        private ItemDetailPageNew itemDetailPage;

        [TestInitialize]
        public void Beforetest()
        {
            login = new Login();
            data = new UserData("", "", "");
            itemDetailPage = new ItemDetailPageNew();
        }

        [TestMethod]

        public void Testmethod1()
        {
            //Checks and fails if the username(key) is blank or null ... test 1.5

            data.UserName = "User";

            Assert.AreEqual("User", data.UserName);

            login.LoginDictionary.Add(data.UserName, "321");


            try
            {

                login.LoginDictionary.Clear();
                data.UserName = null;
                Assert.Fail();


            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Error! Username is null.", ex.Message);
            }
      }

        [TestMethod]

        public void Testmethod2()
        {
            //indtast test 2.1 her

        }

        [TestMethod]

        public void Testmethod3()
        {
            //Adds an username(key), then checks and returns an error if the existing username(key) is already added to the dictionary. test 3.12

            login.LoginDictionary.Add("ProTank", "");
            Assert.IsTrue(login.LoginDictionary.ContainsKey("ProTank"));
            try
            {
                login.LoginDictionary.Add("ProTank", "");
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("An item with the same key has already been added.", ex.Message);
            }
        }

       [TestMethod]

        public void Testmethod4()
        {
            //tester om brugeren er logget ind indtast test 3.6 her
            login.IsLoggedIn = true;
            Assert.IsTrue(login.IsLoggedIn);
            
        }

       [TestMethod]

       public void Testmethod5()
       {
           //tester om brugeren bruger @ ved registerering af email indtast test 3.8 her
           try
           {
               itemDetailPage.EmailTextbox1 = "";
               Assert.Fail();
           }
           catch (ArgumentException ex)
           {
               Assert.AreEqual("Please enter a valid email adress.", ex.Message);
           }

       }
    }
}
