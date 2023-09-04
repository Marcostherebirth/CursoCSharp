using CursoCSharp.Estrutura_de_Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 1;

        public static void Executar()
        {
            //Acessar a variável dentro do método executar
            //Console.WriteLine (a);

            var desafio = new DesafioAtributo();
            
            for (int i = 10; i > desafio.a; i++)
            {
                Console.WriteLine(desafio.a);
            }
            
           
          

            
        }
    }
}
