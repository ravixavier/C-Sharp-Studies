using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(50, 50));

            /*
            int num = ReadInt("Enter a number");
            Console.WriteLine(num);

            int angle = ReadInt("Enter an angle");
            Console.WriteLine(angle);
            */

            /*
            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");
            int result = Add(firstNum, secondNum);
            Console.WriteLine($"The sum of those numbers is {result}.");
            */
            //Console.WriteLine($"The sum of those numbers is {Add(firstNum, secondNum)}.");

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();

            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");
            string details = UserDetails(name, age);
            
            Console.WriteLine(details);
            //Console.WriteLine(UserDetails(name, age));


            Console.ReadLine();
        }

        static string UserDetails(string name, int age)
        {
            return $"Olá meu nome é {name} e eu tenho {age} anos.";
        }

        static string ReadString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            /*
             * para ser sincero não gosto muito dessa ideia abaixo de padronizar
             * o parametro string; a não ser que seja absolutamente necessário
             * já que em qualquer momento de um projeto uma pessoa pode chegar 
             * e não saber de 'tal' padronização, apesar de que é fundamental 
             * que sempre se leia a documentação antes de inciar em um projeto.
             */
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /*
         * 'a' e 'b' nesse contexto são variávei locais,
         * ou seja elas não podem ser utilizadas fora dessa função
         * uma vez que a função 'Add' for executada
         * as variávei serão apagadas da memoria
         */
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
