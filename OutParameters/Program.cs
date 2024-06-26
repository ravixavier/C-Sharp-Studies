﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 0;
            //bool success = test(out num);
            test(out num);
            Console.WriteLine(num);
            */

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Cappuccino"
            };

            //Console.WriteLine(shoppingList.IndexOf("Cappuccino"));
            //Console.WriteLine(FindInList("cappuccino", shoppingList, out int index));
            //Console.WriteLine(index);

            Console.WriteLine("Enter an item to search: ");
            // crio uma variavel que vou usar como fonte pro parametro de busca
            string search = Console.ReadLine();

            if(FindInList(search, shoppingList, out int index))
                /*
                 * função retornando ao if se ela é verdadeira ou não
                 * e dentro da própria função crio a variável index 
                 * que vai receber do out parameter da função o index da busca
                 * 
                 */ 
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            //reescrevendo .IndexOf()
            /*
            int index = -1;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("cappuccino"))
                {
                    index = i;
                }
            }
            bool found = index > -1;

            Console.WriteLine(found ? "Found" : "Not Found");
            */
            //reescrevendo .IndexOf()

            Console.ReadLine();
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;
            // valor int pra eu ter um parametro e saber se é falso ou verdadeiro
            // aproveito e com ele faço o index search

            for (int i = 0; i < list.Count; i++)
            {
                // aqui pego a lista que vou receber como parametro e comparo com a string 's'
                // que tambem vou receber como parametro
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }

        //'reescrevendo' a função try.Parse
        static bool tryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static void test(out int outro)
        {
            outro = 5;
            //return true;

            /*
             * apenas lembrando que dessa maneira eu posso retornar
             * dois resultados, o 'void' da função pode retornar um valor
             * e o 'out' do parametro retorna outro valor.
             */
        }
    }
}
