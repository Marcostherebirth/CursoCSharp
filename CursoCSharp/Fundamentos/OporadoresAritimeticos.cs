using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OporadoresAritimeticos
    {
        public static void Executar()
        {
            CultureInfo cultura = new CultureInfo("en-US");
            // Preço desconto
            var preco = 1000;
            double imposto = 230;
            double desconto = 0.1;
            var Total = preco + imposto;
            var TotalComDesonto = Total - (Total * desconto);
            Console.WriteLine("Valor total do produto: {0}"
                , TotalComDesonto.ToString("C"));

            //Calculo do IMC
            double peso, altura, imc;
            Console.WriteLine("Digite o seu PESO: ");
            double.TryParse(Console.ReadLine(), out peso);
            Console.WriteLine("Digite a sua altura: ");
            double.TryParse(Console.ReadLine(), out altura);
            imc = peso / (altura * altura);
            //imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC: {imc}");






        }
    }
}
