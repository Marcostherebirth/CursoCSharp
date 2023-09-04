using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    internal class PercorrerPercurso
    {
        public static void Executar()
        {
            double velocidade, distancia;
            int horas = 1, minutos = 60, segundos = 3600;

            Console.Write("Digite a quilometragem: ");
            double.TryParse(Console.ReadLine(), out distancia);
            // 1000 metros / 80 por horas 
            Console.Write("Digite a velocidade: ");
            double.TryParse(Console.ReadLine(), out velocidade);

            horas = (int)(distancia / velocidade);
            
                        //tempo = tempo * 3600; //convertemos de horas para segundos
            minutos *= (int)horas;  //parte inteira
            horas = (int)minutos / 60;
            //segundos = (int)minutos * 60;
            //tempo = tempo % 3600;  // o resto

            //horas = (int)minutos / 3600;

            Console.WriteLine($"{horas} Horas , {minutos} minutos");






        }
    }
}
