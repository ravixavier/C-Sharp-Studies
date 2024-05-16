using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 5;
            //int num2 = 10;
            //int num3 = 15;
            //int num4 = 30;


            //Console.WriteLine("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number: ");
            //numbers[3] = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}");
            //}

            /*
             * Outra maneira de se escrever esse codigo é usando
             * 'foreach'
             *
             * foreach (int num in numbers)
             * {
             *      Console.WriteLine($"{num}");
             * }
             * 
             * a diferença com foreach é que ele vai percorrer
             * indiscriminadamente TODO o array, então caso eu queira
             * percorrer determinado range em especifico do array eu
             * não seria capaz com o foreach, exemplo em um array de 
             * 500 indexs, percorrer somente os index 100 ao 250, 
             * seria impossivel
             */

            const int angleCount = 3;
            //interessante aqui evitar um 'magic number'
            //criando um pequena variavel pra identificar
            //o significado desse numero '3', deixando a leitura
            //do codigo mais facil.

            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
