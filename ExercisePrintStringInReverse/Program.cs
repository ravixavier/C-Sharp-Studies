using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExercisePrintStringInReverse
{
    internal class Program
    {
        /*
         * Ask use to input message
         * Print in order
         * Print in reverse
         */

        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            //Print in order letter by letter
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            
            //Print in reverse letter by letter
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }



            Console.ReadLine();
        }
    }
}
