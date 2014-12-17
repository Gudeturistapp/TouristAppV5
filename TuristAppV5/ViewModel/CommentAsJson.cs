using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    class CommentAsJson
    {
        Comments comment = new Comments();
       static MainViewModel viewModel = new MainViewModel();
        

        private static string JsonFileName = "CommentsJson.dat";

        public static async void SerializeCommentFileAsync(string CommentString, string FileName)
        {

            StorageFile LocalFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(LocalFile, CommentString);
        }

        public static async Task<string> DeserializeCommentFileAsync(string FileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(FileName);
            return await FileIO.ReadTextAsync(localFile);

           
        }

        public static async void SaveCommentAsJson()
        {
            string CommentJsonString = JsonConvert.SerializeObject(viewModel.Events.AttractionLists[0].Comment);
            SerializeCommentFileAsync(CommentJsonString, JsonFileName);
        }

        public static async Task<ObservableCollection<string>> LoadCommentsAsJson()
        {
            string CommentJsonString = await DeserializeCommentFileAsync(JsonFileName);
            return (ObservableCollection<string>) JsonConvert.DeserializeObject(CommentJsonString, typeof (ObservableCollection<string>));
        }

        public async void SaveComments()
        {
            SaveCommentAsJson();
        }

        public async void LoadComments()
        {
            LoadCommentsAsJson();
        }


    }
}
