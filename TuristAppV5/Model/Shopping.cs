using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class Shopping
    {
        public string _name { get; set; }

        public string _telephone { get; set; }

        public string _desc { get; set; }

        public string _picture { get; set; }

        public Shopping(string name, string telephone, string desc, string picture)
        {
            _name = name;
            _telephone = telephone;
            _desc = desc;
            _picture = picture;
        }

        public override string ToString()
        {
            return string.Format("_name: {0}, _telephone: {1}, _desc: {2}, _picture: {3}", _name, _telephone, _desc, _picture);
        }
    }
}
