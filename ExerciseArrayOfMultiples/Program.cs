using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArrayOfMultiples
{
    internal class Program
    {
        /*
         * Define and initialize two integers (num, length)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Create int array with size length
         * loop through and insert the (loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            Console.Write("Define the length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfMultiples = new int[length];

            Console.Write("Define the first number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < arrayOfMultiples.Length; i++, counter++)
            {
                arrayOfMultiples[i] = num * (counter);
                Console.WriteLine(arrayOfMultiples[i]);
            }

            Console.WriteLine(arrayOfMultiples.Length);

            Console.ReadLine();
        }
    }
}
