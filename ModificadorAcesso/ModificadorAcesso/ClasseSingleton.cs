using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcesso
{
    public class ClasseSingleton
    {
        static ClasseSingleton _instacia;
        public static ClasseSingleton Instancia()
        {
            if (_instacia == null)
            {
                _instacia = new ClasseSingleton();
                return _instacia;
            }
            else
            {
                return _instacia;
            }
        }

        private ClasseSingleton()
        {

        }
        public string mensagem{get; set;}

    }
}
