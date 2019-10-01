using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    class Program
    {
        static void Main(string[] args)
        {
            Operador NetOperador = new NetOperador();
            Operador ServerOperator = new ServerOperator();
            Operador SWOperador = new SWOperador();

            NetOperador.SetNext(ServerOperator).SetNext(SWOperador);

            string Netrequest = "premium";
            Console.WriteLine(NetOperador.Handle(Netrequest));

            Console.ReadKey();
        }
    }
}
