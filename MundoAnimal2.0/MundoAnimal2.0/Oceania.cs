using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class Oceania : AbsFabrica
    {
        public override AbsCarnivoro carnivoro()
        {
            return new DemonioTasmania();
        }

        public override AbsHerbivoro herbivoro()
        {
            return new Canguru();
        }
    }
}
