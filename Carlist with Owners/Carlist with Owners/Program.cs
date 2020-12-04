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

            Console.ReadLine();
        }
        static void Output(Personlist[]Personarray)
        {
            for (int i = 0; i < Personarray.GetLength(0); i++)
            {
                Console.WriteLine(Personarray[i].print());
            }
        }
        
    }
}
