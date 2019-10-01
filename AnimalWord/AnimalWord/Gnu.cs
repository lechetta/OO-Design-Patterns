using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class Gnu : AbsHerbivoro
    {
        public override void pastar()
        {
            Console.WriteLine(this.GetType().Name + "pstando");
        }
    }
}
