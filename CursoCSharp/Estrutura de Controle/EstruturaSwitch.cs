using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {

            Console.WriteLine("Avalie a minha nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);
            Console.WriteLine($"Nota escolhida: {nota}");

            switch (nota)
            {
                case 0:
                    Console.WriteLine("A sua avaliação foi Péssima");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("A sua avaliação foi:(Ruim)");
                    break;
                case 3:
                    Console.WriteLine("A sua avaliação foi:(Regular)");

                    break;
                case 4:
                    Console.WriteLine("A sua avaliação foi:(Boa)");

                    break;
                case 5:
                    Console.WriteLine("A sua avaliação foi:(Ótima)");

                    break;
                default:
                    Console.WriteLine("Nota inválida.");
                    break;
            }
            Console.WriteLine("Obrigado por responder");

        }
    }
}
