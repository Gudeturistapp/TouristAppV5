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

        


        //Selected - området.
        #region Selected
        public static Restaurant SelectedRestaurant { get; set; }

        public static Museum SelectedMuseum { get; set; }

        public static Shopping SelectedShopping { get; set; }

        public static Event SelectedEvent { get; set; }

        public static Category SelectedCategory { get; set; }
        #endregion

        public CategoryList Categories { get; set; }


        public RestaurantList Restaurants { get; set; }


        public MainViewModel()
        {
            Restaurants = new RestaurantList();
            Categories = new CategoryList();


            Restaurants.AddRestaurant("Bølles frue", "666", "Best fisk ever", "");

            

            Categories.AddRestaurantItem("Bølles mor", "Bølles far", "", "");



            Categories.AddEventItem("Fedeste event ever", "Dårligste event ever", "", "");


            


            

        }
    }
}