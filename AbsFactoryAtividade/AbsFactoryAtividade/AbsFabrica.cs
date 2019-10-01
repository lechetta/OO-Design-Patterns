using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
   abstract class AbsFabrica
    {
        public abstract AbsBanheiro CriarBanheiro();
        
        public abstract AbsQuarto CriarQuarto();
        public abstract AbsSalaJantar CriarSala();
        public abstract AbsComum CriarComodo();
    }
}
