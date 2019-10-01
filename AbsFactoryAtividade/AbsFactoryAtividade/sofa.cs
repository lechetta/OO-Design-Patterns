using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class sofa : AbsSalaJantar
    {
        public override void AssistirTV()
        {
            Console.WriteLine(this.GetType().Name + "assistindo TV");

        }

        public override void Descansar()
        {
            Console.WriteLine(this.GetType().Name + "descansando");
        }

        public override void JogarVideoGame()
        {
            Console.WriteLine(this.GetType().Name + "Jogando Battlefield");
        }

        public override void levantar()
        {
            Console.WriteLine(this.GetType().Name + "levantando");
        }

        public override void LigarOsom()
        {
            Console.WriteLine(this.GetType().Name + "ligando o som");
        }

        public override void sentar()
        {
            Console.WriteLine(this.GetType().Name + "sentando");
        }
    }
}
