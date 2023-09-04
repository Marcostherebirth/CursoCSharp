using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10; // Conversão Implicita
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7; // Conversão Explicita
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string entrada = Console.ReadLine();
            int numero;
            int.TryParse(entrada, out numero);
            
            Console.WriteLine("O primeiro número é: {0}", numero);

            //segundo opção em um formato menor da anterior
            Console.Write("Digite o segundo número:");
            int.TryParse(Console.ReadLine(), out int numero2);//declarando ao variável dentro do Console.ReadLine
            Console.Write("O segundo número é: {0}", numero2);  





        }
    }
}
