using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {

            string[] alunos = new string[5];
            alunos[0] = "Marcos";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            double somatorio = 0;

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("Segue a média {0}", media);

            char[] letras = { 'A', 'R', 'R', 'A', 'I' };
            string palavras = new string(letras);
            Console.WriteLine(palavras);

            string[] palavra = { "Eu", "estou", "aprendendo", "C#." };
            foreach (var palavrasn in palavra)
            {
                Console.WriteLine(palavrasn);
            }

        }
    }
}
