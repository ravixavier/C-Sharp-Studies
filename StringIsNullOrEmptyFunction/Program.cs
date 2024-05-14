using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIsNullOrEmptyFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = null;

            Console.WriteLine($"Your name is {name}");

            if (name != "")
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Incorrect");

            /*
             * nao adianta usar (!= "") para diferenciar se uma string
             * é nula ou vazia pq caso ela tenha o valor null
             * dessa maneira que foi escrita o codigo não vai detectar
             * caso ela seja nula, pois ele está verificando apenas
             * se ela é uma string vazia.
             */

            if (!name.Equals(""))
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Incorrect");
            /*
             * essa maneira tbm não será valida pq o código
             * usa uma função o que resultará em uma exceção
             * se por algum acaso a string tiver o valor de null
             */

            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Incorrect");

            Console.ReadLine();
        }
    }
}
