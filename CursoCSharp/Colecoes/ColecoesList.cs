using CursoCSharp.Colecoes;
using System;
using System.Collections.Generic;



namespace CursoCSharp.Colecoes
{
    internal class ColecoesList
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object? obj)
            {
                return obj is Produto produto &&
                       Nome == produto.Nome &&
                       Preco == produto.Preco;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Nome, Preco);
            }
        }

        public static void Executar()
        {
            var livro = new Produto("- Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>()
            {
               new Produto("- 8ª Temporada de Game of Throne", 99.9),
               new Produto("- Camisa personalizada do Game of Throne", 29.9),
               new Produto("- Poster do Game of Throne", 19.9),

            };


            carrinho.AddRange(combo);
            Console.WriteLine("Total de itens no carrinho: {0} produtos", carrinho.Count);
            //carrinho.RemoveAt(3); Esse comando habilitado remove o indice (3) do combo.

            foreach (var item in carrinho)
            {

                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco.ToString("C")}.");


            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
