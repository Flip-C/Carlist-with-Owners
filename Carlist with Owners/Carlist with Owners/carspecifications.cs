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
        public void Convert()//Wandelt die Zahlendaten in double, um sie in carspecifications zu berechnen 
        {
            double dbaujahr = double.Parse(Baujahr);
            double dkilometer = double.Parse(Kilometerstand);
            double dpreis = double.Parse(Preis);
        }


        public void CalculatePrice()
        {
            //Heutiges Jahr festlegen
            DateTime actual = DateTime.Now;
            int year = actual.Year;
            do
            {
                //Preis berechnen
                berechneterPreis = listenpreis - (year - (baujahr * 0.05)) * (kilometerstand * 0.01);
                AktuellerPreis = berechneterPreis;
                return;
            }
            while (berechneterPreis > 1000);                      
        }         


        public void CalculateService()
        {          
            do
            {
                //Berechnet den Zeitpunkt bis zum nächsten Service
                //Service alle 20.000km 
                lastservice = 0;
                
                servicelimit = lastservice + 20000;
                servicewarnung = servicelimit - kilometerstand;
            } while (servicewarnung>lastservice);          
                   
        }
        #endregion

        #region properties
        public double Service { get; set; }
        public double AktuellerPreis { get; set; }
        #endregion
    }
}
