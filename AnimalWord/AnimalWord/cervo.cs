using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class cervo : AbsHerbivoro
    {
        public override void pastar()
        {
            Console.WriteLine(this.GetType().Name + "pstando");
        }
    }
}
