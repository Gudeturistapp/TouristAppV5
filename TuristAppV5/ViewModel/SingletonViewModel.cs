using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    class SingletonViewModel
    {
        private static SingletonViewModel instance;
        private ObservableCollection<Restaurant> restaurants;
        private ObservableCollection<Category> categories;

        public ObservableCollection<Restaurant> Restaurants
        {
            get { return restaurants; }
            set { restaurants = value; }
        }

        public ObservableCollection<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public SingletonViewModel()
        {
            categories = new ObservableCollection<Category>();
            Category category1 = new Category("Restaurants", "", "", "", "", "", "", "");
            Category category2 = new Category("Events", "", "", "", "", "", "", "");

            categories.Add(category1);
            categories.Add(category2);

            //Creation;

            Restaurant Jensens = new Restaurant("Jensens", "1234567", "Jensens", "");
            Restaurant Bones = new Restaurant("Bones", "1234567", "Bones", "");

            Event FedsteEvent = new Event("FedesteEvent", "1234567", "Bedste event evur", "");

            Categories[0].Restaurants.Add(Jensens);
            Categories[1].Events.Add(FedsteEvent);

            

        }

        public static SingletonViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonViewModel();
                }
                return instance;
            }
        }
    }
}
