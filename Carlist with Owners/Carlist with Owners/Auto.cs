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
            return _typ + _baujahr + _kilometerstand + _besitzer;
        }


        public double CalculatePrice()
        {
            //Heutiges Jahr festlegen
            DateTime actual = DateTime.Now;
            int year = actual.Year;
            do
            {
                //Preis berechnen
                _berechneterPreis = _preis - (year - (_baujahr * 0.05)) * (_kilometerstand * 0.01);
                return _berechneterPreis;
                //AktuellerPreis = berechneterPreis;

            }
            while (_berechneterPreis > 1000);
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
            return _servicewarnung - _kilometerstand % _serviceintervall;//modolo berechnet den restwert
        }       

        //public string NewOwner(Person _newOwner)
        //{
            
        //}
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
