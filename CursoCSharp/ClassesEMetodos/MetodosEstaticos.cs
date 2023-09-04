using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {   // Método de Classe ou Método estático
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        // Método de instância 
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

    }
    class Calculadora // criei uma nova classe para realizar um teste e funcionou corretamente.
    {
        public static int Dividir(int a, int b)
        {
            return a / b;
        }


    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            


            Console.WriteLine("Resultado da soma = {0}", 
                CalculadoraEstatica.Somar(2, 2));


            Console.WriteLine("Resultado da multiplicação = {0}"
                , CalculadoraEstatica.Multiplicar(2, 2));


            //Nesse método não é preciso a criação de uma instancia
            //basta criar uma nova variável do tipo resultado1 ou 2 e ela
            //recebe a classe CalculadoraEstatica.Subtrair(2, 2);

            var resultado1 = CalculadoraEstatica.Subtrair(2, 2);
            Console.WriteLine("resultado da subtração = {0}", resultado1);

            var resultado2 = Calculadora.Dividir(2, 2);
            Console.WriteLine("resultado da divisão = {0}", resultado2);


            //Método abaixo para ser usado sem a inclusão da palavra "static.
            //devemos criar uma nova instancia para a conseguir acrescentar a variável 
            // somar, subtrair, dividir e multiplicar.


            //CalculadoraEstatica calculo1 = new CalculadoraEstatica();
            //Console.WriteLine(calculo1.Multiplicar(2, 2));


            //CalculadoraEstatica calculo2 = new CalculadoraEstatica();
            //Console.WriteLine(calculo2.Subtrair(2, 6));

            //CalculadoraEstatica calculo3 = new CalculadoraEstatica();
            //Console.WriteLine(calculo3.Somar(2, 4));

            //Calculadora calculo4 = new Calculadora();
            //Console.WriteLine(calculo4.Dividir(8, 2));

        }
    }
}
