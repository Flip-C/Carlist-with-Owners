using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Person
    {
        #region members
        string _vorname;
        string _nachname;
        int _alter;
        int _personID;
        string _newVorname;
        string _newNachname;
        int _newAlter;
        #endregion                   

        #region constructor 
        public Person(string vorname, string nachname, int alter, int personID)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
            PersonID = personID;
        }
        #endregion

        #region methods
        private string Print()
        {            
            return Vorname+" "+ Nachname+" "+ PersonID;
        }

        public string ChangeOwner()
        {
            Console.WriteLine("Wie heißt der neue Besitzer mit Vornamen?");
            _newVorname = Console.ReadLine();
            Vorname = _newVorname;
            Console.WriteLine("Wie heißt er mit Nachnamen?");
            _newNachname = Console.ReadLine();
            Nachname = _newNachname;
            Console.WriteLine("Wie alt ist er?");
            int.TryParse(Console.ReadLine(), out _newAlter);
            Alter = _newAlter;
            return Vorname+Nachname+Alter;        

        }
        #endregion

        #region properties
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public int Alter { get; set; }

        public int PersonID  { get; set; }
        #endregion

        #region overload methods
        public override string ToString()
        {
            return Print();
        }
        #endregion
    }
}
