using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Treinamentos
{
    internal class Testes_1
    {
        public static void Executar()
        {
            bool estaChovendo = true;
            string resposta;
            Console.WriteLine("Está chovendo? (S/N):");
            resposta = Console.ReadLine();

            if (estaChovendo = resposta.ToLower() == "s")
            {
                Console.WriteLine("Está chovendo no momento!!!");
            }
            else
            {
                Console.WriteLine("Não está chovendo no momento!!!");
            }
        }
    }
}
