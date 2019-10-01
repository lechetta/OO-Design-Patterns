using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            facade fa = new facade();
            aluno alu = new aluno();

            alu.cpf = "8787";
            alu.nome = "Gustavo";
            alu.matricula = "5564";

            Console.WriteLine(fa.rematricular(alu) ? "Rematricula permitida" : "Rematricula nao permitida - ha pendencias");
            Console.ReadKey();
        }
    }
}
