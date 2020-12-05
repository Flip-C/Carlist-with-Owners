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
        public string Typ { get; set; }
        public double Baujahr { get;}
        public double Alter { get; }
        public double Kilometerstand { get; set; }
        public double Preis { get; set; }
        public double MomentanPreis { get; set; }
        #endregion

        #region constructor
        #endregion

        #region methods
        public string CreateNewCar()
        {
            Console.WriteLine("Typ Eingeben");
            Audi.Typ = Console.ReadLine();
            
            Console.WriteLine("Baujahr eingeben");
            car.Baujahr = double.Parse(Console.ReadLine());

            Console.WriteLine("Kilometerstand eingeben");
            car.Kilometerstand = double.Parse(Console.ReadLine());

            Console.WriteLine("Preis eingeben");
            car.Preis = double.Parse(Console.ReadLine());

            return
        }

        public void CalclualtePrice()
        {
            if(MomentanPreis>2000)
            {
                Alter = 2020 - Baujahr;
                MomentanPreis =// Preis - (Kilometeranzahl*0,01)-(Alter*0,05)
            }
            
        }


        public void SchreibeDaten()
        {
            Console.WriteLine("Ihr Auto ist ein:" + Typ+" "+ + Baujahr + " " + + Kilometerstand + " " + + MomentanPreis);
            string[,] Auto1array = new Array[1, 5];
            Auto1array[0, 0] = Typ;
            Auto1array[0, 1] = Baujahr;
            Auto1array[0, 2] = Kilometerstand;
        }

        public void 


        #endregion

    }
}
