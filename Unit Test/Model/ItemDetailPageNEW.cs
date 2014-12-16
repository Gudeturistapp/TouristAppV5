using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Unit_Test.Model
{
    class ItemDetailPageNew
    {

        private string EmailTextbox = "";

        public string EmailTextbox1
        {
            get { return EmailTextbox; }
            set
            {
                CheckTextBlock(value);
                EmailTextbox = value;
            }
        }

        

        



        public void CheckTextBlock(string awesometextblockgonewild)
        {
            if (!awesometextblockgonewild.Contains("@"))
            {
                throw new ArgumentException("Please enter a valid email adress.");
            }
        }

        
    }
}
