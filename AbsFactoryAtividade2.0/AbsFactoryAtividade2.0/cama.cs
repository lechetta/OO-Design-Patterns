using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class cama : AbsMarcenaria
    {
        public override void levantar()
        {
            Console.WriteLine(this.GetType().Name + "levantando");
        }

        public override void sentar()
        {
            throw new NotImplementedException();
        }
        public void dormir()
        {
            Console.WriteLine(this.GetType().Name + "dormindo");

        }
        public void deitar()
        {
            Console.WriteLine(this.GetType().Name + "deitando");

        }
    }
}
