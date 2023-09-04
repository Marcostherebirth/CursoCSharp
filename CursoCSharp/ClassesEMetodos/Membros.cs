using CursoCSharp.ClassesEMetodos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Métodos
{
    internal class Membros
    {
        public static void Executar()
        {
            var sicrano = new Pessoa();
            sicrano.Nome = "Marcos";
            sicrano.Idade = 41;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Carolina";
            fulano.Idade = 38;

            fulano.ApresentarNoConsole();
        }


    }
}
