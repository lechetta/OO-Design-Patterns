using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class financeiro
    {
        public bool ConsultaDebito(string cpf)
        {
            if (cpf.Equals("8787"))
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
