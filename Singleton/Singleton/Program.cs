using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste t = new teste();
            //Console.WriteLine(t.expor());
            //t.alterar();
            //Console.WriteLine("segundo t" + t.expor());
            //teste y = new teste();
            //Console.WriteLine("terceiro x" + t.expor());
            //y.alterar();
            //Console.WriteLine("quarto" + t.expor());
            //Console.ReadKey();
            ///  singleton user1 = singleton.CriarSingleton();
            // singleton user2 = singleton.CriarSingleton();
            //Console.WriteLine(user1 == user2);
            usuario user = usuario.CriarUsuario();
            user.getUsuario("888");
            Console.WriteLine(user.nome);
            Console.ReadKey();

        }
    }
}
