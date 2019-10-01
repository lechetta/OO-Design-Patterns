using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade2._0
{
    class porta : AbsComum
    {
        int fechadura { get => fechadura; set => fechadura = value; }

        public void Porta()
        {

        }

        public override void abrir()
        {
            Console.WriteLine(this.GetType().Name + "abrindo");    
        }
        
        public override void fechar()
        {
            Console.WriteLine(this.GetType().Name + "fechando");
        }

    }
}
