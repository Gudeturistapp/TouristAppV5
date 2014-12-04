using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class EventList
    {
        ObservableCollection<Event> Events = new ObservableCollection<Event>();

        public void AddEvents(string name, string telephone, string desc, string picture)
        {
            Events.Add(new Event(name, telephone, desc, picture));
        }
    }
}
