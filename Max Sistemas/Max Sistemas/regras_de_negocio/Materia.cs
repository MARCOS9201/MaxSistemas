using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Materia
    {
        private int idMateria;
        private string nome;
        private Professor professor;
        private double cargaHoraria;
        private DateTime dataCadastro;
        public Materia()
        {
            professor = new Professor();
            professor.IdProfessor = 1;
        }
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }
        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        internal Professor Professor
        {
            get { return professor; }
            set { professor = value; }
        }
        

        public double CargaHoraria
        {
            get { return cargaHoraria; }
            set { cargaHoraria = value; }
        }
    }
}
