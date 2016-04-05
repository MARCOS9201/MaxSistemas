using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Usuario
    {
        private int idUsuario;
        private int tipoPerfil;
        private string nome;
        private string nomeUsuario;
        private string senha;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        

        public int TipoPerfil
        {
            get { return tipoPerfil; }
            set { tipoPerfil = value; }
        }
    }
}
