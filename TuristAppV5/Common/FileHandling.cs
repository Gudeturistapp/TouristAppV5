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

namespace TuristAppV5.Common
{
    public class FileHandling
    {
        private static string _language = "English";
        private const string languageFileName = "Language.Dat";

        #region Language file handling.
        public static async void SaveLanguageAsJson(string _language)
        {
            string languageJsonString = JsonConvert.SerializeObject(_language);
            SerializeLanguageFileAsync(languageJsonString, languageFileName);
        }

        public static async Task<string> LoadLanguageAsJson()
        {
            string languageJsonString = await DeSerializeLanguageFileAsync(languageFileName);
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
    }
}
