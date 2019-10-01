using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcesso
{
    class ClasseEstatica
    {
        static int atributo;
        static ClasseEstatica()
        {
            atributo = 10;
        }
        public static int mostraValor()
        {
            return atributo;
        }
    }
}
