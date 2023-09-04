using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 1;
            Console.WriteLine("Numeros decrescentes pares entre 20 e {0}", intervalo);

            for (int i = 20; i > intervalo; i--)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            //int intervalos = 20;
            //Console.WriteLine("Numeros crescentes pares entre 01 e {0}", intervalos);

            //for (int i = 01; i < intervalos; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    Console.Write(i + " ");
            //}
        }
    }
}
