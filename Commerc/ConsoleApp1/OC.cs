using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OC
    {
        public void NF()
        {

        }
        public void NF(cliente c, Iproducts p)
        {
            Console.WriteLine("Nome: " + c.nome + " , " + "Cpf: " + c.cpf + " , " + " Seu pedido foi" + "Produto: " + p.Nome + " , " + "Quantidade: " + p.Quantidade + " , " + "Preco: " + p.Preco + " sera enviado neste email: " + c.email + " Obrigado.");

        }

    }
}
