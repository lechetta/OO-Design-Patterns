using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    class ContaCliente
    {
        private string _titular;
        private double _saldo;

        public bool sacar(double valor)
        {
            return true;
        }
        public bool depositar(double depositar)
        {
            return true;
        }

        static ContaCliente _ContaCliente;
        private ContaCliente() { }
        public static ContaCliente CriarUsuario()
        {
            if (_ContaCliente == null)
            {
                _ContaCliente = new ContaCliente();


            }
            return _ContaCliente;
        }

        public string titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        public double saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }

        }
        public void getContaCliente(string titular)
        {
            if (titular == "Gustavo")
            {
                _titular = titular;
                _saldo = 500.00;

            }
        }
    }
}
