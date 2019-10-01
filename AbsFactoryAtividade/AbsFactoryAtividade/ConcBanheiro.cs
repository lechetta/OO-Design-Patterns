using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class ConcBanheiro : AbsFabrica
    {
        public override AbsBanheiro CriarBanheiro()
        {
            return new Chuveiro();
            return new Pia();

        }

        public override AbsComum CriarComodo()
        {
            throw new NotImplementedException();
        }

        public override AbsQuarto CriarQuarto()
        {
            throw new NotImplementedException();
        }

        public override AbsSalaJantar CriarSala()
        {
            throw new NotImplementedException();
        }
    }
}
