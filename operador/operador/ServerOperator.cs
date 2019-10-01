using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    class ServerOperator :Operador
    {

        banco B = new banco();
        public override object Handle(object request)
        {
            if (B.cnpj != null)
            {
                return $"ServerOperator: convocado para {request.ToString()}.\n";
            }
            else
            { 
                return base.Handle(request);
            }
           
        }

      
    }
}
