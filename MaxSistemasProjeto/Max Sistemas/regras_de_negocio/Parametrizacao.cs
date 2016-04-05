using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Parametrizacao
    {
        private int cadastrarAluno;
        private int cadastrarPerfil;
        private int cadastrarProfessor;
        private int cadastrarFrequencia;
        private int cadastrarMateria;

        public int CadastrarFrequencia
        {
            get { return cadastrarFrequencia; }
            set { cadastrarFrequencia = value; }
        }
        public int CadastrarMateria
        {
            get { return cadastrarMateria; }
            set { cadastrarMateria = value; }
        }
        public int CadastrarPerfil
        {
            get { return cadastrarPerfil; }
            set { cadastrarPerfil = value; }
        }
        public int CadastrarAluno
        {
            get { return cadastrarAluno; }
            set { cadastrarAluno = value; }
        }
        public int CadastrarProfessor
        {
            get { return cadastrarProfessor; }
            set { cadastrarProfessor = value; }
        }
    }
}
