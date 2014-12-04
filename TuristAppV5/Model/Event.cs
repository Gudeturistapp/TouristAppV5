using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV5.Model
{
    class Event
    {
        public string name { get; set; }

        public string telephone { get; set; }

        public string desc { get; set; }

        public string picture { get; set; }

        public Event(string name, string telephone, string desc, string picture)
        {
            this.name = name;
            this.telephone = telephone;
            this.desc = desc;
            this.picture = picture;
        }

        public override string ToString()
        {
            return string.Format("name: {0}, picture: {1}, telephone: {2}, desc: {3}", name, picture, telephone, desc);
        }
    }
}
