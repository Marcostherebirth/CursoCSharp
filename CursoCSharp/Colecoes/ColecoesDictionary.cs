using System;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary // Generics
    {
        

        public static void Executar()
        {// Este método você ad int e string = int é Set e string é um List
            //Set não aceita repetição e List aceita repetição.
            var filmes = new Dictionary<int, string>(); 
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004 " + filmes[2004]); // Vc pode utilizar o array
                Console.WriteLine("2004 " + filmes.GetValueOrDefault(2004)); // Opção de método a ser utilizado
                
            }

            Console.WriteLine(filmes.ContainsValue("Aminésia")); // Opção de método a ser utilizado 
            
            Console.WriteLine("Removeu? " + filmes.Remove(2004)); // Opção de método a ser utilizado 

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chaves in filmes.Keys) // percorrendo somente as chaves
            {
                Console.WriteLine(chaves);
            }

            foreach (var valor in filmes.Values) // percorrendo somente os valores
            {
                Console.WriteLine(valor);
            }
            
            foreach(KeyValuePair <int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");// percorrendo valor e chave


            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");// Outra forma de percorrer valor e chave
            }
        }
    }
}
