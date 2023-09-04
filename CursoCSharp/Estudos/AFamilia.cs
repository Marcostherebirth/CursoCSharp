using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estudos
{
    class AFamilia
    {
        string Nome = "Marcos";
        string Nome2 = "Carolina";
        string Nome3 = "Isadora";
        
        
        public string Apresentar()
        {
            return string.Format($"Olá {Nome}, Olá {Nome2} e Olá {Nome3}");
        } 

        public static void Executar()
        {
            var ApresentarFamilia = new AFamilia();
            Console.WriteLine(ApresentarFamilia.Apresentar());
        } 
        
        
    }
}
