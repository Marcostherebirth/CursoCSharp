using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Isadora", "Marcos", "Carolina" };
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            var nome = new string[] { "Marcos" };
            foreach (var nomes in nome)
            {
                Console.WriteLine("Seja bem vindo {0}",nomes +"!");
            }

            var letrinha = "Up";
            foreach (var letrado in letrinha) 
            {
                Console.WriteLine(letrado);
                
            }

            var palavras = new string[] { "Isadora", "do","Papai" }; 
            foreach (var palavrada in  palavras)
            {
                Console.WriteLine(palavrada);
            }

            var name = "Mac";
            foreach (var names in name)
            {
                Console.WriteLine(names);
            }
            var todos = new string[] { "Pereirão" };
            foreach (var todas in todos)
            {
                Console.WriteLine(todas);
            }
                
        }
    }
}
