using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        /*
         * Void não faz nada, ele simplesmente realiza o conteúdo
         * da função e assim que ele termina a função nada mais acontece.
         * Você pode ter outro tipo de função que retorna algum valor
         * ou conteúdo depois de finalizada, como por exemplo try.Parse
         * que retorna um valor bool indicando se a função conseguiu ou não
         * realizar o parse.
         */
        static void Main(string[] args)
        {
            CreateAndPrint();

            /*
             * Por exemplo o array de inteiros criado em CreateAndPrintArray
             * não está acessível fora de CreateAndPrint
             * no momento em que a função é finalizada numbers é deletado da memoria
             */

            Console.ReadLine();
        }

        static void CreateAndPrint()
        {
            int[] numbers = new int[5] { 0, 1, 2, 3, 4 };

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
