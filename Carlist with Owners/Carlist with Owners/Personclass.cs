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
        
        private string _personprename;
        private string _personsecname;
        private int _anzahlperson;

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
        public void PersonInput()
        {
            

            //Input Number of Cars                 



            double[,] Auto1 = new double[1, 5];
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
