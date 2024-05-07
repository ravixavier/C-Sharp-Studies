using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ravi";
            int age = 28;

            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine($"Your name is {name} and your age is {age}"); //na minha opiniao a melhor maneira de se escrever, fica mais claro de ver e de fato parece que estou escrevendo um texto continuo
            Console.WriteLine("Your name is Ravi and your age is 28");

            Console.ReadLine();
        }
    }
}
