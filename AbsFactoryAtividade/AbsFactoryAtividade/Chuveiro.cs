using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class Chuveiro : AbsBanheiro
    {

        public override void desligar()
        {
            Console.WriteLine(this.GetType().Name + "desligando o chuveiro");
        }

        public override void higiene()
        {
            Console.WriteLine(this.GetType().Name + "Tomando banho");
        }

        public override void ligar()
        {
            Console.WriteLine(this.GetType().Name + "ligando o chuveiro");
        }
    }
}
