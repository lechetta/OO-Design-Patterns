using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class renda
    {
        private static double saldo;
        banco B = new banco();
        double limite = saldo * 0.1;
        public bool CalcularSaldo(banco B)
        {
            

            if (B.saldo.Equals("1000000"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
