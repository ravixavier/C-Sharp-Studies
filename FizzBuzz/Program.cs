using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        /*
         * Create a loop from 1 to X (15)
         * 3 and 5 = FizzBuzz
         * 3 = Fizz
         * 5 = Buzz
         * else = number
         */
        static void Main(string[] args)
        {

            bool tryParseCheck;
            int count;
            bool threeDiv;
            bool fiveDiv;

            do
            {
                Console.WriteLine("Please enter a number for counting: ");
                var countInput = Console.ReadLine();
                tryParseCheck = int.TryParse(countInput, out count);

                Console.WriteLine(tryParseCheck ? "Counting Inicialized" : "Invalid number");
                Console.WriteLine();
            } while (!tryParseCheck);


            for (int i = 1; i <= count; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz!");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz!");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
