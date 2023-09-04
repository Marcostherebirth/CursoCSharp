using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    internal class CalculoMassaRadiotiva
    {
        public static void Executar()
        {
            double massa;
            int seg = 0;

            Console.WriteLine("Entre com o valor da massa");
            massa = Convert.ToDouble(Console.ReadLine());

            while (massa >= 1.45)
            {   
                massa -= (massa * 0.13);
                seg = seg + 20; // ou abaixo
               // seg += 20; 
                for (int i = 0; i < seg; i++)
                
                    Console.WriteLine("Passado {0} segundos a massa é de {1}", seg , massa);
                {
                    Console.WriteLine("Foram nessesários {0} segundos para a massa decair ", seg);
                }           
                             

            }


        }
    }
}
