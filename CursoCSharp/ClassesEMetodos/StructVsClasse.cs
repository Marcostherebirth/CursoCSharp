using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    internal class StructVsClasse
    {

        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto2
        {
            public int X;
            public int Y;
        }

        
        public static void Executar()
        {
            SPonto Ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto CopiaPonto1 = Ponto1; // Atribuição por VALOR!!!
            Ponto1.X = 3;
            Console.WriteLine("Ponto 1 X:{0}", Ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X:{0}", CopiaPonto1.X);

            CPonto2 Ponto2 = new CPonto2 { X = 2, Y = 4 };
            CPonto2 CopiaPonto2 = Ponto2; // Atribuição por REFERÊNCIA!!!
            Ponto2.X = 4;
            Console.WriteLine("Ponto 2 X:{0}", Ponto2.X);
            Console.WriteLine("Cópia Ponto 2 X:{0}", CopiaPonto2.X);
        }
    }
}
