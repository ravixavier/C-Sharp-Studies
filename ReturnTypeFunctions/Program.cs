using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {

        /*
         * Aqui podemos ver como é possível ultilizar funções que possuem retornos.
         */

        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            // ou Console.Title = $"{ReturnNameAgePair()}";
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            int[] newNumbers = CreateNewNumbers();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        /*
         * A priori uma função deve realizar somente uma tarefa
         * por exemplo; se determinada função faz uma conversão e um cálculo
         * ao mesmo tempo, isso sería o equivalente a duas tarefas sendo realizadas
         * dentro de um única função, o certo a se fazer é separar essas duas tarefas
         * em duas funções independentes, dessa maneira podemos escolher quando
         * realizar cada tarefa separadamente, já que sería impossível fazer isso
         * caso as duas tarefas estivessem em uma única função; toda vez que você fosse
         * calcular, obrigatóriamete você teria de converter e vice versa.
         */

        static void badExample() 
        {
            //conversion
            //calculation
        }
        static void Example1()
        {
            //conversion
        }
        static void Example2()
        {
            //calculation
        }

        static int[] CreateNewNumbers()
        {
            return new int[3] { 3, 2, 1 };
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Ravi";
            //dessa maneira eu posso alterar meu nome facilmente
            //ex: return "Salomão";
        }

        static int ReturnAge()
        {
            return 28;
        }

        static void PrintIntroduction()
        {
            /*
            string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hello my name is {name} and my age is {age}.";
            Console.WriteLine(output);
            */

            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}.");
        }
        
        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
    }
}
