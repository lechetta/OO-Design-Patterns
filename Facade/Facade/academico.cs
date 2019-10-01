using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class premium
    {
        public bool verificarPremium( banco B)
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
