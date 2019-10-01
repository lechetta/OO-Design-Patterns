using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class cadeira : AbsMarcenaria
    {
        public override void levantar()
        {
            Console.WriteLine(this.GetType().Name + "levantando");
        }

        public override void sentar()
        {
            Console.WriteLine(this.GetType().Name + "sentando");

        }
    }
}
