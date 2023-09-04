using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {

            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            //Console.Write("Informe por aqui a sua pretenção salarial: ");
            //double salario = double.Parse(Console.ReadLine(),
            //CultureInfo.CurrentCulture = new CultureInfo("en-us"));
            //Console.WriteLine($"{nome} {idade} anos e salário {salario.ToString("C")}");

            //Console.Write("Informe por aqui a sua pretenção salarial: ");
            //double salarios = double.Parse(Console.ReadLine(),
            //CultureInfo.CurrentCulture = new CultureInfo("pt-br"));
            //Console.WriteLine($"{nome} {idade} anos e salário {salarios.ToString("C")}");

            Console.Write("Informe por aqui a sua pretenção salarial: ");
            CultureInfo Cultura = new CultureInfo("en-us");
            double salarionovo = double.Parse(Console.ReadLine(), Cultura);
            
            //Console.WriteLine($"{nome} {idade} anos e salário {salarios.ToString("C")}");










        }
    }
}
