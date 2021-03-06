﻿using TuristAppV5.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233
using TuristAppV5.Model;
using TuristAppV5.ViewModel;

namespace TuristAppV5.View
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class EventItemsPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private Login login = new Login();
        private UserData userData;

        MainViewModel viewModel = new MainViewModel();
        ItemDetailPageNEW itemDetailPage = new ItemDetailPageNEW();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public EventItemsPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
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

        private void EventButton2_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[1];
            MainViewModel.SelectedComments = viewModel.Events.AttractionLists[1].comments;
            Frame.Navigate(typeof (ItemDetailPageNEW));
        }

        private void EventButton4_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[2];
            MainViewModel.SelectedComments = viewModel.Events.AttractionLists[2].comments;
            Frame.Navigate(typeof (ItemDetailPageNEW));
        }

        private void EventButton3_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[3];
            MainViewModel.SelectedComments = viewModel.Events.AttractionLists[3].comments;
            Frame.Navigate(typeof (ItemDetailPageNEW));
        }

        private void EventButton1_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[0];
            MainViewModel.SelectedComments = viewModel.Events.AttractionLists[0].comments;
            Frame.Navigate(typeof(ItemDetailPageNEW));
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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
      }
}
