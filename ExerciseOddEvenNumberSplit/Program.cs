using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOddEvenNumberSplit
{
    internal class Program
    {
        /*
         * Create two lists with integer data type, one for even numbers, one for odd
         * Loop from 0-20
             * if number is even, add to even list
             * if number is odd, add to odd list
         * Print even list
         * Print odd list
         */
        static void Main(string[] args)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();


            for(int i = 0; i < 21; i++)
            {
                bool numIsEven = i % 2 == 0;

                if (numIsEven)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            Console.WriteLine("Printing even numbers: ");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
                System.Threading.Thread.Sleep(150);
            }

            Console.WriteLine();

            Console.WriteLine("Printing odd numbers: ");
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
                System.Threading.Thread.Sleep(150);
            }

            Console.ReadLine();
        }
    }
}
