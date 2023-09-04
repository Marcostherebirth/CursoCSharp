using System;
using System.Collections.Generic;
using System.Collections;


namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano"); // enfilera uma lista
            fila.Enqueue("beltrano");
            fila.Enqueue("sicrano");

            
            Console.WriteLine(fila.Peek()); // pegar o elemento da lista sem remover
            Console.WriteLine(fila.Count);  // conta o número de elementos na lista

            Console.WriteLine(fila.Dequeue()); //  desinfilerar uma lista
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) // extrutura de repetição para percorrer 
            {
                Console.WriteLine(pessoa);
            }

            var fila2 = new Queue(); //* Possibilidade de criar uma fila com valores heterogênios
                                     //é uma estrutura que aceita repetição e dinâmica
            fila2.Enqueue(3);
            fila2.Enqueue("Item");
            fila2.Enqueue(true);
            fila2.Enqueue(3.14);

            Console.WriteLine(fila2.Contains("Item")); // Contains percorre para ver se tem na lista Queue



        }
    }
}
