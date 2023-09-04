using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    internal class EstudoDoWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            bool numeroEncontrado = false;
            Random random = new Random();
            var numeroSecreto = random.Next(1, 16);
            int tentativas = 0;
            int tentativasRestantes = 5;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite o palpite:");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    Console.WriteLine("O número é o {0}, em {1} tentativas.", numeroSecreto, tentativas);
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior...Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
