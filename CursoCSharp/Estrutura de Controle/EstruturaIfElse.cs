using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;
            Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            
            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Você não fez mais do que a sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
            

        }
    }
}
