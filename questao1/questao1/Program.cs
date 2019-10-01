using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            boleto b = new boleto();
            Ccredito c = new Ccredito();
            concentrador co = new concentrador();

            b.valor = 500.00;
            b.vencimento = "01/05/2019";

            c.vencimento = "29/04/2019";
            c.valor = 520.00;

            co.processar(b);
            co.processar(c);
           
            Console.ReadKey();

        }
    }
}
