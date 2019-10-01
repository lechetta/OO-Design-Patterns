using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class GuardaRoupa : AbsQuarto
    {
        public override void Assistir()
        {
            throw new NotImplementedException();
        }

        public override void Dormir()
        {
            throw new NotImplementedException();
        }

        public override void Vestirse()
        {
            throw new NotImplementedException();
        }
        public void abrir()
        {
            Console.WriteLine(this.GetType().Name + "abrindo a porta");
        }
        public void fechar()
        {
            Console.WriteLine(this.GetType().Name + "fechando a porta");
        }
    }
}
