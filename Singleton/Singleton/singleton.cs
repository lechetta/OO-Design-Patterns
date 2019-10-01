using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class singleton
    {
        static singleton _instancia;
        private singleton()
        {
            
        }
       public static singleton CriarSingleton()
        {
            if(_instancia == null)
            {
                _instancia = new singleton();
            }
            return _instancia;
        }
    }
}
