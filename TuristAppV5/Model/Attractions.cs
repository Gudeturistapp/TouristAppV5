using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    public class Attractions
    {
        #region Single Attraction properties + constructor
        


        public string _name { get; set; }
        public string _phone { get; set; }
        public string _description { get; set; }
        public string _photo { get; set; }

        public string _price { get; set; }

        public Attractions(string name, string phone, string description, string photo, string price = null)
        {
            _name = name;
            _phone = phone;
            _description = description;
            _photo = photo;
            _price = price;
        } 
        #endregion

       
    

        
    }
}
