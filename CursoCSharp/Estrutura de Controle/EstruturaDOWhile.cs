using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaDOWhile
    {
        public static void Executar()
        {
            string nome;

            do
            {
                Console.WriteLine("Qual o seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Seja Bem Vindo {0}", nome);
                Console.WriteLine("Deseja Continuar? (S/N)");
                nome = Console.ReadLine();
            }
            while (nome.ToLower() == "s");
            {
                if (nome.ToLower() == "n")
                {
                    Console.WriteLine("Tem certeza? (S/N)");
                    nome = Console.ReadLine();
                }

                else if (nome.ToLower() == "s")
                {
                    Console.WriteLine("Obrigado");
                }

               
            }











        }

    }
}
