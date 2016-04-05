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
    class testeDAO{
    MySqlConnection conexaoMySQL = MysqlDAO.getInstancia().getConexao();
    public void teste(){
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
        MessageBox.Show(e.Message);
		
	}
        finally{
            conexaoMySQL.Close();
            
        }
        

    }
    }
}
