using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Model;
using TuristAppV5.View;

namespace TuristAppV5.ViewModel
{
    internal class SingletonViewModel
    {
        private static SingletonViewModel instance;
        private ObservableCollection<Attractions> _AttractionPage;

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

        public ObservableCollection<Attractions> AttractionPage
        {
            get { return _AttractionPage; }
            set { _AttractionPage = value; }
        }

        public SingletonViewModel()
        {
            _AttractionPage = new ObservableCollection<Attractions>();
            Attractions Rest1 = new Attractions("", "", "")
            {
                _description = "Dette er en fantastisk god Restaurant",
                _name = "Jensens Bøfhus",
                _photo = "placeholder",
             };
            Attractions Event1 = new Attractions("", "", "")
            {
                _description = "Dette er det flotteste event nogensinde",
                _name = "Roskilde Festival",
                _photo = "placeholder",
            };
            Attractions Culture1 = new Attractions("", "", "")
            {
                _description = "Dette er det flotteste Museum nogensinde",
                _name = "Roskilde Museum",
                _photo = "placeholder",
            };
            Attractions Shop1 = new Attractions("", "", "")
            {
                _description = "Dette er det flotteste indkøbscenter nogensinde",
                _name = "Ro's Torv",
                _photo = "placeholder",
            };

            _AttractionPage.Add((Rest1));
            _AttractionPage.Add((Event1));
            _AttractionPage.Add((Culture1));
            _AttractionPage.Add((Shop1));
        }
    }
}
