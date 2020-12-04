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
        int listenpreis;
        int momentanpreis;
        int anzahlJahrenK; //Anzahl Jahre nach Kauf
        int baujahr;
        int kilometeranzahl;

        #endregion

        #region constructor
        #endregion

        #region properties
        public int Listenpreis { get; set; }
        public int Kaufpreis { get; set; }
        public int Baujahr { get; set; }
        public int Kilometeranzahl { get; set; }
        #endregion

        #region methods
        public void PriceCalculator()
        {
            //Berechnet den Preis des Fahrzeugs
            if (momentanpreis>2000)
            {
                momentanpreis = listenpreis * anzahlJahrenK; //Faktor Wertverlust pro Jahr ca 0.05% + Kilometerlaufleistung 


            }
        }

        public void ServiceCalculator()
        {
            //Berechnet den Zeitpunkt bis zum nächsten Service
            //Service alle 10.000km oder alle 2 Jahre
            int servicewarnung;
            servicewarnung = servicelimit - kilometeranzahl;
            //for jeden Serviceeintrag i + 10000km
            //neues Servicelimit - Kilometeranzahl


        }
        



        #endregion
    }
}
