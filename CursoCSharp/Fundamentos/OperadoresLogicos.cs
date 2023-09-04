using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // trabalho 1 e 2 executados = Comprou TV 50
            Console.WriteLine($"Comprou TV de 50, {comprouTv50}.");
           
            var comprouTV32 = executouTrabalho1 || executouTrabalho2; // Trabalho 1 ou 2 excutado = Comprou TV 32
            Console.WriteLine($"Comprou TV de 32, {comprouTV32}.");
           
            var comprouSorvete = executouTrabalho1 ^ executouTrabalho2; // Trabalho 1 ou 2 executado = Comprou Sorvete
            Console.WriteLine($"Comprou Sorvete em familia, {comprouSorvete}."); 
            
            var naocomprouSorvete = executouTrabalho1 !& executouTrabalho2; // Trabalho 1 e 2 não executados = Sem Sorvete
            Console.WriteLine($"Sem sorvete é mais saudável, {naocomprouSorvete}.");





        }
    }
}
