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
        string _newOwner;
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
        public string Print()
        {
            return _vorname + _nachname + _alter + _personID;
        }

        public string ChangeOwner()
        {
            Console.WriteLine("Wie heißt der neue Besitzer?");
            return _newOwner = Console.ReadLine();
        }
        #endregion

        #region properties
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string Alter { get; set; }

        public string PersonID { get;}
        #endregion
    }
}
