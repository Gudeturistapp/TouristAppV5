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

namespace TuristAppV5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LanguagePage : Page
    {
        private static string _language = "English";
        private static string fileName = "Language.Dat";

        

        public LanguagePage()
        {
            this.InitializeComponent();
            SaveLanguageAsJson(_language);
        }

        #region Language file handling.
        public static async void SaveLanguageAsJson(string _language)
        {
            string languageJsonString = JsonConvert.SerializeObject(_language);
            SerializeLanguageFileAsync(languageJsonString, fileName);
        }

        public static async Task<string> LoadLanguageAsJson()
        {
            string languageJsonString = await DeSerializeLanguageFileAsync(fileName);
            return(string)JsonConvert.DeserializeObject(languageJsonString, typeof(string));
        }

        public static async void SerializeLanguageFileAsync(string languageDataString, string localFileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(localFileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, languageDataString);
        }

        public static async Task<string> DeSerializeLanguageFileAsync(string localFileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(localFileName);
            return await FileIO.ReadTextAsync(localFile);
        }

        #endregion

        #region Buttons
        private void DanishLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("Danish");
            Frame.Navigate(typeof(MainPage));
        }

        private void EnglishLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("English");
            Frame.Navigate(typeof(MainPage));
        }

        private void SpanishLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("Spanish");
            Frame.Navigate(typeof(MainPage));
        }

        private void GermanLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("German");
            Frame.Navigate(typeof(MainPage));
        }

        private void FrenchLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("French");
            Frame.Navigate(typeof(MainPage));
        }

        private void RussianLanguageButton(object sender, RoutedEventArgs e)
        {
            SaveLanguageAsJson("Russian");
            Frame.Navigate(typeof(MainPage));
        } 
        #endregion
    }
}
