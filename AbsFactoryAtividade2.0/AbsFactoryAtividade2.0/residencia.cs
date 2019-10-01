using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class residencia
    {
        private AbsComum _comum;
        private AbsMarcenaria _marc;
        private AbsHidroEletrica _Hidro;


        public residencia (AbsFabrica fabrica)
        {
            _comum = fabrica.porta();
            _comum = fabrica.janela();
            _marc = fabrica.CriarMoveis();
            _Hidro = fabrica.CriarHidro();

        }
    
        public void mostrar ()
        {
            Console.WriteLine(_comum);
            Console.WriteLine(_marc);
            Console.WriteLine(_Hidro);
            

        }

    }
}
