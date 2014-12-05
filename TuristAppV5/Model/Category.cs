using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class Category
    {
        public string photo1 { get; set; }

        public string photo2 { get; set; }

        public string photo3 { get; set; }

        public string photo4 { get; set; }

        public string name1 { get; set; }

        public string name2 { get; set; }

        public string name3 { get; set; }

        public string name4 { get; set; }


        public Category(string name1, string name2, string photo1, string photo2, string name3, string name4,
            string photo3, string photo4)
        {
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.name4 = name4;
            this.photo1 = photo1;
            this.photo2 = photo2;
            this.photo3 = photo3;
            this.photo4 = photo4;
        }
    }
}
