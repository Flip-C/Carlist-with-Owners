using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist_with_Owners
{
    class Program
    {
        static void Main(string[] args)
        {

            bool inputend = true;
            
            

            do
            {
                Console.WriteLine("Willkommen zur Auto-liste");
                Console.WriteLine("Folegnde Möglichkeiten stehen Ihnen zur Verfügung");
                Console.WriteLine("h -> help oder c oder n oder v");
                char myfunction= Console.ReadLine()[0];


                if (myfunction=='h')//Help
                {
                    Console.WriteLine("n = zeigt alle Autos in einer Liste");
                    Console.WriteLine("c = legt ein neues Auto an");
                    Console.WriteLine("n = zeigt den nächsten Service eines Autos an");
                    Console.WriteLine("v = gibt den aktuellen Wert eines Autos an");
                    Console.ReadLine();
                }
                else if (myfunction=='s')//show all cars
                {
                    
                    
                }
                else if (myfunction == 'c')//create new Car
                {
                              
                }
                else if (myfunction =='n')//nextservice
                {
                    Console.WriteLine("Welches Auto soll verwendet werden?");
                    char eingabe = Console.ReadLine()[0];
                    switch()
                    {
                        case '1'://Auto 1 auswählen
                        case '2'://Auto 2 auswählen
                        case '3'://Auto 3 auswählen
                        case '4'://Auto 4 auswählen
                        case '5'://Auto 5 auswählen
                        
                    }                  
                }
                else if (myfunction=='v')//price
                {

                }



                Console.WriteLine("Autoliste beenden? J/N");
                char stopp = Console.ReadLine()[0];
                switch (stopp)
                {
                    case 'J': inputend = false;break;
                    case 'j': inputend = false;break;
                    case 'N': inputend = true;break;
                    case 'n':inputend = true;break;
                }
            }
            while (inputend);
            Console.ReadLine();
            
        }
                
    }
}
