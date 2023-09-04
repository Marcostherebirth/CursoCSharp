using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {
            
        
        }

        public string Apresentar()
        {
            return string.Format($"Tenho um carro {Modelo}, da empresa {Fabricante}, do ano {Ano}. ");
        }
    }

    class ConstrutoresEstudo
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "iX35";
            carro1.Fabricante = "Hyundai";
            carro1.Ano = 2017;
            Console.WriteLine(carro1.Apresentar());

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Modelo}, {carro2.Fabricante}, {carro2.Ano}");
        }




    }
}
