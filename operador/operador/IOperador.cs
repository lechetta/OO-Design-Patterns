using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    interface IOperador
    {


        IOperador SetNext(IOperador handler);
        object Handle(object request);
        
    }
}
