using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Program
    {
        static Auto[] autoArray = new Auto[11];
        static int index = 0;
        static Person[] personArray = new Person[11];
        static void Main(string[] args)
        {

            bool inputend = true;          
                                                        
            do
            {              
                Console.WriteLine("Willkommen zur Autoliste");
                Console.WriteLine("Folegnde Möglichkeiten stehen Ihnen zur Verfügung");
                Console.WriteLine("h\n help s oder c oder n oder v oder d");
                char myfunction= Console.ReadLine()[0];


                if (myfunction=='h')//Help
                {
                    Console.WriteLine("s = Zeigt alle Autos in einer Liste");
                    Console.WriteLine("c = Legt ein neues Auto an");
                    Console.WriteLine("n = Zeigt den nächsten Service eines Autos an");
                    Console.WriteLine("v = Gibt den aktuellen Wert eines Autos an");
                    Console.WriteLine("d = Ändert den Kilometerstand des Autos");
                    Console.ReadLine();
                }
                else if (myfunction=='s')//show all cars
                {
                    PrintCars();
                    Console.ReadLine();

                   
                }
                else if (myfunction == 'c')//create new Car
                {
                    CreateNewCar();

                }
                else if (myfunction =='n')//nextservice
                {
                    Console.WriteLine("Welche AutoID soll verwendet werden?");
                    int.TryParse(Console.ReadLine(), out int auswahl);

                    double servicewarnung = autoArray[auswahl].CalculateService();
                    Console.WriteLine(servicewarnung);
                }
                else if (myfunction=='v')//price
                {
                    Console.WriteLine("Welche Auto ID");
                    int.TryParse(Console.ReadLine(),out int auswahl);

                    double berechneterPreis= autoArray[auswahl].CalculatePrice();

                    if (berechneterPreis >= 0)
                    {
                        Console.WriteLine(berechneterPreis);
                    }
                    else
                    {
                        Console.WriteLine("Auto kaputt");
                    }                                        
                }
                else if (myfunction=='o')//new owner
                {
                    Console.WriteLine("\nWelche Auto ID?");
                    int.TryParse(Console.ReadLine(), out int auswahl);              
                                                           
                }
                else if (myfunction=='d')//kilometerhinzufügen
                {
                    Console.WriteLine("\nWelche Auto ID");
                    int.TryParse(Console.ReadLine(), out int auswahl);
                    int newkilo = autoArray[auswahl].Drive();
                    Console.WriteLine(newkilo);
                }
                else if (myfunction=='e')//exit function
                {
                    Console.WriteLine("\nAutoliste beenden? J/N");
                    char stopp = Console.ReadLine()[0];
                    switch (stopp)
                    {
                        case 'J': inputend = false; break;
                        case 'j': inputend = false; break;
                        case 'N': inputend = true; break;
                        case 'n': inputend = true; break;                        
                    }
                   
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe! Eingabe wiederholen!");
                }               
                
            }
            while (inputend);
            Console.ReadLine();
            
        }

        public static void CreateNewCar()
        {

            Console.WriteLine("Typ Eingeben");
            string typ = Console.ReadLine();

            Console.WriteLine("Baujahr eingeben");
            int.TryParse(Console.ReadLine(), out int intbaujahr);

            Console.WriteLine("Kilometerstand eingeben");
            int.TryParse(Console.ReadLine(), out int intkilometer);

            Console.WriteLine("Preis eingeben");
            int.TryParse(Console.ReadLine(), out int intpreis);

            Console.WriteLine("Besitzer ID eingeben");
            int.TryParse(Console.ReadLine(), out int intpersonID);

            autoArray[index++] = new Auto(typ, intbaujahr, intkilometer, intpreis, personArray[intpersonID]);
            Console.WriteLine("Neues Auto erstellt!\nWeiter mit Enter");            
            Console.ReadLine();
        }

        public static void CreateNewPerson()
        {
            personArray[0] = new Person("Philipp","Biermann",22,0);
            personArray[1] = new Person("Lukas", "Meier", 18, 1);
            personArray[2] = new Person("Philipp", "Biermann", 22, 2);
            personArray[3] = new Person("Philipp", "Biermann", 22, 3);
            personArray[4] = new Person("Philipp", "Biermann", 22, 4);
            personArray[5] = new Person("Philipp", "Biermann", 22, 5);
            personArray[6] = new Person("Philipp", "Biermann", 22, 6);
            personArray[7] = new Person("Philipp", "Biermann", 22, 7);
            personArray[8] = new Person("Philipp", "Biermann", 22, 8);
            personArray[9] = new Person("Philipp", "Biermann", 22, 9);
            personArray[10] = new Person("Philipp", "Biermann", 22, 10);            
        }


        public static void PrintCars()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(autoArray[i].Print());
                //Console.WriteLine(personArray[i].Print());
            }           
        }

    }
}
