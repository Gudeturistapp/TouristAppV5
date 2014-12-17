using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Text;
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
        private const string languageFileName = "Language.DAT";

        #region Language file handling.
        public static async void SaveLanguageAsync(string _language)
        {
            //SaveLanguageAsync
            WriteLanguageFileAsync(_language, languageFileName);
        }

        public static async Task<string> LoadLanguageAsync()
        {
            //LoadLanguageAsync
            string languageJsonString = await ReadLanguageFileAsync(languageFileName);
            return languageJsonString;
        }

        public static async void WriteLanguageFileAsync(string languageDataString, string localFileName)
        {
            //WriteLanguageFileAsync
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(localFileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, languageDataString);
        }

        public static async Task<string> ReadLanguageFileAsync(string localFileName)
        {
            //ReadLanguageFileAsync
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(localFileName);
            return await FileIO.ReadTextAsync(localFile);
        }
        #endregion

        //public static async Task<String> FindLanguage()
        //{
        //    string boh;
        //    var task = LoadLanguageAsJson();
        //    task.Wait();
        //    return task.Result;
        //}
    }
}
