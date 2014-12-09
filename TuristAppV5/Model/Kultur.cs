using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class Kultur
    {
        public string _name { get; set; }

        public string _telephone { get; set; }

        public string _description { get; set; }

        public string _picture { get; set; }

        public Kultur(string name, string telephone, string description, string picture)
        {
            _name = name;
            _telephone = telephone;
            _description = description;
            _picture = picture;
        }

        public override string ToString()
        {
            return string.Format("_name: {0}, _telephone: {1}, _picture: {2}, _description: {3}", _name, _telephone, _picture, _description);
        }
    }
}
