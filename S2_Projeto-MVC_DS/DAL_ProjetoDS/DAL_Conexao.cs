using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DAL_ProjetoDS
{
    public class DAL_Conexao
    {
        public string myConnection = "server = localhost; user id = root; database=ds_db_projeto_mvc";

        public MySqlConnection Conectar()
        {
            try { 
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Open();

                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar. Tente novamente. \n Erro: " + ex.Message);
            }

        }

    }
}
