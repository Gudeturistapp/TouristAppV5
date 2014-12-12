using System;
using System.Collections.Generic;
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

        public string name1 { get; set; }
        public string name2 { get; set; }
        public string name3 { get; set; }
        public string name4 { get; set; }

        public string photo1 { get; set; }

        public string photo2 { get; set; }

        public string photo3 { get; set; }
        
        public string photo4 { get; set; }

        public Attractions(string name1, string photo1, string name2, string photo2, string name3, string photo3,
            string name4, string photo4)
        {
            this.name1 = name1;
            this.photo1 = photo1;
            this.name2 = name2;
            this.photo2 = photo2;
            this.name3 = name3;
            this.photo3 = photo3;
            this.name4 = name4;
            this.photo4 = photo4;
        }
    

        
    }
}
