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
                Console.WriteLine("h -> Help\ns -> zeigt alle Autos in der Liste\nc -> legt ein neues Auto an\nn -> zeigt den nächsten Service eines Autos\nv -> gibt den Aktuellen Wert eines Autos an");
                char myfunction= Console.ReadLine()[0];


                if (myfunction=='h')//Help
                {
                    
                }
                else if (myfunction=='s')//show all cars
                {

                }
                else if (myfunction == 'c')//create new car
                {
                    //CarInput
                }
                else if (myfunction =='n')//nextservice
                {

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
