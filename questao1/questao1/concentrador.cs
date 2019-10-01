using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class concentrador
    {
        public bool pagamento;

       

        public bool processar(Ipag pag)
        {

            Console.WriteLine(" valor a pagar "  + pag.valor + " data de vencimento " + pag.vencimento);
            return true;
        }

    }
}
