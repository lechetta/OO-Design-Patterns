using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class bufalo : AbsHerbivoro
    {
        public override void pastar()
        {
            Console.Write(this.GetType().Name + "pastando");
        }
    }
}
