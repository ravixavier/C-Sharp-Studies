using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbatim_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\t \n \"
            string speech = "Ele disse \"alguma coisa\"";
            string path = "C:\\Users\\Ravi\\Desktop\\C# Cours\n Nova Linha";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            //$ +
            //$"Your name is {name}"
            //"Your name is " + name

            path = @"C:\\Users\\Ravi\\Desktop\\C# Course\n" + "\n Nova Linha";
            Console.WriteLine(path);

            string text = "Fora de \"contexto\"";
            Console.WriteLine(text);

            string text2 = "Fora de 'contexto'";
            Console.WriteLine(text2);


            Console.ReadLine();
        }
    }
}
