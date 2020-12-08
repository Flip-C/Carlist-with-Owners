using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Auto
    {
        #region members             
        private string _typ;
        private int _baujahr;
        private int _kilometerstand;
        private double _preis;//Liste
        private Person _besitzer;
        private double _berechneterPreis;//aktuell
        private int _servicewarnung;
        private int intdrive;

        private static int _serviceintervall;     
               
        #endregion

        #region constructor
        public Auto()
        {
        }

        public Auto(string typ, int baujahr, int kilometerstand, double preis, Person besitzer)
        {
            _typ = typ;
            _baujahr = baujahr;
            _kilometerstand = kilometerstand;
            _preis = preis;
            _besitzer = besitzer;            
        }
        #endregion



        #region methods   
        public string Print()
        {
            return _typ +" "+ _baujahr+" "+_kilometerstand+" "+_preis+" "+ _besitzer;
        }


        public double CalculatePrice()
        {
            //Heutiges Jahr festlegen
            DateTime actual = DateTime.Now;
            int year = actual.Year;

            _berechneterPreis = _preis - ((year - _baujahr) * 0.2) * (_kilometerstand * 0.1);

            return _berechneterPreis;          
        }

        public double  CalculateService()
        {
            //Berechnet den Zeitpunkt bis zum nächsten Service
            //Service alle 20.000km 
            //lastservice = 0;
            //servicelimit = lastservice + 20000;
            //servicewarnung = servicelimit - kilometerstand;
            //return servicewarnung;
            _serviceintervall = 20000;
            return _servicewarnung = _serviceintervall- _kilometerstand;
        }       

        public int Drive()
        {            
            Console.WriteLine("Wie viel ist er gefahren?");
            int.TryParse(Console.ReadLine(), out intdrive);

            _kilometerstand = _kilometerstand + intdrive;

            return _kilometerstand;
        }
        #endregion

        #region properties
        public string Typ { get;}
        public int Baujahr { get;}
        public int Kilometerstand { get; private set; }
        public double Preis { get;}
        public Person Besitzer { get; set;}        
        #endregion 
    }
}
