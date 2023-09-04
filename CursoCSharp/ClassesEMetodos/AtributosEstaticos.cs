using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

    }


    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.1 - Nesse caso como inseri um static a variável desconto
                //passar a não valer mais.
            };
            //Produto.Desonto = 0.5; Forma de colocar desconto em todos os produtos
            //quando a variável desconto se torna uma classe em vez de uma variável.

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}",
                produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}",
                produto2.CalcularDesconto());
        }
    }
}
