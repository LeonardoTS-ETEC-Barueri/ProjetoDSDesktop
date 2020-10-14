using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTOL_ProjetoDS;

namespace DAL_ProjetoDS
{
    public static class DAL_Login
    {

        public static string EfetuarLogin(DTO_Login obj_dtoLogin)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();
            // ↑ Cria uma instância da conexão com a DB.

            try
            {
                

                string script = "SELECT * FROM tbl_usuario WHERE (userName = @login OR email = @login) " +
                    "AND senha = @password; ";
                // ↑ Cria a string com a consulta SQL note o fechamento da consulta com ; e o fechamento da string com ;

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.Conectar());
                // ↑ Cria o comando para executar a instrução, passando a consulta de 'script' e a database declarada na classe 'DAL_Conexao' onde essa consulta será executada.

                cmd.Parameters.AddWithValue("@login", obj_dtoLogin.Usuario);
                cmd.Parameters.AddWithValue("@password", obj_dtoLogin.Password);
                // ↑ Substitui " @login " de 'script' pelos valores contidos em obj_dtoLogin.Usuario.

                MySqlDataReader dadosRetornados = cmd.ExecuteReader();
                // ↑ Roda a instrução SQL e atribui o resultado na variável dadosRetornados (Nesse caso é o retorno do SELECT).
                //   Esse retorno será uma matriz bidimensional contendo os dados de cada campo da linha para cada linha.

                while (dadosRetornados.Read()) // Lê a próxima linha do resultado
                {
                    if (dadosRetornados.HasRows)
                    {
                        /*
                         DTO_Usuario user = new DTO_Usuario();
                         user.IdLogin = dados["idLogin"].ToString();
                         user.Email = dados["email"].ToString();
                         user.NickName = dados["userName"].ToString();
                         user.Senha = dados["senha"].ToString();
                         user.Ativo = dados["ativo"].ToString();
                         return user;
                         */

                        return "Sucesso, usuário encontrado!";
                    }
                }

                return "Credenciais Inválidas, usuário não encontrado.";

               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally // Roda de qualquer forma, independentemente da execução do bloco Try ou Catch.
            {
                if (myDBConnection.Conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.Conectar().Close();
                }
            }


        }





    }
}
