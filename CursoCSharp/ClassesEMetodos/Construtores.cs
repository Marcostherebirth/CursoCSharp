using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.ClassesEMetodos;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public string Cor;
        

        public Carro(string fabricante, string modelo, int ano, string cor)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
            Cor = cor;
        }
        public Carro ()
        {

        }
    }

    internal class Construtores
    {
       
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Fit";
            carro1.Fabricante = "Honda";
            carro1.Ano = 2020;
            carro1.Cor = "Prata";

            Console.WriteLine(
                $"{carro1.Fabricante.ToUpper()} {carro1.Modelo.ToUpper()}  " +
                $"{carro1.Ano} {carro1.Cor}");

            var carro2 = new Carro ("Lougan", "Fiat", 2020, "Preto");
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano} {carro2.Cor}");

            var carro3 = new Carro()
            {
                Modelo = "Gol",
                Fabricante = "volkswagen",
                Ano = 2019,
                Cor = "Branca",
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano} {carro3.Cor}");
            
               
            

            
        }

    }
}
