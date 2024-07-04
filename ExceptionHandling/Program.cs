using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a value under 2 billion!");
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error: {x.Message}");
            }

            Console.WriteLine("Goodbye!");

            Console.ReadLine();

            //Try Catch
            /*
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

                Console.WriteLine("Tudo certo por aqui!\nTchauzinho!");
             */
        }
    }
}
