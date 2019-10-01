using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class espelho : AbsBanheiro
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
        public void olhar()
        {
            Console.WriteLine(this.GetType().Name + "se olhando no espelho");
        }
    }
}
