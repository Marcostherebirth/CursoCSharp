using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{


    public class CarroOpicional
    {
        double desconto1 = 0.1f;
        double desconto2 = 0.2f;
        string nome;

        public string Nome
        {
            get
            {
                return "Opicional: " + nome;
            }
            set
            {
                nome = value;
            }
        }
        //propriedade autoimplementada

        public double Preco { get; set; }


        public double PrecoComDesconto1
        {
            get => Preco - (desconto1 * Preco);

            set => Preco = value;
        }


        //=> Preco - (desconto1 * Preco);



        public double PrecoComDesconto2
             // Somente leitura - sem a inclusão do get e set.
             => Preco - (desconto2 * Preco); //lambda


        public CarroOpicional()
        {

        }

        public CarroOpicional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

        }

    }

    internal class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpicional("Ar condicionado", 34999.99);
            Console.WriteLine(op1.Nome + ", Preço - " + op1.PrecoComDesconto1.ToString("C"));

            var op2 = new CarroOpicional();
            op2.Nome = "Sem Ar";
            op2.Preco = 35000.19;
            Console.WriteLine("Novo Gol");
            Console.WriteLine("Preço: " + op2.Preco.ToString("C"));
            Console.WriteLine("Preço com desconto: "+ op2.PrecoComDesconto2.ToString("C"));

        }



    }




}

