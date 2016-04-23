using Max_Sistemas.regras_de_negocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max_Sistemas.servicos.persistencia
{
    class ProfessorDAO
    {
        MySqlConnection conexaoMySQL = MysqlDAO.getInstancia().getConexao();

        public Professor selecionar()
        {
            Professor p = new Professor();
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = conexaoMySQL;
                query.CommandText = @"select * from professor";
                conexaoMySQL.Open();

                MySqlDataReader dtReader = query.ExecuteReader();
                
                while (dtReader.Read())
                {
                    p.Nome = dtReader["nome"].ToString();
                    p.Matricula = dtReader["matricula"].ToString();
                    p.IdProfessor = Convert.ToInt32(dtReader["idprofessor"]);
                    p.Sexo = Convert.ToChar(dtReader["sexo"]);
                    p.Telefone = dtReader["telefone"].ToString();
                    p.Identidade = dtReader["identidade"].ToString();
                    p.Email = dtReader["email"].ToString();
                    p.Cpf = dtReader["cpf"].ToString();
                    p.Celular = dtReader["celular"].ToString();
                    
                    
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conexaoMySQL.Close();

            }

            return p;
        }

        public List<Professor> selecionarTodos()
        {
            List<Professor> lista = new List<Professor>();
            Professor p;
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = conexaoMySQL;
                query.CommandText = @"select * from professor";
                conexaoMySQL.Open();

                MySqlDataReader dtReader = query.ExecuteReader();

                while (dtReader.Read())
                {
                    p = new Professor();
                    p.Nome = dtReader["nome"].ToString();
                    p.Matricula = dtReader["matricula"].ToString();
                    p.IdProfessor = Convert.ToInt32(dtReader["idprofessor"]);
                    p.Sexo = Convert.ToChar(dtReader["sexo"]);
                    p.Telefone = dtReader["telefone"].ToString();
                    p.Identidade = dtReader["identidade"].ToString();
                    p.Email = dtReader["email"].ToString();
                    p.Cpf = dtReader["cpf"].ToString();
                    p.Celular = dtReader["celular"].ToString();
                    EnderecoDAO end = new EnderecoDAO();
                    p.ENDERECO = end.selecionarPorId(Convert.ToInt32(dtReader["fk_id_endereco"]));

                    lista.Add(p);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conexaoMySQL.Close();

            }

            return lista;
        }

    }
}
