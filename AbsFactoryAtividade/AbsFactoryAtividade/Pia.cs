using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{

    class Pia : AbsBanheiro
    {
        public override void desligar()
        {
            Console.WriteLine(this.GetType().Name + "desligando a torneira");
        }

        public override void higiene()
        {
            Console.WriteLine(this.GetType().Name + "Lavando as mãos");
        }

        public override void ligar()
        {
            Console.WriteLine(this.GetType().Name + "ligando a torneira");
        }
        public void EscovarOsDentes()
        {
            Console.WriteLine(this.GetType().Name + "escovando os dentes");
        }
    }
}
