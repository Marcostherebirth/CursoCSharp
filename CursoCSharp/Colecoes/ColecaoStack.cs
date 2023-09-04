using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();/* serve para implementar o método Push
                                     * Ele acrescenta qualquer valor, seja int
                                     * string, flout, bool */
            pilha.Push("Marcos Pereira da Silva");
            pilha.Push("Isadora Oliveira de Araújo Silva");
            pilha.Push("Carolina Oliveira de Araújo Silva");
            pilha.Push("Marcelo Pereira da Silva");
            
            
            foreach (var item in pilha)
            {
                
                Console.WriteLine($"{item} ");
               
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); /* O "Pop" tira o primeiro elemento
                                                         * da pilha . */
            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            
            Console.WriteLine($"\nPeek: {pilha.Peek()}");/* O Pick pega o valor no topo
                                                        * da pilha e não remove */
            Console.WriteLine(pilha.Count);
           
            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
                
            }
        }
    }
}
