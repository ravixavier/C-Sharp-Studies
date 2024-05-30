using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30, 199
            };

            Console.WriteLine("enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search);
            //int position = Array.IndexOf(numbers, search, 3);
            int position = Array.IndexOf(numbers, search, 2, 3);

           // int position = -1;

           //for (int i = 0; i > numbers.Length; i++)
           // {
           //     if (numbers[i] == search)
           //     {
           //         position = i;
           //     }
           // }

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at index {position}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }

            Console.ReadLine();
        }
    }
}
