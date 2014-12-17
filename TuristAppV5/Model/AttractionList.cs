using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristAppV5.Annotations;

namespace TuristAppV5.Model
{
    public class AttractionList :INotifyPropertyChanged
    {
        public ObservableCollection<Attractions> AttractionLists  = new ObservableCollection<Attractions>();

        public void AddAttraction(string name, string description, string photo)
        {
            AttractionLists.Add(new Attractions(name, description, photo));
            OnPropertyChanged();
        }


        #region PC

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
