using Max_Sistemas.regras_de_negocio;
using Max_Sistemas.servicos.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max_Sistemas.controller
{
    class TratadorMateria
    {
        public bool salvarMateria(Materia materia)
        {
            bool retorno = false;
            if (materia.Nome!=null && !materia.Nome.Equals("") && !materia.CargaHoraria.Equals(""))
            {
                
                MateriaDAO materiaDAO = new MateriaDAO();
                retorno=materiaDAO.inserirMateria(materia);
            }
            else
            {
                MessageBox.Show("Complete o cadastro, existem campos em branco!");
            }
            return retorno;
        }
    }
}
