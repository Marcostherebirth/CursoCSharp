using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            bool BomComportamento = true;
            string resultado = nota >= 7.0 && BomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
