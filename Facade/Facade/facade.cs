using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class facade
    {
        private academico acad = new academico();
        private financeiro fin = new financeiro();
        private biblioteca bi = new biblioteca();

        public bool rematricular(aluno alu)
        {
            if(acad.verificarReprovacao(alu) && !(fin.ConsultaDebito(alu.cpf)) && (bi.Emprestados(alu.matricula)==0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
