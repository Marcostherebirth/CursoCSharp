using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);// atribuição por valor
            var p2 = new Produto("Caneta", 1.89);// atribuição por valor
            var p3 = p2; /* atribuição por referência.Ambos aponto para o mesmo espaço
                          * de memória*/
            Console.WriteLine(p1 == p2);// comparando endereço de memória
            Console.WriteLine(p3 == p2);// comparando endereço por referência

            Console.WriteLine(p1.Equals(p2)); /* esse método serve para ver
                                               * o produto p1 é igual ao produto
                                               * p2. Ele compara o endereço de memória*/





        }
    }
}
