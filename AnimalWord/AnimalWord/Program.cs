using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class Program
    {
        static void Main(string[] args)
        {

            Absfabricacontinente africa = new africa();
            MundoAnimal MA = new MundoAnimal(africa);
            MA.executar_cadeia();
            Console.ReadKey();


            Absfabricacontinente AmericaNorte = new AmericaNorte();
            MA = new MundoAnimal(AmericaNorte);
            MA.executar_cadeia();
            Console.ReadKey();



        }
    }
}
