using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;    
            var booleano = true;

            Console.WriteLine(- ValorNegativo);
            Console.WriteLine(!booleano);

            numero1++; /* numero1 = numero1 + 2; (o ++ depois da variável é chamado de 
                        * pós-fixado e o -- antes da variável é chamado de pré-fixado*/
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);
            
            Console.WriteLine($"O número: {numero1} é igual ao número: {numero2}");
            //Console.WriteLine($"{numero1} {numero2}");
            Console.WriteLine(numero1==numero2);
        }
    }
}
