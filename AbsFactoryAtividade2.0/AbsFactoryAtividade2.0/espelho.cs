using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class espelho : AbsMarcenaria
    {
        public override void levantar()
        {
            throw new NotImplementedException();
        }

        public override void sentar()
        {
            throw new NotImplementedException();
        }
        public void olhar()
        {
            Console.WriteLine(this.GetType().Name + "se olhando");
        }
    }
}
