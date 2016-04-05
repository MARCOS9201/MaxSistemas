using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sistemas.regras_de_negocio
{
    class Endereco
    {
        private int idCep;
        private string uf;
        private string cep;
        private string logradouro;
        private string municipio;
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int IdCep
        {
            get { return idCep; }
            set { idCep = value; }
        }
        

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }
        

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


    }
}
