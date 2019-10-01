using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductsAbs : Iproducts

    {
        public virtual string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string Fornecedor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual double Preco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual int Quantidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual string Confirmar()
        {
            throw new NotImplementedException();
        }

        public virtual string Download()
        {
            throw new NotImplementedException();
        }

        public virtual string Send()
        {
            throw new NotImplementedException();
        }
    }
}
