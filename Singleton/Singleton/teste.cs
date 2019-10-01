using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class teste
    {
        static int N;
        public teste()
        {
            N = 10;
        }
        public int expor()
        {
            return N;
        }
        public void alterar()
        {
            N = 30;
        }
    }
}
