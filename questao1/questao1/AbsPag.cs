using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    abstract class AbsPag : Ipag
    {
        public virtual double valor { get; set; }
        public virtual string vencimento { get; set; }
    }
}
