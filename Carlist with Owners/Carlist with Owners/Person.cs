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
            _vorname = vorname;
            _nachname = nachname;
            _alter = alter;
            _personID = personID;
        }
        #endregion

        #region methods
        private string Print()
        {            
            return _vorname+" "+ _nachname+" "+ _personID;
        }

        public string ChangeOwner()
        {
            Console.WriteLine("Wie heißt der neue Besitzer mit Vornamen?");
            _newVorname = Console.ReadLine();
            _vorname = _newVorname;
            Console.WriteLine("Wie heißt er mit Nachnamen?");
            _newNachname = Console.ReadLine();
            _nachname = _newNachname;
            Console.WriteLine("Wie alt ist er?");
            int.TryParse(Console.ReadLine(), out _newAlter);
            _alter = _newAlter;
            return _vorname+_nachname+_newAlter;        

        }
        #endregion

        #region properties
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string Alter { get; set; }

        public string Besitzer  { get; set; }
        #endregion

        #region overload methods
        public override string ToString()
        {
            return Print();
        }
        #endregion
    }
}
