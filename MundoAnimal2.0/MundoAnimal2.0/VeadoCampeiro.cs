using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class VeadoCampeiro : AbsHerbivoro
    {
        public override void pastar()
        {
            Console.WriteLine(this.GetType().Name + " pastando ");

        }
    }
}
