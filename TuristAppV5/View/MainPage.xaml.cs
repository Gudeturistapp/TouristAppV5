// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Controls;
using TuristAppV5.ViewModel;

namespace TuristAppV5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       // MainViewModel viewModel = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (ItemsPage));
        }

        private void EventsButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           // MainViewModel.SelectedAttraction = viewModel.Events.AttractionLists[0];
            Frame.Navigate(typeof (ItemsPage));
        }

        private void RestaurantButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // MainViewModel.SelectedAttraction = viewModel.Restaurants.AttractionLists[0];
            Frame.Navigate(typeof (ItemsPage));
        }
    }
}
