using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class ConcSala : AbsFabrica
    {


        public override AbsHidroEletrica CriarHidro()
        {
            return new iluminação();
        }

        public override AbsMarcenaria CriarMoveis()
        {
            return new mesa();

        }

        public override AbsComum janela()
        {
            return new janela();
        }

        public override AbsComum porta()
        {
            return new porta();
        }
        public AbsMarcenaria espelho()
        {
            return new espelho();
        }
        public AbsMarcenaria cadeira()
        {
            return new cadeira();
        }
    }
}
