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
    class EnderecoDAO
    {
        MySqlConnection conexaoMySQL = MysqlDAO.getInstancia().getConexao();

        public Endereco selecionarPorCep(string cep)
        {
            Endereco end = new Endereco();
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = conexaoMySQL;
                query.CommandText = @"select * from endereco where cep=?cep";
                query.Parameters.AddWithValue("?cep", cep);
                conexaoMySQL.Open();

                MySqlDataReader dtReader = query.ExecuteReader();
                
                while (dtReader.Read())
                {
                    end.Cep = cep;
                    end.Logradouro = dtReader["logradouro"].ToString();
                    end.IdCep = Convert.ToInt32(dtReader["idcep"]);
                    end.Municipio = dtReader["municipio"].ToString();
                    end.Uf = dtReader["uf"].ToString();
                    end.Bairro = dtReader["bairro"].ToString();
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
            return end;
        }

        public Endereco selecionarPorId(int id)
        {
            Endereco end = new Endereco();
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = conexaoMySQL;
                query.CommandText = "select * from endereco where idCEP=?idcep";
                query.Parameters.AddWithValue("?idcep", 47);
                
                conexaoMySQL.Open();
                
                MySqlDataReader dtReader = query.ExecuteReader();
                end.IdCep = id;
                while (dtReader.Read())
                {
                    end.Cep = dtReader["cep"].ToString();
                    end.Logradouro = dtReader["logradouro"].ToString();
                    
                    end.Municipio = dtReader["municipio"].ToString();
                    end.Uf = dtReader["uf"].ToString();
                    end.Bairro = dtReader["bairro"].ToString();
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
            return end;
        }

    }
}
