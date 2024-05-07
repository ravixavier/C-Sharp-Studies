using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ravi";
            int age = 28;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);

            Console.WriteLine("Your name is " + name + ", and your age is " + age);

            Console.WriteLine("Your name is {0}, and your age is {1}.", name, age);
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);


            Console.ReadLine();
        }
    }
}
