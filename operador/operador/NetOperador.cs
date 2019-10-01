using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    class NetOperador : Operador
    {

        banco B = new banco();
        public override object Handle(object request)
        {
            if (B.saldo.Equals("1000000"))
            {
                return $"NetOperador: convocado para {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
