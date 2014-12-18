using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Common;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    public class MainViewModel
    {
        //Properties
        #region Properties
        public static string LanguageFromFile { get; set; }

        public static Attractions SelectedAttraction { get; set; }
        public AttractionList Restaurants { get; set; }
        public AttractionList Events { get; set; }
        public AttractionList Culture { get; set; }
        public AttractionList Shopping { get; set; } 
        #endregion

        public MainViewModel()
        {
            GetLanguage();
            Restaurants = new AttractionList();
            Events = new AttractionList();
            Culture = new AttractionList();
            Shopping = new AttractionList();
            DetailPageInfo();
        }

        public void DetailPageInfo()
        {
            #region Attributter
            string restaurentJensensBøfhus;
            string restaurentBones;
            string restaurentCafeVivaldi;
            string restaurentMumm;

            string eventRoskildeFestival;
            string eventLysfest;
            string eventHavnen;
            string eventMusicon;

            string shoppingsRoTorv;
            string shoppingsRandomOmråde;
            string shoppingsWebShopping;
            string shoppingsSomething;

            string attractionVikingeSkibsMuseum;
            string attractionRoskildeDomkirke;
            string attractionEtGallery;
            string attractionSomeplace;
            #endregion
            #region Text Definer
            if (LanguageFromFile.Equals("Danish"))
            {
                //Danish
                #region Danish version
                restaurentJensensBøfhus = "123";
                restaurentBones = "234";
                restaurentCafeVivaldi = "345";
                restaurentMumm = "456";

                eventRoskildeFestival = "";
                eventLysfest = "";
                eventHavnen = "";
                eventMusicon = "";

                shoppingsRoTorv = "";
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
                #endregion
            }
            else if (LanguageFromFile.Equals("English"))
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
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
                #endregion
            }
            else if (LanguageFromFile.Equals("French"))
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
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
                #endregion
            }
            else if (LanguageFromFile.Equals("German"))
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
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
                #endregion
            }
            else if (LanguageFromFile.Equals("Russian"))
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
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
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
                shoppingsRandomOmråde = "";
                shoppingsWebShopping = "";
                shoppingsSomething = "";

                attractionVikingeSkibsMuseum = "";
                attractionRoskildeDomkirke = "";
                attractionEtGallery = "";
                attractionSomeplace = "";
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
            Events.AddAttraction("Roskilde Festival", eventRoskildeFestival, "/Assets/Events/Roskilde_Festival_Scene.jpg");
            Events.AddAttraction("Lysfest", eventLysfest, "/Assets/Events/LysFest_billede1.gif");
            Events.AddAttraction("Havnen", eventHavnen, "/Assets/Events/Havn_front.jpg");
            Events.AddAttraction("Musicon", eventMusicon, "/Assets/Events/Musicon_billede2.jpg");
            #endregion

            //Shopping areas for detailPage.
            #region Shoppings
            Shopping.AddAttraction("Ro's Torv", shoppingsRoTorv, "/Assets/Shops/shopping_billede2.jpg");
            Shopping.AddAttraction("Random Område", shoppingsRandomOmråde, "/Assets/Shops/koebmand_billede1.jpg");
            Shopping.AddAttraction("WebShopping", shoppingsWebShopping, "/Assets/Shops/Gaagade_billede2.gif");
            Shopping.AddAttraction("Something", shoppingsSomething, "/Assets/Shops/Trold_billede1.jpg");
            #endregion

            //Cultural areas for detailPage.
            #region Cultur
            Culture.AddAttraction("Vikinge Skibs Museum", attractionVikingeSkibsMuseum, "/Assets/Museum/viking_billede1.jpg");
            Culture.AddAttraction("Roskildes Domkirke", attractionRoskildeDomkirke, "/Assets/Museum/Domkirke_billede2.jpg");
            Culture.AddAttraction("Et random Galleri", attractionEtGallery, "/Assets/Museum/Galleri_billede2.jpg");
            Culture.AddAttraction("someplace", attractionSomeplace, "/Assets/Museum/Radhus_billede1.JPG");
            #endregion
        }

        public async void GetLanguage()
        {
            LanguageFromFile = await FileHandling.LoadLanguageAsync();
        }
    }
}