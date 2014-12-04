using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    class MainViewModel
    {

        RestaurantList Restaurants = new RestaurantList();
        MuseumList Museums = new MuseumList();


        //Selected - området.
        #region Selected
        public static Restaurant SelectedRestaurant { get; set; }

        public static Museum SelectedMuseum { get; set; }

        public static Shopping SelectedShopping { get; set; }

        public static Event SelectedEvent { get; set; } 
        #endregion

        //Listerne:
        #region Lists


        public List<Shopping> Shoppings = new List<Shopping>();

        public List<Event> Events = new List<Event>();  
        #endregion

        public MainViewModel()
        {
            Restaurants.AddRestaurent("Bølles frue", "666", "Best fisk ever", "");
        }
    }
}