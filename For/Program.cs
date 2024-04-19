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
            /*
            Console.WriteLine("Hi!");
            Console.WriteLine("Hi!");
            Console.WriteLine("Hi!");
            Console.WriteLine("Hi!");
            */

            Console.Write("How many time do you want to print 'hi'? ");
            int hiInput = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < hiInput; i++)
            {
                Console.WriteLine("hi");
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
