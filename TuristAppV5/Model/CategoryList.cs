using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace TuristAppV5.Model
{
    class CategoryList
    {
        public ObservableCollection<Category> Restaurant = new ObservableCollection<Category>();

        public ObservableCollection<Category> Event = new ObservableCollection<Category>(); 



        public void AddRestaurantItem(string name1, string name2, string photo1, string photo2, string name3="", string name4="", string photo3="", string photo4="")
        {
            Restaurant.Add(new Category(name1,name2, photo1, photo2, name3, photo3, name4, photo4));
        }

        public void AddEventItem(string name1, string name2, string photo1, string photo2, string name3="", string photo3="", string name4="", string photo4="")
        {
            Event.Add(new Category(name1, name2, photo1, photo2, name3, name4, photo3, photo4));
        }


    }
}
