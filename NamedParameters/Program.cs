using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Ravi";
            int ageInput = 28;
            string addressInput = "798, Something Road.";

            PrintDeatails(age: ageInput, name: nameInput, address: addressInput);

            /*
             * apenas outra maneira de se utilizar os parametros em uma funcao
             * ao invez de utilizar a funcao com os parametros exatamente na ordem
             * especificada na funcao, vc pode 'enderecar' o parametro a variavel desejada
             */

            Console.ReadLine();
        }

        static void PrintDeatails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
