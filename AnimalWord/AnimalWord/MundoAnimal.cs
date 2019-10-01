using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWord
{
    class MundoAnimal
    {
        private Abscarnivoro carnivoro;
        private AbsHerbivoro Herbivoro;

        public MundoAnimal(Absfabricacontinente fabrica)
        {
            carnivoro = fabrica.CriarCarnivoro();
            Herbivoro = fabrica.CriarHerbivoro();


        }
        public void executar_cadeia()
        {
            carnivoro.cacar(Herbivoro);
        }

    }
}
