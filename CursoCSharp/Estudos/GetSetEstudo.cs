using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;


        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {
            
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
        public class GetSetEstudo
        {
            public static void Executar()
            {
                var moto1 = new Moto("Yamaha", "CBX 1500", 2000);
                Console.WriteLine(moto1.Marca);
                Console.WriteLine(moto1.Modelo);
                Console.WriteLine(moto1.Cilindrada);


                var moto2 = new Moto();
                {
                    moto2.SetMarca("Honda");
                    moto2.SetModelo("CB500");
                    moto2.SetCilindrada(5000);

                    Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() +
                        " " + moto2.GetCilindrada());
                }
            }
        }


    }




    
}
