using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; /* - Protected é o modificador de acesso
                                                  * - O readonly significa que o atributo
                                                  * não será alterado.*/
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) // Gerando contrutor
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        public int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
    }
    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno Carro1 = new Uno();
            Console.WriteLine(Carro1.Acelerar());
            Console.WriteLine(Carro1.Acelerar());
            Console.WriteLine(Carro1.Frear());
            Console.WriteLine(Carro1.Frear());

        }

    }
}
