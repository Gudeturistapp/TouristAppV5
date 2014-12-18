using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
//using TuristAppV5.Model;
using TuristAppV5.Common;
using TuristAppV5.Model;

namespace TuristAppV5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LanguagePage : Page
    {
        private static string _language = "English";
        private static string fileName = "Language.Dat";
        private Login login = new Login();
        private UserData userData;
        

        public LanguagePage()
        {
            this.InitializeComponent();
        }

        public void Register()
        {
            if (!string.IsNullOrWhiteSpace(registerUserNameBox.Text) &&
                !string.IsNullOrWhiteSpace(registerPasswordBox.Password) &&

                !string.IsNullOrWhiteSpace(registerEmailBox.Text) &&
                !string.IsNullOrWhiteSpace(registerPhoneBox.Text))
            {

                userData = new UserData(registerUserNameBox.Text, registerEmailBox.Text, registerPhoneBox.Text);

                //userData.UserName = registerUserNameBox.Text;
                //userData.UserEmail = registerEmailBox.Text;
                //userData.UserPhone = registerPhoneBox.Text;

                login.LoginDictionary.Add(registerUserNameBox.Text, registerPasswordBox.Password);


                login.IsLoggedIn = true;

                RegisterButton.Flyout.Hide();

                ErrorBlock.Text = "";
                SuccessBlock.Text = "Success! User has been created.";

            }
            else
            {
                SuccessBlock.Text = "";
                ErrorBlock.Text = "Error! Please input values in all fields.";
            }
        }

        public void Login()
        {
            if (login.LoginDictionary.ContainsKey(UsernameLoginBox.Text) && PasswordLoginBox.Password == login.LoginDictionary[UsernameLoginBox.Text])
            {
                login.IsLoggedIn = true;
                LoginButton.Flyout.Hide();

                ErrorBlock.Text = "";
                SuccessBlock.Text = "Success! Loggged in.";
            }
            else
            {
                SuccessBlock.Text = "";
                ErrorBlock.Text = "Error! Username or password incorrect.";
            }
        }


        private void RegisterButton1_Click(object sender, RoutedEventArgs e)
        {
            Register();
        }

        private void LoginButton1_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        //#region Language file handling.
        //public static async void SaveLanguageAsJson(string _language)
        //{
        //    string languageJsonString = JsonConvert.SerializeObject(_language);
        //    SerializeLanguageFileAsync(languageJsonString, fileName);
        //}

        //public static async Task<string> LoadLanguageAsJson()
        //{
        //    string languageJsonString = await DeSerializeLanguageFileAsync(fileName);
        //    return(string)JsonConvert.DeserializeObject(languageJsonString, typeof(string));
        //}

        //public static async void SerializeLanguageFileAsync(string languageDataString, string localFileName)
        //{
        //    StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(localFileName, CreationCollisionOption.ReplaceExisting);
        //    await FileIO.WriteTextAsync(localFile, languageDataString);
        //}

        //public static async Task<string> DeSerializeLanguageFileAsync(string localFileName)
        //{
        //    StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(localFileName);
        //    return await FileIO.ReadTextAsync(localFile);
        //}

        //#endregion

        #region Buttons
        private void DanishLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("Danish");
            Frame.Navigate(typeof(MainPage));
        }

        private void EnglishLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("English");
            Frame.Navigate(typeof(MainPage));
        }

        private void SpanishLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("Spanish");
            Frame.Navigate(typeof(MainPage));
        }

        private void GermanLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("German");
            Frame.Navigate(typeof(MainPage));
        }

        private void FrenchLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("French");
            Frame.Navigate(typeof(MainPage));
        }

        private void RussianLanguageButton(object sender, RoutedEventArgs e)
        {
            FileHandling.SaveLanguageAsJson("Russian");
            Frame.Navigate(typeof(MainPage));
        } 
        #endregion

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
