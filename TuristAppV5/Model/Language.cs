using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;


namespace TuristAppV5.Model
{
    class Language
    {
        
        private static string languageFile = "Language.dat";

        //What is dis?
        public string languageData { get; set; }
        

        public async void CheckIfContinue()
        {
            StorageFile file;
            try
            {
               file = await ApplicationData.Current.LocalFolder.GetFileAsync("Language.dat");
            }
            catch (FileNotFoundException)
            {
                //Do NOTHING.
            }
        }

        public static async void SerializeUserDataFileAsync(string userDataString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, userDataString);
        }

        public static async Task<string> DeSerializeUserDataFileAsync(String fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);
        }

        public static async void SaveUserDataAsJsonAsync()
        {


            string userJsonString = JsonConvert.SerializeObject(languageFile);
            SerializeUserDataFileAsync(userJsonString, languageFile);
        }


        public void SaveLanguage()
        {
            SaveUserDataAsJsonAsync();
        }


        

    }
}
