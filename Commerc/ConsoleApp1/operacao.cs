using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class operacao
    {

        public void enviar()
        {

        }
        public void enviar(cliente cli, endereco end)
        {
            Console.WriteLine(cli.nome + cli.cpf + end.cidade + end.bairro + end.cep);
        }
    }
}
