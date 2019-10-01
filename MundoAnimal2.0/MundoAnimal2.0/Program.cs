using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsFabrica oceania = new Oceania();
            AnimalWord A = new AnimalWord(oceania);
            A.executar_cadeia();
            Console.ReadKey();

            AbsFabrica AmericaSul = new AmericaSul();
            A = new AnimalWord(AmericaSul);
            A.executar_cadeia();
            Console.ReadKey();

        }
    }
}
