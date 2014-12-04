using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class MuseumList
    {
        public ObservableCollection<Museum> Museums = new ObservableCollection<Museum>();

        public void AddMuseums(string name, string telephone, string desc, string picture)
        {
            Museums.Add(new Museum(name, telephone, desc, picture));
        }
    }
}
