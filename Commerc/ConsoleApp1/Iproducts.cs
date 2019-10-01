
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Iproducts
    {
        string Nome { get; set; }
        string Fornecedor { get; set; }
        double Preco { get; set; }
        int Quantidade { get; set; }




        string Confirmar();
        string Send();
        string Download();
    }
}
