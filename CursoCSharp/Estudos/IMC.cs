using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    internal class IMC
    {
        public static void Executar()
        {
            double peso, altura, imc;

            Console.WriteLine("Teste de IMC");

            Console.WriteLine("Digite o seu peso");
            peso = Convert.ToDouble(Console.ReadLine()); //<= uma opção lega para converter
            

            Console.WriteLine("Digite a sua altura");
            double.TryParse(Console.ReadLine(), out altura);

            //Processamento e sáida 
            //imc = peso / altura * altura;
            imc = peso / Math.Pow(altura, 2);



            Console.WriteLine("Seu imc é {0}", imc);


            switch (imc)
            {
                case var _ when imc <= 18.5:
                    Console.WriteLine("Peso abaixo do normal");
                    break;
                case var _ when imc > 18.5 && imc < 25:
                    Console.WriteLine("Peso normal");
                    break;
                case var _ when imc >= 25 && imc < 30:
                    Console.WriteLine("Sobre o Peso");
                    break;
                case var _ when imc >= 30 && imc < 35:
                    Console.WriteLine("Grau de Obesidade I");
                    break;
                case var _ when imc >= 35 && imc < 40:
                    Console.WriteLine("Grau de Obesidade II");
                    break;
                case var _ when imc >= 40:
                    Console.WriteLine("Grau de Obesidade III");
                    break;
                    


                   
            }
        }
    }   
}
