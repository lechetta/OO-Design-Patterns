using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsFabrica Banheiro = new ConcBanheiro();
            residencia re = new residencia(Banheiro);
            Console.WriteLine("banheiro");
            re.mostrar();
            Console.ReadKey();

            AbsFabrica quarto = new ConcQuarto();
            re = new residencia(quarto);
            Console.WriteLine("quarto");
            re.mostrar();
            Console.ReadKey();

            AbsFabrica salaJantar = new ConcSala();
            re = new residencia(salaJantar);
            Console.WriteLine("Sala de Jantar");
            re.mostrar();
            Console.ReadKey();
        }
    }
}
