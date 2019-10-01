using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCliente conta = ContaCliente.CriarUsuario();
            conta.getContaCliente("Gustavo");
            Console.WriteLine(conta.saldo);
            Console.ReadKey();

            ContaCliente c = ContaCliente.CriarUsuario();
            Console.WriteLine(c.saldo);
            Console.ReadKey();
        }
    }
}
