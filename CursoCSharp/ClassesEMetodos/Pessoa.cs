using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa // Classe do tipo 
    {
        public string Nome; // Que possue dois atrubitos
        public int Idade;
        


        // Abaixo temos dois comportamentos
        public string Apresentar()
        {


            if (Nome == "" && Idade == 0 )
            {
                Console.WriteLine("Informação inválida");
            }


            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos" );
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public static void Executar()
        {

        }
        
       

    }
}
