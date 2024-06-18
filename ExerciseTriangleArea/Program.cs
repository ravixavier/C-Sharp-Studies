using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTriangleArea
{
    internal class Program
    {
        /*
         * Ask user for width and height, store them
         * Create function to calculate area
         * Function should calculate the area using: (width * height) / 2
         * Call in main and print out the area of the triangle
         */

        static void Main(string[] args)
        {
            /*
             * ao invés de ter duas funções, uma pra ler a altura e outra 
             * pra ler a largura, eu poderia simplesmente simplificar
             * e escrever apenas uma função para as duas, já que em teoria
             * é a mesma operação.
             * Pense de maneira lógica o problema, apesar de altura e largura
             * serem coisas diferentes, eu só preciso de uma função base pra ler
             * as duas.
             */
            int width = askWidth();
            int height = askHeight();

            int area = calculateArea(width, height);

            printArea(area);

            Console.ReadLine();
        }

        static int askWidth()
        {
            /*
             * ao invés de colocar a mensagem direto dentro da função
             * eu posso criar um parametro string para receber um texto
             * como eu desejar, assim deixo a função mais genérica possível
             * fazendo com que ela possa ser reutilizada para outro propósito
             * mais facilmente.
             */
            Console.WriteLine("Enter the width of the triangle: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int askHeight()
        {
            Console.WriteLine("Enter the height of the triangle: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int calculateArea(int width,  int height)
        {
            return (width * height) / 2;
        }

        static void printArea(int area)
        {
            Console.WriteLine($"The area of the triangle is: {area}");
        }


        /*
         * 

        static void Main(string[] args)
        {
            int width = readInt("Enter width: ");
            int height = readInt("Enter height: ");

            int area = calcArea(width, height);

            printResult(area);

            Console.ReadLine();
        }

        static int readInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int calcArea(int width,  int height)
        {
            return (width * height) / 2;
        }

        static void printResult(int area)
        {
            Console.WriteLine($"The area of the triangle is: {area}");
        }

         *
         */
    }
}
