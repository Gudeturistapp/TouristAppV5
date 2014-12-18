// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TuristAppV5.Common;
using TuristAppV5.Model;
using TuristAppV5.ViewModel;
using System;

namespace TuristAppV5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Login login = new Login();
        private UserData userData;


        public MainPage()
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

                //userDataAsJson.SaveLoginData();


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


        private void EventsButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            

            Frame.Navigate(typeof (EventItemsPage));
        }

        private void RestaurantButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof (EatItemsPage));
        }

        private void CultureButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof (CultureItemsPage));
        }

        private void ShoppingButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof (ShopItemsPage));
        }

        private void DanishFlybutton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("Danish");
        }

        private void EnglishFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("English");
        }

        private void FrenchFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("French");
        }

        private void GermanFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("German");
        }

        private void RussianFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("Russian");
        }

        private void SpanishFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FileHandling.WriteLanguageFileAsync("Spanish");
        }

        private void ExitButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
