using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    class MainViewModel
    {
        //Selected - området..
        #region Selected
        public static Restaurant SelectedRestaurant { get; set; }

        public static Kultur SelectedKultur { get; set; }

        public static Shopping SelectedShopping { get; set; }

        public static Event SelectedEvent { get; set; }

        public static Category SelectedCategory { get; set; }
        #endregion

        public CategoryList Categories { get; set; }

        public RestaurantList Restaurants { get; set; }

        public EventList Events { get; set; }

        public ShoppingList Shoppings { get; set; }

        public KulturList Kultur { get; set; }

        public EventList Events { get; set; }

        public MainViewModel()
        {
            Restaurants = new RestaurantList();
<<<<<<< HEAD
            Events = new EventList();
            Shoppings = new ShoppingList();
            Kultur = new KulturList();
=======
            Categories = new CategoryList();
            Events = new EventList();

            Events.AddEvents("Kaj's liv", "666", "BEDSTE EVENT I VERDENEN", "");

>>>>>>> origin/Danny

            Categories = new CategoryList();

            //De forskellige restauranter.
            #region Restauranter
            Restaurants.AddRestaurant("Jensens Bøfhus", "1111 2222", "Jensens bøfhus hvor du kan få bøffer.", "");
            Restaurants.AddRestaurant("Bones", "2222 3333", "Bones hvor du kan få ribs.", "");
            Restaurants.AddRestaurant("Danny's Køkken", "3333 4444", "Det bedste sted på planeten!", ""); 
            #endregion
            
            //De forskellige Events.
            #region Events
            Events.AddEvents("Pølsens Åbenbaring", "6x3", "Det er hemmeligheden bag pølsen", "");
            Events.AddEvents("Danny's omskæring", "666 666", "Navnet siger alt", "");
            Events.AddEvents("Rasmus' Prædiken", "999 333 999", "Rasmus, højpræst i fapper troen", "");
            #endregion

            //De forskellige Shopping områder.
            #region Shoppings
            Shoppings.AddShopping("Ro's Torv", "1234 5678", "Men stor biograf, eller noget.", "");
            Shoppings.AddShopping("Et shoppings område andetsteds","1234 8765","En nice deskription","");
            Shoppings.AddShopping("Internet Shopping, anyone?","8765 4321","En random deskription","");
            #endregion

            //De forskellige Kulturelle områder.
            #region Kultur
            Kultur.AddKultur("Vikingeskibs Museum", "5555 0000", "Ser store og pragtige vikinge skibe", "");
            Kultur.AddKultur("Roskilde Domkirke", "En bøn til Gud", "Det er en kirke, og en stor en af slagsen", "");
            Kultur.AddKultur("Et Gallery", "Gallery nummer", "Gallery deskription", "");
            #endregion


            Categories.AddRestaurantItem("Bølles mor", "Bølles far", "", "");

            Categories.AddEventItem("Fedeste event ever", "Dårligste event ever", "", "");
<<<<<<< HEAD
=======

            
            


            

>>>>>>> origin/Danny
        }
    }
}