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
        double listenpreis;
        double momentanpreisY;//Years
        double momentanpreisK;//Kilometer
        double alterdesAutos; //Anzahl Jahre nach Kauf
        double baujahr;
        double kilometerstand;//beim anlegen der Liste
        double fahrtenbuch;//neue Kilometer
        double servicelimit;
        double servicewarnung;
        #endregion

        #region constructor
        #endregion

        #region properties
        public int Listenpreis { get; set; }
        public int Kaufpreis { get; set; }
        public int Baujahr { get; set; }
        public int Kilometerstand { get; set; }
        #endregion

        #region methods
        public void PriceCalculatorY()
        {
            //Berechnet den Preis des Fahrzeugs
            if (momentanpreisY>2000)
            {
                momentanpreisY = listenpreis * alterdesAutos*0.05; //Faktor Wertverlust pro Jahr ca 0.05% + Kilometerlaufleistung 


            }
            else if(momentanpreisY<2000)
            {
                Console.WriteLine("Der Wert des Fahrzeugs liegt unter 2000€. Fahren Sie weiter bis der Rost euch scheidet");
            }
        }



        public void PriceCalculatorK()
        {
            //Berechnet den Preis des Fahrzeugs anhand der Kilometer
            if (momentanpreisK > 2000)
            {
                momentanpreisK = listenpreis * kilometerstand * 0.01;
            }
            else if (momentanpreisK < 2000)
            {
                Console.WriteLine("Der Wert des Fahrzeugs liegt unter 2000€. Fahren Sie weiter bis der Rost euch scheidet");
            }
        }


        public void ServiceCalculator()
        {
            //Berechnet den Zeitpunkt bis zum nächsten Service
            //Service alle 20.000km oder alle 2 Jahre
            servicelimit = //50000;70000;90000;
            servicewarnung = servicelimit - kilometerstand;
            
            


        }

        public void NewCar()
        {
            Console.WriteLine("Bitte geben Sie die Fahrzeugdaten ein");
            Console.WriteLine("Besitzer eingeben");
            string owner = Console.ReadLine();

            Console.WriteLine("Marke eingeben");
            string modell = Console.ReadLine();

            Console.WriteLine("Baujahr eingeben");
            baujahr = double.Parse(Console.ReadLine());

            Console.WriteLine("Listenpreis eingeben");
            listenpreis = double.Parse(Console.ReadLine());

            Console.WriteLine("Aktueller Kilometerstand angeben");
            kilometerstand = double.Parse(Console.ReadLine());
        }               
        #endregion
    }
}
