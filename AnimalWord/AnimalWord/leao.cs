using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class leao : Abscarnivoro
    {
        public override void cacar(AbsHerbivoro h)
        {
            Console.WriteLine(GetType().Name + " caça " + h.GetType().Name);
        }
    }
}
