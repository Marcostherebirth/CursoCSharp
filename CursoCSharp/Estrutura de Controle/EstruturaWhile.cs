using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            bool numeroEncontrado = false;
            var random = new Random();
            var numeroSecreto = random.Next(1, 16);
            var tentativas = 0;
            var tentativasRestantes = 5;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                tentativas++;
                tentativasRestantes--;

                Console.WriteLine("Digite o seu Palpite");
                int.TryParse(Console.ReadLine(), out palpite);

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    Console.WriteLine("O número encontrado é o {0} em {1} tentativas", numeroSecreto, tentativas);
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor...Tente novamento");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);

                }
                else
                {
                    Console.WriteLine("Maior...Tente novamento");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }

        }
    }
}
