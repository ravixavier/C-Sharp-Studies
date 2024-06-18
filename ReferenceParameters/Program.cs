using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 10;
            string text = "something";
            Assign(ref num, ref text);
            Console.WriteLine(num);
            Console.WriteLine(text);
            */

            string name = "Solomon";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();
            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}.");
            }
            else
            {
                Console.WriteLine($"New name cannot be empty or null!");
            }


            Console.ReadLine();
        }

        /*
         * the main differences between and using out key word
         * is when you're using out within a function you actually
         * need to make use of the value if I don't include anything
         * within using 'out' then I'm going to get an exception
         * saying that the out parameter must be assigned, and using 
         * ref keyword I don't have to make any assignment because we're
         * just passing a reference in.

         * como nesse exemplo abaixo, se printarmos na tela o valor de 'outro'
         * vamos obter o mesmo valor de 'num', já que especificamos que 'num' 
         * será referencia para a variável que usaremos de parametro na função,
         * por isso não há a necessidade de se atribuir um valor à 'outro'.

            static void Assign(ref int outro)
            {
                Console.WriteLine($"O valor de 'outro' é igual a {outro}.");
            }
         */

        static void Assign(ref int num, ref string text)
        {
            text = "something else";
            num = 28;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
        }
    }
}
