using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferência
            double raio = 4.5;
            const double PI = 3.14;

            //double area = PI * raio * raio;
            double area = PI * Math.Pow(raio, 2);
            Console.WriteLine("A area de circunferência é: {0}", area);

            bool estachovendo = true;
            Console.WriteLine("Está chovendo", estachovendo);
            
            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte SaldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + SaldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorvalorint = int.MinValue;
            Console.WriteLine("Menor int " + menorvalorint);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorlong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorlong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Munidal " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double ValorMercadoApple = 1000_000_000_000.00;
            Console.WriteLine("Valor de Mercado Apple: " + ValorMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas "
                + distanciaEntreEstrelas);
            char letra = 'm';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso C#!";
            Console.WriteLine(texto);












        }
    }
}
