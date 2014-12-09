using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class KulturList
    {
        public ObservableCollection<Kultur> Kultur = new ObservableCollection<Kultur>();

        public void AddKultur(string name, string telephone, string desc, string picture)
        {
            Kultur.Add(new Kultur(name, telephone, desc, picture));
        }
    }
}
