using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Dictionary<int, string> names = new Dictionary<int, string>
                        {
                            //KeyValuePair
                            {1, "Beatriz"}
                        };

                        names.Add(2, "Gabriel");
                        names.Add(3, "Ravi");

                        //Console.WriteLine(names[1]);
                        //Console.WriteLine(names[2]);
                        //Console.WriteLine(names[3]);

                        *//*
                         * Igualmente a uma lista ou um array podemos
                         * utilizar um for loop ou um foreach para acessar
                         * diretamente o dicionario, entretando como Dictionary
                         * não é primariamente index 0 based, é recomendado que
                         * utilizemos .ElementAt para nos referenciar aos index
                         * quando for percorrer utilizando for loop.
                         *//*

                        for (int i = 0; i < names.Count; i++)
                        {
                            KeyValuePair<int, string> pair = names.ElementAt(i); // vai retornar o key, value referente ao index
                            //                    var test = names.ElementAt(i);
                            //Console.WriteLine(pair); return "[key, value]"
                            Console.WriteLine($"{pair.Key} - {pair.Value}");
                            // usando var.Key ou var.Value, podemos formatar de uma maneira melhor
                        }

                        Console.WriteLine();

                        //                    foreach (var item in names)
                        foreach (KeyValuePair<int, string> item in names)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        *//*
                         * o uso do foreach para percorrer todo o dicionario
                         * é bem mais facil e intuitivo, porem ainda assim é
                         * um foreach, ou seja ele nao vai percorrer ranges
                         * especificos do dicionario.
                         */

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Ravi" },
                {"Science", "Gabriel" }
            };

            //Console.WriteLine(teachers["Math"]);
            /*
             * se por algum acaso a key não for encontrada
             * utizando dessa maneira o código irá retornar uma exceção
             * portanto é indicado que se use um tryGetTheValue que 
             * é similar a um tryParse
             */

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("Math teacher, not found.");
            }

            teachers.Remove("math");

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach(var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
