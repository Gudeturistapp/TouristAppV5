using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class RestaurantList
    {

        public ObservableCollection<Restaurant> Restaurant = new ObservableCollection<Restaurant>();

        public void AddRestaurant(string name, string telephone, string desc, string picture)
        {
            Restaurant.Add(new Restaurant(name, telephone, desc, picture));
        }
    }
}
