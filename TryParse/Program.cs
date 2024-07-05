using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();


                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }

            /*
             * Resumo: Nós usamos o int.TryParse para tentar e passar um valor
             * antes do programa assumir que o valor está no formato correto.
             * Nós fornecemos uma variável string (também poderia ser uma variável 'var')
             * e ele nos retorna com um novo inteiro chamado 'num' ou qualquer nome que queiramos.
             * Podemos colocar isso diretamente dentro da condição de uma instrução
             * if porque essa função nos retorna um valor true ou false.
             * 
             * Se for bem-sucedido, paramos o loop while e imprimimos o 
             * valor na tela. Se não for bem-sucedido, imprimimos 'falha ao converter'
             * e porque nosso 'sucesso' ainda é verdadeiro, ele retornará ao início do
             * loop while e pedirá ao usuário para inserir outro valor para tentar converter.
             * Este loop só será interrompido se for bem-sucedido e a única maneira de
             * sair é ter sucesso igual a falso, e a única maneira disso acontecer é com
             * uma conversão bem-sucedida.
             * 
             * O uso do TryParse em todo programa é essencial
             * porque se você tiver uma exceção fatal, seu programa fechará e você perderá
             * todos os dados. O problema é que você pode perder qualquer coisa que ainda
             * não tenha processado até aquele momento em seu programa. Portanto, você quer
             * tentar usar o TryParse porque evitará quaisquer exceções potenciais e poderá
             * informar ao usuário se a conversão foi bem-sucedida ou não.
             * 
             * A única desvantagem de usar o TryParse ao invés de Convert.ToInt32 é que convertendo
             * diretamente, sem utilizar o TryParse, conseguimos converter numeros que começam com 0,
             * já com o TryParse ele elimina qualquer quantidade de zeros iniciais na string.
             * Exemplo: "0000321", utilizando o TryParse seria convertido para o inteiro "321",
             * por sua vez com o Convert.ToInt32 o resultado seria de fato "0000321".
             * POR ALGUM MOTIVO ESSE ÚLTIMO PARAGRAFO JÁ NÃO É VERDADE. 
             */

            Console.ReadLine();
        }
    }
}
