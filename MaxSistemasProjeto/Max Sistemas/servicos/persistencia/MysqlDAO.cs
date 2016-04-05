using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Max_Sistemas.servicos.persistencia
{
    class MysqlDAO
    {
        private static readonly MysqlDAO instanciaMySql = new MysqlDAO();

        private MysqlDAO() { }
        public static MysqlDAO getInstancia()
        {
            return instanciaMySql;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
