﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        string Marca;
        string Modelo;
        int Cilindrada;

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
        
        public class GetSet
        {
            public static void Executar()
            {
                var moto1 = new Moto("Kawazaki", "RD-300NX", 1000);
                Console.WriteLine(moto1.Marca);
                Console.WriteLine(moto1.Modelo);
                Console.WriteLine(moto1.Cilindrada);

                var moto2 = new Moto();
                {
                    moto2.SetMarca("Honda");
                    moto2.SetModelo("CG Titan");
                    moto2.SetCilindrada(150);
                    Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() +
                        " " + moto2.GetCilindrada());
                }


            }
        }
    }
}