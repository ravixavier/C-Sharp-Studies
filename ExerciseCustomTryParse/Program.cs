using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCustomTryParse
{
    internal class Program
    {

        /*
         * Create an int and try convert any string to an int
         * Notice the erro, and try...catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Why this is a bad situation and how can we know if its been converted?
         * 
         * Create a custom try parse function
         * Find the real function and copy return type/params
         * Read the tool tip it gives you, to give you ideas on what to do
         */

        static void Main()
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();

            if (CustomTryParse(numInput, out int result))
            {
                Console.WriteLine("Convercao foi um sucesso");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversao falhou");
            }

            int test = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(test);


            Console.ReadLine();
        }

        static bool CustomTryParse(string s, out int result)
        {
            result = 0;

            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Message:  {e.Message}");
            }

            return false;
        }
    }
}
