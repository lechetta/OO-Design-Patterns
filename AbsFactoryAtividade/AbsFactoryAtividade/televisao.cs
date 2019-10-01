using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class televisao : AbsQuarto
    {
        public override void Assistir()
        {
            Console.WriteLine(this.GetType().Name + "assistindo TV");
        }

        public override void Dormir()
        {
            throw new NotImplementedException();
        }

        public override void Vestirse()
        {
            throw new NotImplementedException();
        }
        public void ligar()
        {
            Console.WriteLine(this.GetType().Name + "ligando a TV");
        }
        public void desligar()
        {
            Console.WriteLine(this.GetType().Name + "desligando TV");
        }
    }
}
