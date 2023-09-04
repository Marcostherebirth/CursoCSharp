using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
       public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;
            CultureInfo.CurrentCulture = new CultureInfo("pt-br");
            Console.WriteLine("O " + nome + " é bom e a marca " 
                + marca + " está custando " + preco.ToString("C") + ".");
            Console.WriteLine("O " + nome.ToUpper() + " é bom e a marca "
                + marca.ToUpper() + " está custando " + preco.ToString("C") + ".");
            Console.WriteLine("O {0} é bom e a marca {1} " +
                "está custando {2}", nome, marca, preco.ToString("C") + ".");
            Console.WriteLine($"O {nome.ToUpper()} é bom e a marca {marca} está custado! {preco.ToString ("C")}" + ".");

            Console.WriteLine(preco.ToString("#.##")); // coloca a quantidade de decimais
            Console.WriteLine(preco.ToString("C")); // moeda corrente no sistema
            Console.WriteLine(preco.ToString("P")); // percetual
            Console.WriteLine(preco.ToString("F2")); // quantidade de 0 depois da vírgula. 
          
            //Console.WriteLine(preco.ToString ("D10"));
            /* coloca o numero de casas decimais a direita
            * mas vale para números inteiros*/







        }
    }
}
