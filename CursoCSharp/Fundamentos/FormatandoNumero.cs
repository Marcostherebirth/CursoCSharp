using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            CultureInfo culturas = new CultureInfo ("en-us");
            Console.WriteLine(valor.ToString("C", culturas));
            Console.WriteLine(valor.ToString("C3", culturas)); //Incluir 3 casas decimais
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("F"));
            //Console.WriteLine(valor.ToString("F3")); Incluir 3 casas decimais
            Console.WriteLine(valor.ToString("#.###", culturas));

            //CultureInfo cultura = new CultureInfo("en-US");
            //Console.WriteLine(valor.ToString("C", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            CultureInfo cultura = new CultureInfo("pt-br");
            Console.WriteLine(valor.ToString("C", cultura));

        }
    }
}
