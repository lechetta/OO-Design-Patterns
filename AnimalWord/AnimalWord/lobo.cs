using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class lobo : Abscarnivoro
    {
        public override void cacar(AbsHerbivoro h)
        {
            Console.WriteLine(this.GetType().Name + "caça" + h.GetType().Name);
        }
    }
}
