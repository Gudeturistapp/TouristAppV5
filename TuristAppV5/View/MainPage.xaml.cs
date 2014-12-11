// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Controls;
using TuristAppV5.Model;
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
        //SingletonViewModel singleton = new SingletonViewModel();

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           // MainViewModel.SelectedCategory = singleton.Categories[0];
            Frame.Navigate(typeof (ItemsPage));
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            //MainViewModel.SelectedCategory = viewModel.Categories.Event[0];
            Frame.Navigate(typeof (ItemsPage));
        }

     


        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (ItemDetailPage));
        }

    }
}
