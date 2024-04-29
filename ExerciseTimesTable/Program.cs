using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success;
            int num;
            int tSize;

            do
            {
                Console.Write("Digite o numero que voce deseja multiplicar: ");
                var numInput = Console.ReadLine();
                success = int.TryParse(numInput, out num);

                Console.WriteLine(success ? "Numero valido" : "Numero invalido, digite outro numero.");
                Console.WriteLine();

            } while (!success);

            do
            {
                Console.Write("Quantas vezes voce deseja multiplicar esse numero? ");
                var tSizeInput = Console.ReadLine();
                success = int.TryParse(tSizeInput, out tSize);

                Console.WriteLine(success ? "Numero valido" : "Numero invalido, digite outro numero.");
                Console.WriteLine();

            } while (!success);

            
            for (int i = 1; i < tSize + 1; i++)
            {
                //Console.WriteLine(i + " x " + num + " = " + (i * num));
                Console.WriteLine("{0:00} x {1:00} = {2:00}", i, num, i * num);
            }



            Console.ReadLine();
        }
    }
}
