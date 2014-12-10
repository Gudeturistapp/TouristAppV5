using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TuristAppV5.Model;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    class MainViewModel
    {
        //Properties + SelectedAttraction.
        #region Properties
        public static Attractions SelectedAttraction { get; set; }

        public AttractionList Restaurants { get; set; }
        public AttractionList Events { get; set; }
        public AttractionList Culture { get; set; }
        public AttractionList Shopping { get; set; } 
        #endregion

        public MainViewModel()
        {
            //Restaurants for detailPage.
            #region Restauranter
            Restaurants.AddAttraction("Jensens Bøfhus", "1111 2222", "Jensens bøfhus hvor du kan få bøffer.", "");
            Restaurants.AddAttraction("Bones", "2222 3333", "Bones hvor du kan få ribs.", "");
            Restaurants.AddAttraction("Danny's Køkken", "3333 4444", "Det bedste sted på planeten!", "");
            #endregion

            //Events for detailPage.
            #region Events
            Events.AddAttraction("Pølsens Åbenbaring", "6x3", "Det er hemmeligheden bag pølsen", "Assets/Eat/bones_logo.gif");
            Events.AddAttraction("Danny's omskæring", "666 666", "Navnet siger alt", "");
            Events.AddAttraction("Rasmus' Prædiken", "999 333 999", "Rasmus, højpræst i fapper troen", "");
            #endregion

            //Shopping areas for detailPage.
            #region Shoppings
            Shopping.AddAttraction("Ro's Torv", "1234 5678", "Men stor biograf, eller noget.", "");
            Shopping.AddAttraction("Et shoppings område andetsteds", "1234 8765", "En nice deskription", "");
            Shopping.AddAttraction("Internet Shopping, anyone?", "8765 4321", "En random deskription", "");
            #endregion

            //Cultural areas for detailPage.
            #region Kultur
            Culture.AddAttraction("Vikingeskibs Museum", "5555 0000", "Ser store og pragtige vikinge skibe", "");
            Culture.AddAttraction("Roskilde Domkirke", "En bøn til Gud", "Det er en kirke, og en stor en af slagsen", "");
            Culture.AddAttraction("Et Gallery", "Gallery nummer", "Gallery deskription", "");
            #endregion

            //Restaurants for itemsPage.
            Restaurants.AddAttractionItem("Jensen's Bøfhus", "", "Bones", "", "Vivaldis", "", "", "");


        }
    }
}