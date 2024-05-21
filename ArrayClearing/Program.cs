using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            //Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(numbers, 4, 4);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = default;
            //    numbers[i] = 0;
            //}


            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
