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
    public class Attractions: INotifyPropertyChanged
    {
        #region Single Attraction properties + constructor
        public Comments comments = new Comments();


        public string _name { get; set; }
        public string _description { get; set; }
        public string _photo { get; set; }

        public Attractions(string name, string description, string photo)
        {
            _name = name;
            _description = description;
            _photo = photo;
        } 
        #endregion

        public void AddComment(string comment)
        {
            comments.Comment.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("_name: {0}", _name);
        }

        #region PropertyChanged
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
