﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class digital : ProductsAbs
    {
        public override string Nome { get; set; }
        public override double Preco { get; set; }
        public override string Fornecedor { get; set; }
        public override int Quantidade { get => 1; }

        public override string Download()
        {
            return base.Download();
        }
    }
}
