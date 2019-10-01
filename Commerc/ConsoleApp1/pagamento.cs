using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class pagamento
    {
        public double Pagar(Iproducts p)
        {
            double result = p.Preco * p.Quantidade;
            return result;
        }
        
    }
}
