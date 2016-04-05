using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Frequencia
    {
        private int idFrequencia;
        private int faltas;
        private Aluno aluno;
        private Materia materia;

        public int IdFrequencia
        {
            get { return idFrequencia; }
            set { idFrequencia = value; }
        }
        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }
        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }
    }
}
