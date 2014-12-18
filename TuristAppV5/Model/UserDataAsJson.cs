using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;

namespace TuristAppV5.Model
{
    class UserDataAsJson
    {
        Login login = new Login();

        private static string JsonFileName = "UserDataAsJson";

        public static async void SerializeLoginFileAsync(string loginString, string FileName)
        {

            StorageFile LocalFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(LocalFile, loginString);
        }

        public static async Task<string> DeserializeLoginFileAsync(string FileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(FileName);
            return await FileIO.ReadTextAsync(localFile);


        }

        public async void SaveLoginAsJson()
        {
            string LoginJsonString = JsonConvert.SerializeObject(login.LoginDictionary);
            SerializeLoginFileAsync(LoginJsonString, JsonFileName);
        }

        public static async Task<Dictionary<string, string>> LoadCommentsAsJson()
        {
            string LoginJsonString = await DeserializeLoginFileAsync(JsonFileName);
            return (Dictionary<string, string>)JsonConvert.DeserializeObject(LoginJsonString, typeof(Dictionary<string, string>));
        }

        public async void SaveLoginData()
        {
            SaveLoginAsJson();
        }

        public async void LoadLoginData()
        {
            LoadCommentsAsJson();
        }


    }
}
