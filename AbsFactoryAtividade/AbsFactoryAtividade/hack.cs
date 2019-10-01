using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFactoryAtividade
{
    class hack : AbsSalaJantar
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
            Console.WriteLine(this.GetType().Name + "jogando ps4");
        }

        public override void levantar()
        {
            throw new NotImplementedException();
        }

        public override void LigarOsom()
        {
            Console.WriteLine(this.GetType().Name + "ligando o som");
        }

        public override void sentar()
        {
            throw new NotImplementedException();
        }
    }
}
