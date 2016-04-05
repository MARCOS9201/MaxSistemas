using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Aluno
    {
        private int idAluno;
        private string nome;
        private string matricula;
        private string cpf;
        private string identidade;
        private char sexo;
        private string telefone;
        private string celular;
        private string email;
        private DateTime dataInclusao;
        private string nivelEscolar;
        private string anoLetivo;
        private int numeroEndereco;


        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DataInclusao
        {
            get { return dataInclusao; }
            set { dataInclusao = value; }
        }

        public string NivelEscolar
        {
            get { return nivelEscolar; }
            set { nivelEscolar = value; }
        }

        public string AnoLetivo
        {
            get { return anoLetivo; }
            set { anoLetivo = value; }
        }

        public int NumeroEndereco
        {
            get { return numeroEndereco; }
            set { numeroEndereco = value; }
        }
    }
}
