using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";
            
            //if (message == compare)
            /*
                if (message.Equals(compare))
                {
                    Console.WriteLine("Same");
                }
                else
                {
                    Console.WriteLine("Diff");
                }
            */

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //if (name != "")
            /*
                if (!name.Equals(string.Empty))
                {
                    Console.WriteLine($"Your name is {name}");
                }
                else
                {
                    Console.WriteLine("Invalid name output");
                }
            */

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            if (message.Equals(newCompare))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.ReadLine();
        }
    }
}
