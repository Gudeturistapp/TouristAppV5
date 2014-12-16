using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    public class AttractionList
    {
        public ObservableCollection<Attractions> AttractionLists = new ObservableCollection<Attractions>();

        public void AddAttraction(string name, string description, string photo)
        {
            AttractionLists.Add(new Attractions(name, description, photo));
        }
    }
}
