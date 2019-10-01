using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class vaso : AbsBanheiro
    {
        public override void desligar()
        {
            throw new NotImplementedException();
        }

        public override void higiene()
        {
            throw new NotImplementedException();
        }

        public override void ligar()
        {
            throw new NotImplementedException();
        }
        public void N1()
        {
            Console.WriteLine(this.GetType().Name + "Fazendo o 1");

        }
        public void N2()
        {
            Console.WriteLine(this.GetType().Name + "Fazendo o 2");

        }
    }
}
