using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class AttractionList
    {
        public ObservableCollection<Attractions> AttractionLists = new ObservableCollection<Attractions>();

        public void AddAttraction(string name, string phone, string description, string photo, string price = null)
        {
            AttractionLists.Add(new Attractions(name, phone, description, photo, price));
        }

        public void AddAttractionItem(string name1, string photo1, string name2, string photo2, string name3,
            string photo3, string name4, string photo4)
        {
            AttractionLists.Add(new Attractions(name1, photo1, name2, photo2, name3, photo3, name4, photo4));
        }
    }
}
