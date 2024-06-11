using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(1);
            Console.WriteLine(result);

            /*
             * nesse caso se não dermos um valor opcional ou default para o parametro em printName();
             * será impossível chamar a função sem parametro algum.
             * o valor default para um parametro string é uma string vazia.
             */
            printName();
            //printName("Ravi");
            
            Console.ReadLine();
        }

        static void printName(string name = default)
        {
            Console.WriteLine($"Olá meu nome é {name}.");
        }

        static int Add(int a, int b = 27 /*ou vc pode dar o valor de 'default' que seria igual a 0*/)
        {
            return a + b;
        }
    }
}
