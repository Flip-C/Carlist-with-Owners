using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Carlist
    {
        #region members
        
        

        public Carlist()
        {
        }


        #endregion

        #region constructor
        public Carlist(string personprename, string personsecname, int anzahlperson)
        {
            
        }
        
        #endregion

        #region properties
        
        #endregion

        #region methods
        public void CarInput()//wenn Benutzer c drückt
        {
            string[,] Auto1 = new string[1, 5];
                                        
            Console.WriteLine("Marke eingeben");
            string Marke = Console.ReadLine();
            Auto1[0, 0] = "Marke";
            Auto1[1, 0] = Marke;
            

            Console.WriteLine("Baujahr");
            string Baujahr = Console.ReadLine();
            Auto1[0, 1] = "Baujahr";
            Auto1[1, 1] = Baujahr;
            

            Console.WriteLine("Kilometer");
            string Kilometer = Console.ReadLine();
            Auto1[0, 2] = "Kilometer";
            Auto1[1, 2] = Kilometer;
            

            Console.WriteLine("MRSP");
            string MSRP = Console.ReadLine();
            Auto1[0, 3] = "MSRP";
            Auto1[1, 3] = MSRP;
            

            Console.WriteLine("Besitzer");
            string Besitzer = Console.ReadLine();
            Auto1[0, 4] = "Besitzer";
            Auto1[1, 4] = Besitzer;
            

            






            double[,] Auto2 = new double[1, 5];
            double[,] Auto3 = new double[1, 5];
            double[,] Auto4 = new double[1, 1];
            double[,] Auto5 = new double[1, 1];
            double[,] Auto6 = new double[1, 1];
            double[,] Auto7 = new double[1, 5];
            double[,] Auto8 = new double[1, 5];
            double[,] Auto9 = new double[1, 5];
            double[,] Auto10 = new double[1, 5];

            //[Typ,Baujahr,Kilometer,LRSP,Besitzer]                      
        }        
        #endregion

    }
}
