using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSumOfIntArray
{
    internal class Program
    {
        /*
         * Create and incializer int array of numbers
         * Create function SumOfNumbers with int return type
         * int array parameter
         * function should return total of all numbers
         * call in main and output the total
         * extra: check array length
             * return -1 if array empty
             * check return in main and output the message
             * we need to return -1, how else can we make this?
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 100
            };

            bool result = SumOfNumbers(numbers, out int total);

            if (result)
            {
                Console.WriteLine($"The total is: {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }


            Console.ReadLine();
        }

        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {

                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;
            }

            return false;
        }

        /*
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;
            }
            return -1;
        }
        */
    }
}
