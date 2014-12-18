using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI;
using TuristAppV5.Common;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Item Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234232
using TuristAppV5.Model;
using TuristAppV5.ViewModel;

namespace TuristAppV5.View
{
    /// <summary>
    /// A page that displays details for a single item within a group while allowing gestures to
    /// flip through other items belonging to the same group.
    /// </summary>
    public sealed partial class ItemDetailPageNEW : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();


        private Comments comments = new Comments();
        private Login login = new Login();
        private UserData userData;
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public ItemDetailPageNEW()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;

            if (login.IsLoggedIn == false)
            {
                OrderHereBlock.Text = "Log in first";
            }
            else
            {
                OrderHereBlock.Text = "   Order here";
            }
            
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            object navigationParameter;
            if (e.PageState != null && e.PageState.ContainsKey("SelectedItem"))
            {
                navigationParameter = e.PageState["SelectedItem"];
            }

            // TODO: Assign a bindable group to this.DefaultViewModel["Group"]
            // TODO: Assign a collection of bindable items to this.DefaultViewModel["Items"]
            // TODO: Assign the selected item to this.flipView.SelectedItem
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        public void Register()
        {
            if (!string.IsNullOrWhiteSpace(registerUserNameBox.Text) &&
                !string.IsNullOrWhiteSpace(registerPasswordBox.Password) &&

                !string.IsNullOrWhiteSpace(registerEmailBox.Text) &&
                !string.IsNullOrWhiteSpace(registerPhoneBox.Text))
            {

                userData = new UserData(registerUserNameBox.Text, registerPasswordBox.Password, registerEmailBox.Text, registerPhoneBox.Text);

                //userData.UserName = registerUserNameBox.Text;
                //userData.UserEmail = registerEmailBox.Text;
                //userData.UserPhone = registerPhoneBox.Text;

                login.LoginDictionary.Add(registerUserNameBox.Text, userData);


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
            if (login.LoginDictionary.ContainsKey(UsernameLoginBox.Text) && PasswordLoginBox.Password == userData.Password)
            {
                login.IsLoggedIn = true;
                LoginButton.Flyout.Hide();

                ErrorBlock.Text = "";
                SuccessBlock.Text = "Success! Loggged in.";

                OrderHereBlock.Text = "   Order here";
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

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderAppBar.Visibility = Visibility.Collapsed;

        }

        private void OrderButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (login.IsLoggedIn == true)
            {
                OrderAppBar.IsOpen = true;
                OrderAppBar.Visibility = Visibility.Visible;

              
                OrderHereNameBox.Text = userData.UserName;
                OrderHereEmailBox.Text = userData.UserEmail;
                OrderHerePhoneBox.Text = userData.UserPhone;

                
               

                

                
            }
        }

        private void PlaceOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderAppBar.IsOpen = false;

            OrderHereBlock.Foreground = new SolidColorBrush(Colors.Lime);
            OrderHereBlock.Text = "Order placed";
            
            
        }

        private void DanishFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        public bool EmailTextBox(bool Success)
        {
            if (!registerEmailBox.Text.Contains("@"))
            {
                Success = true;
                throw new ArgumentException("Please enter a correct Email.");
            }
            else
            {
                Success = false;
                throw new ArgumentException("Success!");
            }
        }

        private void AddReviewButton_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedComments.Comment.Add(AddReviewText.Text);
            AddReviewText.Text = "";
        }
    }
}
