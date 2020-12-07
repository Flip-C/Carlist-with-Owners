using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    public class Auto
    {
        #region members             
        double baujahr;
        double kilometerstand;
        double preis;
        #endregion

        #region constructor
        public Auto(string typ, string baujahr, string kilometerstand, string preis, string besitzer)
        {
            Typ = typ;
            Baujahr = baujahr;
            Kilometerstand = kilometerstand;
            Preis = preis;
            Besitzer = besitzer;
        }

        public Auto()
        {
        }
        #endregion



        #region methods      
        public void CreateNewCar()
        {
            Auto[] Autoarray = new Auto[1];
            for (int i = 0; i < 1; i++)
            {
                Autoarray[i] = new Auto();
                
                Console.WriteLine("Typ Eingeben");
                string typ = Console.ReadLine();

                Console.WriteLine("Baujahr eingeben");
                string baujahr = Console.ReadLine();

                Console.WriteLine("Kilometerstand eingeben");
                string kilometerstand = Console.ReadLine();

                Console.WriteLine("Preis eingeben");
                string preis = Console.ReadLine();

                Console.WriteLine("Besitzer eingeben");
                string besitzer = Console.ReadLine();

                Autoarray[i] = new Auto(typ, baujahr, kilometerstand, preis, besitzer);
            }
            Output(Autoarray);
        }

        static void Output(Auto[]Autoarray)
        {
            for (int i = 0; i < Autoarray.GetLength(0); i++)
            {
                Console.WriteLine(Autoarray[i].SchreibeDaten());
            }
        }
        

        public string SchreibeDaten()
        {
            return Typ + Baujahr + Kilometerstand + Preis + Besitzer;            
        }    

        public void Convert()//Wandelt die Zahlendaten in double um sie in carspecifications zu berechnen 
        {
            double dbaujahr= double.Parse(Baujahr);
            double dkilometer = double.Parse(Kilometerstand);
            double dpreis = double.Parse(Preis);           
        }
        #endregion

        #region properties
        public string Typ { get; set; }
        public string Baujahr { get; set; }
        public string Kilometerstand { get; set; }
        public string Preis { get; set; }
        public string Besitzer { get; set; }
        #endregion 
    }
}
