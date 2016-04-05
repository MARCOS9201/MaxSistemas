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
    class MateriaDAO
    {
        MySqlConnection conexaoMySQL = MysqlDAO.getInstancia().getConexao();

        public bool inserirMateria(Materia materia)
        {
            Boolean retorno = false;
            String sql = "insert into materia (nome,fk_id_professor, cargahoraria, data)"
                + "values (@nome, @fk_id_professor, @cargahoraria, @data)";
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoMySQL;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@nome", materia.Nome);
                command.Parameters.AddWithValue("@fk_id_professor", materia.Professor.IdProfessor);
                command.Parameters.AddWithValue("@cargahoraria", materia.CargaHoraria);
                command.Parameters.AddWithValue("@data", materia.DataCadastro);
                conexaoMySQL.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Materia salva");
                retorno = true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                
            }
            finally
            {
                conexaoMySQL.Close();
            }
            return retorno;
        }
       
    }
}
