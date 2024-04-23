using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hi!");
            //Console.WriteLine("Hi!");
            //Console.WriteLine("Hi!");
            //Console.WriteLine("Hi!");


            Console.WriteLine("What word do you want to repeat? ");
            var message = Console.ReadLine();
            Console.Write("How many times do you want to print it? ");
            int hiInput = Convert.ToInt32(Console.ReadLine());

            if (hiInput <= 0)
            {
                Console.WriteLine("Sorry, Please enter a value above 0");
            }
            else
            {

                for (int i = 0; i < hiInput; i++)
                {
                    Console.WriteLine(message);
                }

            }


            //for (int i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            Console.ReadLine();
        }
    }
}
