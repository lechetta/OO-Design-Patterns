using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            digital d = new digital();
            serv s = new serv();
            fisico f = new fisico();
            pagamento P = new pagamento();
            operacao op = new operacao();



            endereco end = new endereco();
            end.cidade = "Curitiba";
            end.bairro = "Campo comprido";
            end.cep = 81280390;

            cliente cli = new cliente();
            cli.cpf = 47589622;
            cli.email = "g@teste.com";
            cli.nome = "Gustavo";

            OC ord = new OC();

            

            d.Nome = "Joao";
            d.Fornecedor = "Arau";
            d.Preco = 2500.00;


            


            ord.NF(cli, d);

            Console.ReadKey();
        }
    }
}
