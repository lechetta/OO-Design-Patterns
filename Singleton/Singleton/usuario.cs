using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class usuario
    {
        private string _cpf;
        private string _nome;

        static usuario _usuario;
        private usuario() { }
        public static usuario CriarUsuario ()
        {
            if(_usuario == null)
            {
                _usuario = new usuario();

                
            }
            return _usuario;
        }

        public string cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        //DAO
        public void getUsuario(string cpf)
        {
            if (cpf == "888")
            {
                _cpf = cpf;
                _nome = "Escobar";

            }
        }
        

    }
}
