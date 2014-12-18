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
        public string _description { get; set; }
        public string _photo { get; set; }

        public Attractions(string name, string description, string photo)
        {
            _name = name;
            _description = description;
            _photo = photo;
        } 
        #endregion

       
    

        
    }
}
