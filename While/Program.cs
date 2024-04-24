using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }*/

            Console.Write("Enter the first number: ");
            var numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            
           /* while (answer != actualAnswer)
            {
                Console.WriteLine("What's the value of " + numberA + " x " + numberB + "?");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong! Try again!");
                }
            }*/

            do
            {
                Console.WriteLine();
                Console.WriteLine("What's the value of " + numberA + " x " + numberB + "?");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong! Try again!");
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well Done!");

            Console.ReadLine();
        }
    }
}
