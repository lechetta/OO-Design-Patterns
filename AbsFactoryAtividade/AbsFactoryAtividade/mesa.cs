using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class mesa : AbsSalaJantar
    {
        public override void AssistirTV()
        {
            Console.WriteLine(this.GetType().Name + "assistindo TV");
        }

        public override void Descansar()
        {
            throw new NotImplementedException();
        }

        public override void JogarVideoGame()
        {
            throw new NotImplementedException();
        }

        public override void levantar()
        {
            Console.WriteLine(this.GetType().Name + "Levantando");
        }

        public override void LigarOsom()
        {
            Console.WriteLine(this.GetType().Name + "Ligando o som");

        }

        public override void sentar()
        {
            Console.WriteLine(this.GetType().Name + "sentando");

        }
        public void comer()
        {
            Console.WriteLine(this.GetType().Name + "comendo");
        }
    }
}
