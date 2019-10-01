using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    abstract class Operador : IOperador
    {
        private IOperador _nextOperador;

        public virtual object Handle(object request)
        {
            if(this._nextOperador != null)
            {
                return this._nextOperador.Handle(request);
            }else
            {
                return null;
            }
        }

        public IOperador SetNext(IOperador handler)
        {
            this._nextOperador = handler;
            return handler;
        }
    }
}
