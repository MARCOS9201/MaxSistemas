using Max_Sistemas.regras_de_negocio;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Max_Sistemas.servicos.persistencia
{
    class usuarioDAO{
    MySqlConnection conexaoMySQL = MysqlDAO.getInstancia().getConexao();
    public void usuario(){
        try 
	{	    
            MySqlCommand query= new MySqlCommand();
            query.Connection=conexaoMySQL;
            query.CommandText=@"select * from usuario";
            conexaoMySQL.Open();

            MySqlDataReader dtReader = query.ExecuteReader();
            Usuario u=new Usuario();
            while (dtReader.Read())
	{
	         u.Nome=dtReader["nome"].ToString();
             MessageBox.Show(u.Nome);
	}

	}
	catch (Exception e)
	{
        MessageBox.Show("Usuário ou senha incorretos");
		
	}
        finally{
            conexaoMySQL.Close();
            
        }
      
    }
    }
}
