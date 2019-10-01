using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class DemonioTasmania : AbsCarnivoro
    {
        public override void cacar(AbsHerbivoro h)
        {
            Console.WriteLine(this.GetType().Name + " caçando " + h.GetType().Name);
        }
    }
}
