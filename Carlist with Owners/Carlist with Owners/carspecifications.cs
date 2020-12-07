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
                
        private double berechneterPreis;
        private double servicelimit;
        private double lastservice;
        private double servicewarnung;
        
        #endregion

        #region constructor
        #endregion

        #region properties
        public double Service { get; set; }
        public double AktuellerPreis { get; set; }

        #endregion

        #region methods     

        public void Wandeln()
        {
            listenpreis = (Baujahr);
        }

        
        public void CalculatePrice()
        {
            //Heutiges Jahr festlegen
            DateTime actual = DateTime.Now;
            int year = actual.Year;
            do
            {
                //Preis berechnen
                berechneterPreis = listenpreis - (year - (Baujahr * 0.05)) * (Kilometerstand * 0.01);
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
                servicewarnung = servicelimit - Kilometerstand;
            } while (servicewarnung>lastservice);          
                   
        }    

        public void ArrayDaten()
        {
            
        }
        #endregion
    }
}
