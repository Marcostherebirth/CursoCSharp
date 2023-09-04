using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    public class Pessoas
    {
        public string Nome;
        public int Idade;
        public double Salario;

        public string Apresentar()
        {
            return string.Format($"Meu nome é {Nome.ToUpper()} e a minha idade é {Idade} anos e o meu salário será de {Salario.ToString("C")}.");
        }


    }


    public class PessoasApresentar
    {
        public static void Executar()
        {
            var Pessoa1 = new Pessoas();
            Pessoa1.Nome = "Marcos";
            Pessoa1.Idade = 42;
            Pessoa1.Salario = 8000;
            Console.WriteLine(Pessoa1.Apresentar());

            var Pessoa2 = new Pessoas();
            Pessoa2.Nome = "Carolina";
            Pessoa2.Idade = 37;
            Pessoa2.Salario = 1200;
            Console.WriteLine(Pessoa2.Apresentar());
        }

    }
}
