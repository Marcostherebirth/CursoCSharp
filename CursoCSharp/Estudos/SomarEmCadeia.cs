using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        
        public int Diminuir(int a, int b)
        {
            return a - b;
        }
        
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    
   

    internal class ResultadoEmCadeia
    {
        public static void Executar()
        {
            var calculo = new CalculadoraComum();
            int resultado1 = calculo.Somar(3, 4);
            Console.WriteLine("O resultado da soma é {0}", resultado1);

            int resultado2 = calculo.Diminuir(10, 5);
            Console.WriteLine("O resultado diminuição é {0}", resultado2);

            int resultado3 = calculo.Multiplicar(7, 5);
            Console.WriteLine("O resultado da multiplicação é {0}", resultado3);

            int resultado4 = calculo.Dividir(100, 5);
            Console.WriteLine("O resultado da divisão é {0}", resultado4);
        }
    }
}
