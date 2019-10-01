using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    class protestos
    {
        public bool verificarProtestos(banco B)
        {
            if (B.nome.Equals("Gustavo"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
