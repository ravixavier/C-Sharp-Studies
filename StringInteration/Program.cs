using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome!";

             //char[], uma string é nada mais nada menos
             //que um array de chars, dessa maneira podemos
             //imprimir apenas determinados char de um string

            //Console.WriteLine(message[0]);
            //Console.WriteLine(message[1]);
            //Console.WriteLine(message[2]);
            //Console.WriteLine(message[3]);
            //Console.WriteLine(message[4]);

            //entretanto nem sempre iremos saber o tamanho
            //exato dessa string, se por algum acaso referenciarmos
            //um index que nao existe na string entraremos em um excecao
            //sendo assim podemos gerar um for loop que ira percorrer
            //todo o array de char(a string) sem execer nenhum index referente

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(50); //flavor
            }

            Console.WriteLine();
            //funcao que verifica de a string possui x char
            Console.WriteLine(message.Contains('#'));
            //podemos tambem tentar escrever a nossa
            //propria versao dessa funcao

            bool contains = false;
            //iniciamos entao uma var bool com o objetivo
            //de apontar que ainda nao encontramos o char especifico
            //assim depois podemos alterar esse valor
            //indicando que o encontramos

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('#'))
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);
            //basicamente um .Contais function

            //a pergunta que fica é... e se eu quiser procurar 
            //um string dentro de um string?

            Console.ReadLine();
        }
    }
}
