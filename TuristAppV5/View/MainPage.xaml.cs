// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TuristAppV5.ViewModel;

namespace TuristAppV5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       

        public MainPage()
        {
            this.InitializeComponent();
        }



        MainViewModel viewModel = new MainViewModel();
        

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (CultureItemsPage));
        }


        private void EventsButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            

            MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[4];
            Frame.Navigate(typeof (EatItemsPage));
        }

        private void RestaurantButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedAttraction = viewModel.Restaurants.AttractionLists[4];
            Frame.Navigate(typeof (EventItemsPage));
        }

        private void DanishFlybutton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("Danish");
        }

        private void EnglishFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("English");
        }

        private void FrenchFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("French");
        }

        private void GermanFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("German");
        }

        private void RussianFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("Russian");
        }

        private void SpanishFlyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LanguagePage.SaveLanguageAsJson("Spanish");
        }

        private void ExitButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
