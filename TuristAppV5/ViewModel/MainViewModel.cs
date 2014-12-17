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
        public static Comments SelectedComments { get; set; }
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
            string shoppingskoebmand = @"";
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

                restaurentJensensBøfhus = @"Jensens Bøfhus er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Jensens Bøfhus har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentBones = @"Restauranten Bones er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Bones har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentCafeVivaldi = @"Café Vivaldi er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Vivaldi har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentMumm = @"Restauranten Mumm er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Mumm har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";

                eventRoskildeFestival = @"Roskilde Festivalen er en af de største seværdigheder i Roskilde, og tiltrækker flere tusinder af mennesker til byen hvert år for denne
fantastiske begivenhed, Roskilde Festival er en udenfor, 'leve i et telt' oplevelse, hvor du har det sjovt på en ny måde med alle dine venner, mens du nyder de mange musik-muligheder, de tilbyder hvert år.";
                eventLysfest = @" Lys Fest begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";
                eventHavnen = @"Havne begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";
                eventMusicon = @"Musicon begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";

                shoppingsRoTorv = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Ro's Torv tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingsGaaGade = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Roskilde Gågade tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingskoebmand = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Den gamle Købmand tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingsBjergtrold = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Bjergtrolden tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";

                attractionVikingeSkibsMuseum = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Vikingsskibs museumm er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionRoskildeDomkirke = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Roskilde Domkirke er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionEtGallery = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Roskilde Galleri er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionRaadhus = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Det gamle rådhus er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";

                #endregion
                }
                else if (language == 2)
            {
                //English

                #region English version

                restaurentJensensBøfhus = @"the restaurant Jensens Bøfhus is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Jensens Bøfhus have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 29432313

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentBones = @" the restaurant Bones is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Bones have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 22445566

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentCafeVivaldi = @"the Café Vivaldi is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Vivaldi have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 43864397

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentMumm = @"the restaurant Mumm is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Mumm have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 23154673

and they are opened:
mon-fri 17-22
sat-sun 17-23";

                eventRoskildeFestival = @"The Roskilde Festival are one of the biggest attractions in Roskilde, and attract several thousands of people to the city every year for this
amazing event, Roskilde Festival is a outside, 'living in a tent' experience where you have fun in a new way with all your friends, while you enjoy the many music options they offer every year.";
                eventLysfest = @"the Light Fest offers you as a visitor durig this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";
                eventHavnen = @"the Roskilde docks offers you as a visitor durig this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";
                eventMusicon = @"the Musicon event offers you as a visitor durig this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";

                shoppingsRoTorv = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then Ro's Torv is the perfect place to do so! Ro's Torv Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingsGaaGade = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then the Roskilde GaaGade is the perfect place to do so! Roskilde Gaagade Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingskoebmand = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then the Old Merchant is the perfect place to do so! the Old Merchant Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingsBjergtrold = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then BjergTrolden is the perfect place to do so! BjergTrolden Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";

                attractionVikingeSkibsMuseum = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! the Viking ship museum is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionRoskildeDomkirke = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! Roskilde Domkirke is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionEtGallery = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! Roskilde Gallery is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionRaadhus = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! The old Town Hall is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";

                #endregion
            }
          else if (language == 3)
            {
                //French

                #region French version

                restaurentJensensBøfhus = @"";
                restaurentBones = @"";
                restaurentCafeVivaldi = @"";
                restaurentMumm = @"";

                eventRoskildeFestival = @"";
                eventLysfest = @"";
                eventHavnen = @"";
                eventMusicon = @"";

                shoppingsRoTorv = @"";
                shoppingsGaaGade = @"";
                shoppingskoebmand = @"";
                shoppingsBjergtrold = @"";

                attractionVikingeSkibsMuseum = @"";
                attractionRoskildeDomkirke = @"";
                attractionEtGallery = @"";
                attractionRaadhus = @"";

                #endregion
            }
          else if (language == 4)
            {
                //German

                #region German version

                restaurentJensensBøfhus = @"";
                restaurentBones = @"";
                restaurentCafeVivaldi = @"";
                restaurentMumm = @"";

                eventRoskildeFestival = @"";
                eventLysfest = @"";
                eventHavnen = @"";
                eventMusicon = @"";

                shoppingsRoTorv = @"";
                shoppingsGaaGade = @"";
                shoppingskoebmand = @"";
                shoppingsBjergtrold = @"";

                attractionVikingeSkibsMuseum = @"";
                attractionRoskildeDomkirke = @"";
                attractionEtGallery = @"";
                attractionRaadhus = @"";

                #endregion
            }
           else if (language == 5)
            {
                //Russian

                #region Russian version

                restaurentJensensBøfhus = @"";
                restaurentBones = @"";
                restaurentCafeVivaldi = @"";
                restaurentMumm = @"";

                eventRoskildeFestival = @"";
                eventLysfest = @"";
                eventHavnen = @"";
                eventMusicon = @"";

                shoppingsRoTorv = @"";
                shoppingsGaaGade = @"";
                shoppingskoebmand = @"";
                shoppingsBjergtrold = @"";

                attractionVikingeSkibsMuseum = @"";
                attractionRoskildeDomkirke = @"";
                attractionEtGallery = @"";
                attractionRaadhus = @"";

                #endregion
            }
           else
            {
                //Spanish

                #region Spanish version

                restaurentJensensBøfhus = @"";
                restaurentBones = @"";
                restaurentCafeVivaldi = @"";
                restaurentMumm = @"";

                eventRoskildeFestival = @"";
                eventLysfest = @"";
                eventHavnen = @"";
                eventMusicon = @"";

                shoppingsRoTorv = @"";
                shoppingsGaaGade = @"";
                shoppingskoebmand = @"";
                shoppingsBjergtrold = @"";

                attractionVikingeSkibsMuseum = @"";
                attractionRoskildeDomkirke = @"";
                attractionEtGallery = @"";
                attractionRaadhus = @"";

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
            Shopping.AddAttraction("WebShopping", shoppingskoebmand, "/Assets/Shops/Gaagade_billede2.gif");
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
            Restaurants.AttractionLists[0].AddComment("Fantastisk hyggeligt sted");
            Restaurants.AttractionLists[0].AddComment("wow det var godt nok en god bøf");
            Restaurants.AttractionLists[0].AddComment("Lidt for mange børn til min smag");
            Restaurants.AttractionLists[0].AddComment("en rigtig god kombination af det hele");
            Restaurants.AttractionLists[1].AddComment("hold da op de laver god mad");
            Restaurants.AttractionLists[1].AddComment("alt for mange mennesker!");
            Restaurants.AttractionLists[1].AddComment("håber de for gjort noget ved interiøret snart");
            Restaurants.AttractionLists[1].AddComment("fantastisk god service");
            Restaurants.AttractionLists[2].AddComment("service niveauet et helt i top!");
            Restaurants.AttractionLists[2].AddComment("super god mad, lidt for meget larm");
            Restaurants.AttractionLists[2].AddComment("alt for lang ventetid..");
            Restaurants.AttractionLists[2].AddComment("de burde seriøst få gjort noget ved de servitricer!");
            Restaurants.AttractionLists[3].AddComment("hold kæft nogle lækre servitricer");
            Restaurants.AttractionLists[3].AddComment("dårlig mad...");
            Restaurants.AttractionLists[3].AddComment("lækker mad!!");
            Restaurants.AttractionLists[3].AddComment("ikke noget for mig");

            Shopping.AttractionLists[0].AddComment("Ej et fedt sted! fik bare alt jeg skulle bruge");
            Shopping.AttractionLists[0].AddComment("fandt ikke en skid..");
            Shopping.AttractionLists[0].AddComment("alt for mange mennesker");
            Shopping.AttractionLists[0].AddComment("service disken er til grin!");
            Shopping.AttractionLists[1].AddComment("ej et hyggeligt sted :-)");
            Shopping.AttractionLists[1].AddComment("Waow virkelig godt indrettet!");
            Shopping.AttractionLists[1].AddComment("fandt intet brugbart her...");
            Shopping.AttractionLists[1].AddComment("fantastisk godt miljø");
            Shopping.AttractionLists[2].AddComment("super glade mennesker her");
            Shopping.AttractionLists[2].AddComment("folk virker ikke så stresset her");
            Shopping.AttractionLists[2].AddComment("HVORFOR KAN JEG ALDRIG FINDE NOGET HER??");
            Shopping.AttractionLists[2].AddComment("på tur med svigermor... super hyggeligt");
            Shopping.AttractionLists[3].AddComment("ej et dejligt sted");
            Shopping.AttractionLists[3].AddComment("virkelig dårligt indrettet");
            Shopping.AttractionLists[3].AddComment("flotte farver de har valgt her, smukke butikker");
            Shopping.AttractionLists[3].AddComment("god service!!");

            Culture.AttractionLists[0].AddComment("waow det var godt nok fantastisk");
            Culture.AttractionLists[0].AddComment("en helt anden oplevelse end jeg havde regnet med");
            Culture.AttractionLists[0].AddComment("hold da op det var kedeligt...");
            Culture.AttractionLists[0].AddComment("fedeste sted nogensinde!!");
            Culture.AttractionLists[1].AddComment("hold da op for en fed oplevelse!");
            Culture.AttractionLists[1].AddComment("waow de havde mange flotte ting");
            Culture.AttractionLists[1].AddComment("helt sikkert et sted jeg skal hen igen");
            Culture.AttractionLists[1].AddComment("synes det var lidt kedeligt..");
            Culture.AttractionLists[2].AddComment("hold da mauvle for nogle flotte ting de har");
            Culture.AttractionLists[2].AddComment("jeg kunne virkelig godt lide deres indretning");
            Culture.AttractionLists[2].AddComment("lidt kedeligt..");
            Culture.AttractionLists[2].AddComment("helt sikkert et sted jeg skal hen igen.");
            Culture.AttractionLists[3].AddComment("god i'm bored");
            Culture.AttractionLists[3].AddComment("helt sikkert! skal helt sikkert herhen igen");
            Culture.AttractionLists[3].AddComment("virkelig flot udstilling");
            Culture.AttractionLists[3].AddComment("ikke lige mig, men virkelig flot..");

            Events.AttractionLists[0].AddComment("JEG ER FUUUULD");
            Events.AttractionLists[0].AddComment("WHAAAHHAAA NEEEXT YEAARRR");
            Events.AttractionLists[0].AddComment("kedeligt....");
            Events.AttractionLists[0].AddComment("dårligt setup i år");
            Events.AttractionLists[1].AddComment("noget helt andet end jeg lige havde forventet");
            Events.AttractionLists[1].AddComment("hoold da op hvor var det flot");
            Events.AttractionLists[1].AddComment("helt sikkert noget vi skal igen");
            Events.AttractionLists[1].AddComment("hele familien elskede det!");
            Events.AttractionLists[2].AddComment("utrolig flot, helt sikkert");
            Events.AttractionLists[2].AddComment("fantastisk oplevelse");
            Events.AttractionLists[2].AddComment("lidt kedeligt i forhold til sidste år");
            Events.AttractionLists[2].AddComment("glæder mig til næste år allerede!");
            Events.AttractionLists[3].AddComment("ej hvor var det fedt!!");
            Events.AttractionLists[3].AddComment("familien og jeg skal helt sikkert besøge roskilde igen næste år");
            Events.AttractionLists[3].AddComment("godt nok kedeligt...");
            Events.AttractionLists[3].AddComment("fantastisk oplevelse!!");
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