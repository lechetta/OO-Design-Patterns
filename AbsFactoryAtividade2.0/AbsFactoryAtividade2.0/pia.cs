using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class pia : AbsHidroEletrica
    {
        public override void desligar()
        {
            Console.WriteLine(this.GetType().Name + "desligando");
        }

        public override void ligar()
        {
            Console.WriteLine(this.GetType().Name + "ligando");
        }
        public void EscovarDentes()
        {
            Console.WriteLine(this.GetType().Name + "escovando os dentes");

        }
    }
}
