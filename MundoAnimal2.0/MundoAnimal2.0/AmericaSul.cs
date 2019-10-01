using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class AmericaSul : AbsFabrica
    {
        public override AbsCarnivoro carnivoro()
        {
            return new OncaPintada();
        }

        public override AbsHerbivoro herbivoro()
        {
            return new VeadoCampeiro();
        }
    }
}
