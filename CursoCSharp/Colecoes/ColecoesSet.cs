using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        
        public static void Executar()
        {
            var livro = new Produto(" 1ª Temporada Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);


            var combo = new HashSet<Produto>()
            {
               new Produto(" 8ª Temporada de Game of Throne)", 99.9),
               new Produto(" Camisa personalizada do Game of Throne", 29.9),
               new Produto(" Poster do Game of Throne", 19.9),
                             
            };


            carrinho.UnionWith(combo);
            Console.WriteLine("Total de itens no carrinho: {0} produtos", carrinho.Count);
            //carrinho.RemoveAt(3); No método Set ele não aceita remoção

            foreach (var item in carrinho)
            {

                //Console.Write(carrinho..IndexOf(item)); No metodo Set ele não aceita indexão
                Console.WriteLine($" {item.Nome}, {item.Preco.ToString("C")}");

            }

            carrinho.Add(livro);
            carrinho.UnionWith(combo);
            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            ////Console.WriteLine(carrinho.LastIndexOf(livro));
        }

    }
}
