using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "Marcos";
            nome = "123";
            Console.WriteLine (nome);

            //int idade;
            var idade = 32;
            Console.WriteLine(idade);

            float idades = 39.4f;
            Console.WriteLine(idades);

            int a = 3;
            a += a;
            
            int b = 2;


            a += b; 

            Console.WriteLine(a);

            string story = "Start. ";
            story += "End.";
            Console.WriteLine(story);




        }
    }
}
