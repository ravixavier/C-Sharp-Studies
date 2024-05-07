using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                string name = "";
                Console.WriteLine(name);

                name = "Ravi";
                Console.WriteLine(name);

                Console.WriteLine(string.Concat(name, " S. C. Xavier"));
                Console.WriteLine(name);
            */

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            
            if (name != string.Empty) //(name = string.Empty) é igual a (name = "";)
                                      //a diferença é que string.Empty é mais consistente 
                                      //em relação a escrita do código
            {
                Console.WriteLine($"Your names is {name}.");
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }


            Console.ReadLine();
        }
    }
}
