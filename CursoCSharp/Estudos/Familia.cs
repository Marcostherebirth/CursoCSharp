using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    internal class Familia
    {
        string nome1;
        string nome2;
        string nome3;              

        public static void Executar()
        {
            Familia novosnomes = new Familia();
            novosnomes.nome1 = "Marcos";
            novosnomes.nome2 = "Carolina";
            novosnomes.nome3 = "Isadora";

            Console.WriteLine("Eu {0} e {1} e {2}, vamos ter uma casa nova",
                novosnomes.nome1, novosnomes.nome2, novosnomes.nome3);

            var novosnomes2 = new Familia();
            novosnomes2.nome1 = "Cesar";
            novosnomes2.nome2 = "Juliana";
            novosnomes2.nome3 = "Gabriela";

           






        }
    }
}
