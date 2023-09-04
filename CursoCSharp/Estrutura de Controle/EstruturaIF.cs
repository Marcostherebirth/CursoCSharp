using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            bool BomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N)");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s") 
            //    BomComportamento = true;

            //BomComportamento = entrada == "S" || entrada == "s";
            
            BomComportamento = entrada.ToLower() == "s";
            
            if (nota >= 9.0 && BomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

            

        }
    }
}
