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
    public class Comments :INotifyPropertyChanged
    {
        private ObservableCollection<string> comment = new ObservableCollection<string>();

        public ObservableCollection<string> Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        //public void AddComments(string comment)
        //{
        //    Comment.Add(comment);
        //    OnPropertyChanged("Comments");
        //}

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
