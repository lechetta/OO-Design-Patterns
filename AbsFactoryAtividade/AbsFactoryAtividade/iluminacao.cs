using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class iluminacao : AbsComum
    {
        public override void abrir()
        {
            throw new NotImplementedException();
        }

        public override void fechar()
        {
            throw new NotImplementedException();
        }
        public void ligar()
        {
            Console.WriteLine(this.GetType().Name + "ligar");
        }
        public void desligar()
        {
            Console.WriteLine(this.GetType().Name + "desligar");
        }
    }
}
