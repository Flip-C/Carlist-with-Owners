using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class carspecifications
    {
        #region members
        private double listenpreis;        
        private double berechneterPreis;
        private double servicelimit;
        private double lastservice;
        private double servicewarnung;
        private double baujahr;
        private double kilometerstand;
        #endregion

        #region constructor
        #endregion



        #region methods     
        


        public double CalculatePrice()
        {
            //Heutiges Jahr festlegen
            DateTime actual = DateTime.Now;
            int year = actual.Year;
            do
            {
                //Preis berechnen
                berechneterPreis = listenpreis - (year - (baujahr * 0.05)) * (kilometerstand * 0.01);
                return berechneterPreis;
                //AktuellerPreis = berechneterPreis;

            }
            while (berechneterPreis > 1000);                      
        }         


        public double CalculateService()
        {
            //Berechnet den Zeitpunkt bis zum nächsten Service
            //Service alle 20.000km 
            //lastservice = 0;
            //servicelimit = lastservice + 20000;
            //servicewarnung = servicelimit - kilometerstand;
            //return servicewarnung;

            return servicewarnung - kilometerstand % servicelimit;
        }
        #endregion

        #region properties
        public double Service { get; set; }
        public double AktuellerPreis { get; set; }
        #endregion
    }
}
