using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1ercises
{
    internal class Program
    {
        /*
         * Create & Initialise two ints
         * Make a variable to work out the remainder
         * Output remainder to ther screen
         * Change the first int variable to another number
              * and recalculate the remainder
              * output new remainder to screen
         */
        static void Main(string[] args)
        {
            int num1 = 42348;
            int num2 = 2;
            var remainder = num1 % num2;

            Console.WriteLine(remainder);

            num1 = 12345;
            remainder = num1 % num2;
            Console.WriteLine(remainder);


            Console.ReadLine();
        }
    }
}
