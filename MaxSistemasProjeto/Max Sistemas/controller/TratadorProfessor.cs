using Max_Sistemas.regras_de_negocio;
using Max_Sistemas.servicos.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.controller
{
    class TratadorProfessor
    {
        public List<Professor> buscaProfessor()
        {
            ProfessorDAO professorDAO=new ProfessorDAO();
            return professorDAO.selecionarTodos();
        }
    }
}
