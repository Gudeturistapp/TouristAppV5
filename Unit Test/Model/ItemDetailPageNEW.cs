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
        private static TextBlock _emailTextBlock = new TextBlock();

        public TextBlock EmailTextBlock
        {
            get { return _emailTextBlock; }
            set
            {
                _emailTextBlock = value;
                CheckTextBlock(value);
            }
        }

        public void CheckTextBlock(TextBlock awesometextblockgonewild)
        {
            if (!awesometextblockgonewild.Text.Contains("@"))
            {
                throw new ArgumentException("Please enter a valid email adress.");
            }
        }

        
    }
}
