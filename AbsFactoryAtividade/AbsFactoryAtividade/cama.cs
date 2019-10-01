using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class cama : AbsQuarto
    {
        public override void Assistir()
        {
            Console.WriteLine(this.GetType().Name + "assistindo TV");
        }

        public override void Dormir()
        {
            Console.WriteLine(this.GetType().Name + "Dormindo");
        }

        public override void Vestirse()
        {
            throw new NotImplementedException();
        }
        public void levantar()
        {
            Console.WriteLine(this.GetType().Name + "levantando");
        }
        public void deitar()
        {
            Console.WriteLine(this.GetType().Name + "deitando");
        }
    }
}
