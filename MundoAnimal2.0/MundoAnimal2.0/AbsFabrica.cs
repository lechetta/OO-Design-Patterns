using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    abstract class AbsFabrica
    {
        public abstract AbsCarnivoro carnivoro();
        public abstract AbsHerbivoro herbivoro();
    }
}
