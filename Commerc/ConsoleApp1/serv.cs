﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class serv : ProductsAbs
    {
        public override string Nome { get; set; }
        public override double Preco { get; set; }
        public override string Fornecedor { get; set; }
        public override int Quantidade { get; set; }
        public int Tempo_Serv { get; set; }
        public override string Confirmar()
        {
            return base.Confirmar();
        }
    }
}
