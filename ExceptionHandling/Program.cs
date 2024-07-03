using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException
            //System.OverflowException

            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Porfavor digite um numero menor que 2 biliões!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Porfavor apenas digite numeros!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ops! Algo de certo não está certo!");
                }

            }

            Console.WriteLine("Tudo certo por aqui! \n Tchauzinho!");

            Console.ReadLine();
        }
    }
}
