using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente // Existe a possibilidade de
                            // trocar o método (class / struct)
    {
        public string Nome;
        public int Idade;
    }


    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int CopiaNumero = numero;
            Console.WriteLine($"{numero}" + " e " + $"{CopiaNumero}");
            numero++;
            Console.WriteLine($"{numero}" + " e " + $"{CopiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Marcos",
                Idade = 42
            };
            Dependente CopiaDepedente = dep;
            
            Console.WriteLine($"{dep.Nome}" + " e " + $"{CopiaDepedente.Nome}");
            Console.WriteLine($"{dep.Idade}" + " e " + $"{CopiaDepedente.Idade}");

            CopiaDepedente.Nome = "Carolina";
            dep.Idade = 37;

            Console.WriteLine($"{dep.Nome}" + " e " + $"{CopiaDepedente.Nome}");
            Console.WriteLine($"{dep.Idade}" + " e " + $"{CopiaDepedente.Idade}");
        }
    }
}
