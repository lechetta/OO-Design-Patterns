using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalClass NC = new NormalClass();

            NC.atributo = 30;
            Console.WriteLine(NC.atributo);
            Console.ReadKey();

            NormalClass NC2 = new NormalClass();
            Console.WriteLine(NC == NC2);
            Console.ReadKey();

            int valor = ClasseEstatica.mostraValor();
            Console.WriteLine(valor);
            Console.ReadKey();
            var obj1 = ClasseSingleton.Instancia();
            obj1.mensagem = "teste do singleton";
            Console.WriteLine(obj1.mensagem);
            Console.ReadKey();

            var obj2 = ClasseSingleton.Instancia();
            Console.WriteLine(obj2.mensagem);
            Console.WriteLine(obj1 == obj2);
            Console.ReadKey();
        }
    }
}
