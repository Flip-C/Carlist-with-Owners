using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Personlist
    {
        #region members
        
        private string _personprename;
        private string _personsecname;
        private int _anzahlperson;

        public Personlist()
        {
        }


        #endregion

        #region constructor
        public Personlist(string personprename, string personsecname, int anzahlperson)
        {
            Prename = personprename;
            Secname = personsecname;
            Anzahlperson = anzahlperson;
        }
        
        #endregion

        #region properties
        public string Prename { get; set; }
        public string Secname { get; set; }
        public int Anzahlperson { get; set; }
        #endregion

        #region methods
        public void PersonInput()
        {
            int anzahlperson;

            //Input Number of Cars/Person
            Personlist Number = new Personlist();

            Console.WriteLine("Geben Sie die Anzahl der zu erstellenden Plätze ein");
            string anzahlpersonlist = Console.ReadLine();
            int.TryParse(anzahlpersonlist, out anzahlperson);
            Personlist[] Personarray = new Personlist[anzahlperson];



            for (int i = 0; i < anzahlperson; i++)
            {
                Personarray[i] = new Personlist();

                Console.WriteLine("Geben Sie den Vornamen ein");
                string personprename = Console.ReadLine();

                Console.WriteLine("Geben Sie den Nachnamen ein");
                string personsecname = Console.ReadLine();
            }
           
        }

        public string print()
        {
            return Prename + Secname;
        }       
        #endregion

    }
}
