using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal2._0
{
    class AnimalWord
    {
        private AbsCarnivoro _carnivoro;
        private AbsHerbivoro _herbivoro;

        public AnimalWord(AbsFabrica fabrica)
        {
            _carnivoro = fabrica.carnivoro();
            _herbivoro = fabrica.herbivoro();


       }

        public void executar_cadeia()
        {
            _carnivoro.cacar(_herbivoro);
        }
    }
}
