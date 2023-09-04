using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CursoCSharp.Estrutura_de_Controle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {                     
                double somatorio = 0;

                Console.Write("Informe a quantidade de alunos da turma 201: ");
                int.TryParse(Console.ReadLine(), out int tamanhoTurma);

                for (int i = 1; tamanhoTurma >= i; i++)
                {
                    Console.Write("informe a nota do aluno {0}: ", i);
                    double.TryParse(Console.ReadLine(), out double notaAtual);
                    
                    somatorio += notaAtual;
                }
                double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
                Console.WriteLine("Média da Turma: {0}", media);
            {
                  
                // Laço For que faz o somatório da turma de ordem decrescente 


                {
                    double somatorios = 0;                    

                    Console.Write("Informe o tamanho da turma 204: ");
                    int.TryParse(Console.ReadLine(), out int tamanhoTurma1);
                   
                    
                    for (int i = tamanhoTurma1; 0 < i; i--)
                    {
                        Console.Write("informe a nota do aluno {0}: ", i);
                        double.TryParse(Console.ReadLine(), out double notaAtual);

                        somatorios += notaAtual;
                    }
                    double media1 = tamanhoTurma1 > 0 ? somatorios / tamanhoTurma1 : 0;
                    Console.WriteLine("Média da Turma: {0}", media1);
                }
               
            }

            

        }
    }
}
