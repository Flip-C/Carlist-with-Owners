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

            bool inpudend = true;

            do
            {
                Console.WriteLine("Hallo willkommen zur Autoliste");
                Console.WriteLine("Folegnde Möglichkeiten stehen Ihnen zur Verfügung");
                Console.WriteLine("h -> Help\n s -> zeigt alle Autos in der Liste\n c -> legt ein neues Auto an\n n -> zeigt den nächsten Service eines Autos\n v -> gibt den Aktuellen Wert eines Autos an");
                char myfunction= Console.ReadLine()[0];


                if (myfunction=='h')//Help
                {
                    
                }
                else if (myfunction=='s')//show all cars
                {

                }
                else if (myfunction == 'c')//create new car
                {

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
                    case 'J': inpudend = true;break;
                    case 'j': inpudend = true;break;
                    case 'N': inpudend = false;break;
                    case 'n':inpudend = false;break;
                }
            }
            while (inpudend);
            Console.ReadLine();
            
        }
                
    }
}
