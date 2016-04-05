using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Professor
    {
        private int idProfessor;
        private string nome;
        private string cpf;
        private string matricula;
        private string identidade;
        private string email;
        private string telefone;
        private string celular;
        private Endereco FK_ID_ENDERECO;
        private int numero;
        private char sexo;

        public int IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        public Endereco ENDERECO
        {
            get { return FK_ID_ENDERECO; }
            set { FK_ID_ENDERECO = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
