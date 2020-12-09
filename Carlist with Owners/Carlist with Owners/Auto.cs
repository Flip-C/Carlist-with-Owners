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

        private const int _serviceintervall=50000;     //const können nie von iwas verändert werden!
               
        #endregion

        #region constructor
        public Auto()
        {
        }

        public Auto(string typ, int baujahr, int kilometerstand, double preis, Person besitzer)
        {
            Typ = typ;
            Baujahr = baujahr;
            _kilometerstand = kilometerstand;
            _preis = preis;
            _besitzer = besitzer;            
        }
        #endregion



        #region methods   
        public string Print()
        {
            return "Modell:"+Typ +" "+"Baujahr:"+ Baujahr+" "+"Kilometerstand:"+Kilometerstand+" "+"Preis:"+_preis+" "+"Besitzer: "+ _besitzer.ToString();
        }


        public double CalculatePrice()
        {
            //Heutiges Jahr festlegen            
            int year = DateTime.Now.Year;
            

            _berechneterPreis = _preis - ((year - _baujahr) * 0.2) * (_kilometerstand * 0.1);

            return _berechneterPreis;          
        }

        public double CalculateService()
        {
            //Berechnet den Zeitpunkt bis zum nächsten Service           
            return _servicewarnung = _serviceintervall % _kilometerstand;
        }       

        public int Drive()
        {            
            Console.WriteLine("Wie viel ist er gefahren?");
            int.TryParse(Console.ReadLine(), out intdrive);

            Kilometerstand = Kilometerstand + intdrive;

            return Kilometerstand;
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
