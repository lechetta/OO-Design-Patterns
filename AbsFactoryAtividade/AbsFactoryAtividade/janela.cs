using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class janela : AbsComum
    {
        public override void abrir()
        {
            Console.WriteLine(this.GetType().Name + "Abrindo");
        }

        public override void fechar()
        {
            Console.WriteLine(this.GetType().Name + "fechando");
        }
    }
}
