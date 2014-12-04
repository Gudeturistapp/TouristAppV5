using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class ShoppingList
    {
        ObservableCollection<Shopping> Shoppings = new ObservableCollection<Shopping>();

        public void AddShopping(string name, string telephone, string desc, string photo)
        {
            Shoppings.Add(new Shopping(name, telephone, desc, photo));
        }
    }
}
