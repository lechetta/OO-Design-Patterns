using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class AmericaNorte : Absfabricacontinente
    {
        public override Abscarnivoro CriarCarnivoro()
        {
            return new lobo();
            throw new NotImplementedException();
        }

        public override AbsHerbivoro CriarHerbivoro()
        {
            return new bufalo();
            throw new NotImplementedException();
        }
    }
}
