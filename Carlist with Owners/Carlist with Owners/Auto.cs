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
        private string _baujahr;
        private string _kilometerstand;
        private string _preis;
        private string _besitzer;

        #endregion

        #region constructor
        public Auto(string typ, string baujahr, string kilometerstand, string preis, string besitzer)
        {
            _typ = typ;
            _baujahr = baujahr;
            _kilometerstand = kilometerstand;
            _preis = preis;
            _besitzer = besitzer;
        }

        public Auto()
        {
        }
        #endregion



        #region methods      
        public static void CreateNewCar()
        {            
            {
                Auto[] Autoarray = new Auto[1];
                
                for (int i = 0; i < 1; i ++)
                {
                    //Autoarray[i++] = new Auto();
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
        }



        public static void Output(Auto[]Autoarray)
        {
            for (int i = 1; i < Autoarray.GetLength(0); i++)
            {
               Console.WriteLine( Autoarray[i].SchreibeDaten());
            }       
                      
        }
        

        public string SchreibeDaten()
        {
            return Typ + Baujahr + Kilometerstand + Preis + Besitzer;            
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
