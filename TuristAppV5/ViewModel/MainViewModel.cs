using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using TuristAppV5.Model;
using Windows.Globalization;
using TuristAppV5.Annotations;
using TuristAppV5.Common;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    public class MainViewModel :INotifyPropertyChanged
    {
        //Properties + SelectedAttraction.
        //Properties + SelectedAttraction + attributter.
        #region Properties
        public static Attractions SelectedAttraction { get; set; }
        public static string SelectedComment { get; set; }

        public AttractionList Restaurants { get; set; }
        public AttractionList Events { get; set; }
        public AttractionList Culture { get; set; }
        public AttractionList Shopping { get; set; }
        public string Comment { get; set; }

        #endregion

       public MainViewModel()
        {

            int language;

            string restaurentJensensBøfhus = @"";
            string restaurentBones = @"";
            string restaurentCafeVivaldi = @"";
            string restaurentMumm = @"";

            string eventRoskildeFestival = @"";
            string eventLysfest = @"";
            string eventHavnen = @"";
            string eventMusicon = @"";

            string shoppingsRoTorv = @"";
            string shoppingsGaaGade = @"";
            string shoppingsWebShopping = @"";
            string shoppingsBjergtrold = @"";

            string attractionVikingeSkibsMuseum = @"";
            string attractionRoskildeDomkirke = @"";
            string attractionEtGallery = @"";
            string attractionRaadhus = @"";

            Restaurants = new AttractionList();
            Events = new AttractionList();
            Culture = new AttractionList();
            Shopping = new AttractionList();

            //Ipsum

            #region Language Checker

            if (FileHandling.LoadLanguageAsJson().Result.Contains("Dansk"))
            {
                language = 1;
            }
            else if (FileHandling.LoadLanguageAsJson().Result.Contains("Spanish"))
            {
                language = 6;
            }
            else if (FileHandling.LoadLanguageAsJson().Result.Contains("French"))
            {
                language = 3;
            }
            else if (FileHandling.LoadLanguageAsJson().Result.Contains("German"))
            {
                language = 4;
            }
            else if (FileHandling.LoadLanguageAsJson().Result.Contains("Russian"))
            {
                language = 5;
            }
            else
            {
                //Default language is now English
                language = 2;
            }

            #endregion

            #region Text Definer

            if (language == 1)
            {
                //Danish

                #region Danish version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }
            else if (language == 2)
            {
                //English

                #region English version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }
            else if (language == 3)
            {
                //French

                #region French version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }
            else if (language == 4)
            {
                //German

                #region German version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }
            else if (language == 5)
            {
                //Russian

                #region Russian version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }
            else
            {
                //Spanish

                #region Spanish version

                restaurentJensensBøfhus = "";
                restaurentBones = "";
                restaurentCafeVivaldi = "";
                restaurentMumm = "";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsGaaGade = "";
                shoppingsWebShopping = "";
                shoppingsBjergtrold = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionRaadhus = "";

                #endregion
            }

            #endregion

            //Restaurants for detailPage.

            #region Restaurants

            Restaurants.AddAttraction("Jensens Bøfhus", restaurentJensensBøfhus, "/Assets/Eat/Jensens_Steak2.jpg");
            Restaurants.AddAttraction("Bones", restaurentBones, "/Assets/Eat/bones_steak.jpg");
            Restaurants.AddAttraction("Café Vivaldi", restaurentCafeVivaldi, "/Assets/Eat/Vivaldi_Steak2.jpg");
            Restaurants.AddAttraction("Mumm", restaurentMumm, "/Assets/Eat/Mumm_billede1.jpg");

            #endregion

            //Events for detailPage.

            #region Events

            Events.AddAttraction("Roskilde Festival", eventRoskildeFestival,
                "/Assets/Events/Roskilde_Festival_Scene.jpg");
            Events.AddAttraction("Lysfest", eventLysfest, "/Assets/Events/LysFest_billede1.gif");
            Events.AddAttraction("Havnen", eventHavnen, "/Assets/Events/Havn_front.jpg");
            Events.AddAttraction("Musicon", eventMusicon, "/Assets/Events/Musicon_billede2.jpg");

            #endregion

            //Shopping areas for detailPage.

            #region Shoppings

            Shopping.AddAttraction("Ro's Torv", shoppingsRoTorv, "/Assets/Shops/shopping_billede2.jpg");
            Shopping.AddAttraction("Random Område", shoppingsGaaGade, "/Assets/Shops/koebmand_billede1.jpg");
            Shopping.AddAttraction("WebShopping", shoppingsWebShopping, "/Assets/Shops/Gaagade_billede2.gif");
            Shopping.AddAttraction("Something", shoppingsBjergtrold, "/Assets/Shops/Trold_billede1.jpg");

            #endregion

            //Cultural areas for detailPage.

            #region Cultur

            Culture.AddAttraction("Vikinge Skibs Museum", attractionVikingeSkibsMuseum,
                "/Assets/Museum/viking_billede1.jpg");
            Culture.AddAttraction("Roskildes Domkirke", attractionRoskildeDomkirke,
                "/Assets/Museum/Domkirke_billede2.jpg");
            Culture.AddAttraction("Et random Galleri", attractionEtGallery, "/Assets/Museum/Galleri_billede2.jpg");
            Culture.AddAttraction("someplace", attractionRaadhus, "/Assets/Museum/Radhus_billede1.JPG");

            #endregion

            #region Comments
            Restaurants.AttractionLists[0].AddComments("blabla");
            Restaurants.AttractionLists[1].AddComments("blabla");
            Restaurants.AttractionLists[2].AddComments("blabla");
            Restaurants.AttractionLists[3].AddComments("blabla");

            Shopping.AttractionLists[0].AddComments("blabla");
            Shopping.AttractionLists[1].AddComments("blabla");
            Shopping.AttractionLists[2].AddComments("blabla");
            Shopping.AttractionLists[3].AddComments("blabla");

            Culture.AttractionLists[0].AddComments("blabla");
            Culture.AttractionLists[1].AddComments("blabla");
            Culture.AttractionLists[2].AddComments("blabla");
            Culture.AttractionLists[3].AddComments("blabla");

            Events.AttractionLists[0].AddComments("blabla");
            Events.AttractionLists[1].AddComments("blabla");
            Events.AttractionLists[2].AddComments("blabla");
            Events.AttractionLists[3].AddComments("blabla");

            #endregion

        }


        #region PC

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}