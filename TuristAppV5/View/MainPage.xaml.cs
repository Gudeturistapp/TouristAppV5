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
       

        public MainPage()
        {
            this.InitializeComponent();
        }



        MainViewModel viewModel = new MainViewModel();


        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof (ItemDetailPageNEW));
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
    }
}
