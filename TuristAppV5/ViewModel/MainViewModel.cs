using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TuristAppV5.Model;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    public class MainViewModel
    {
        //Properties + SelectedAttraction.
        #region Properties
        public static Attractions SelectedAttraction { get; set; }

        public AttractionList Restaurants { get; set; }
        public AttractionList Events { get; set; }
        public AttractionList Culture { get; set; }
        public AttractionList Shopping { get; set; } 
        #endregion

        public MainViewModel()
        {
            Restaurants = new AttractionList();
            Events = new AttractionList();
            Culture = new AttractionList();
            Shopping = new AttractionList();

            //Ipsum
            #region Ipsum
            string ipsum = "Mauris pellentesque auctor malesuada. Nulla hendrerit sodales ipsum, eu aliquet sapien. Mauris cursus lorem sit amet augue dignissim, ut placerat sapien tristique. In hac habitasse platea dictumst. Cras ut auctor nisi, sit amet dapibus nibh. Aliquam congue, dui a viverra faucibus, justo magna convallis mi, nec dapibus velit est rhoncus quam. Nullam id tristique ex. Nunc ultrices interdum consectetur. Mauris felis risus, ornare non purus id, vehicula ullamcorper eros. Ut efficitur, elit vitae imperdiet dictum, sem eros elementum tortor, eget rhoncus erat eros nec nisi. Integer mollis ipsum est, vitae lobortis est consectetur sit amet. Curabitur lobortis gravida congue. Quisque gravida lorem et suscipit congue. Proin pretium ex elit, quis rhoncus lorem laoreet sit amet. Praesent fermentum suscipit consectetur.";

            #endregion

            //Restaurants for detailPage.
            #region Restauranter
            Restaurants.AddAttraction("Jensens Bøfhus", "1111 2222", ipsum, "/Assets/Eat/Jensens_Steak2.jpg");
            Restaurants.AddAttraction("Bones", "2222 3333", ipsum, "/Assets/Eat/bones_steak.jpg");
            Restaurants.AddAttraction("Café Vivaldi", "3333 4444", ipsum, "/Assets/Eat/Vivaldi_Steak2.jpg");
            Restaurants.AddAttraction("Mumm", "666, 666, 666", ipsum, "/Assets/Eat/Mumm_billede1.jpg");
            #endregion

            //Events for detailPage.
            #region Events
            Events.AddAttraction("Roskilde Festival", "6x3", ipsum, "/Assets/Events/Roskilde_Festival_Scene.jpg");
            Events.AddAttraction("Lysfest", "666 666", ipsum, "/Assets/Events/LysFest_billede1.gif");
            Events.AddAttraction("Havnen", "999 333 999", ipsum, "/Assets/Events/Havn_front.jpg");
            Events.AddAttraction("Musicon", "88888888", ipsum, "/Assets/Events/Musicon_billede2.jpg");
            #endregion

            //Shopping areas for detailPage.
            #region Shoppings
            Shopping.AddAttraction("Ro's Torv", "1234 5678", ipsum, "/Assets/Shops/shopping_billede2.jpg");
            Shopping.AddAttraction("Brødrene Lutshøft's Efterfølgere", "1234 8765", ipsum, "/Assets/Shops/koebmand_billede1.jpg");
            Shopping.AddAttraction("Gågaden", "8765 4321", ipsum, "/Assets/Shops/Gaagade_billede2.gif");
            Shopping.AddAttraction("Bjergtrolden", "12345678", ipsum, "/Assets/Shops/Trold_billede1.jpg");
            #endregion

            //Cultural areas for detailPage.
            #region Kultur
            Culture.AddAttraction("Vikingeskibs Museum", "5555 0000", ipsum, "/Assets/Museum/viking_billede1.jpg");
            Culture.AddAttraction("Roskilde Domkirke", "123", ipsum, "/Assets/Museum/Domkirke_billede2.jpg");
            Culture.AddAttraction("Galleri LABR", "321", ipsum, "/Assets/Museum/Galleri_billede2.jpg");
            Culture.AddAttraction("Rådhuset", "12345678", ipsum, "/Assets/Museum/Radhus_billede1.JPG");
            #endregion


            


        }
    }
}