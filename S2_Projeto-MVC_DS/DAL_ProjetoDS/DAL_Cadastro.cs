using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOL_ProjetoDS;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL_ProjetoDS
{
    public static class DAL_Cadastro
    {
        public static string EfetuarCadastro(DTO_Cadastro obj_dtoCadastro)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "INSERT INTO tbl_usuario (nome, email, userName, senha, tipo, cpf, rg) VALUES " +
                    "   (@nome, @email, @userName, @senha, @tipo, @cpf, @rg);";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.Conectar());

                cmd.Parameters.AddWithValue("@nome", obj_dtoCadastro.nomeCompleto);
                cmd.Parameters.AddWithValue("@email", obj_dtoCadastro.email);
                cmd.Parameters.AddWithValue("@userName", obj_dtoCadastro.userName);
                cmd.Parameters.AddWithValue("@senha", obj_dtoCadastro.userPass);
                cmd.Parameters.AddWithValue("@tipo", obj_dtoCadastro.tipoUsuario);
                cmd.Parameters.AddWithValue("@cpf", obj_dtoCadastro.cpf);
                cmd.Parameters.AddWithValue("@rg", obj_dtoCadastro.rg);
           
                MySqlDataReader dados = cmd.ExecuteReader();

                string script02 = "INSERT INTO tbl_endereco (cep, logradouro, numero, bairro, cidade, estado, idUsuario) VALUES " +
                    "(@cep, @logradouro, @numero, @bairro, @cidade, @estado, @idUsuario);";

                MySqlCommand cmd02 = new MySqlCommand(script02, myDBConnection.Conectar());

                cmd02.Parameters.AddWithValue("@cep", obj_dtoCadastro.cep);
                cmd02.Parameters.AddWithValue("@logradouro", obj_dtoCadastro.logradouro);
                cmd02.Parameters.AddWithValue("@numero", obj_dtoCadastro.numero);
                cmd02.Parameters.AddWithValue("@bairro", obj_dtoCadastro.bairro);
                cmd02.Parameters.AddWithValue("@cidade", obj_dtoCadastro.cidade);
                cmd02.Parameters.AddWithValue("@estado", obj_dtoCadastro.estado);
                cmd02.Parameters.AddWithValue("@idUsuario", cmd.LastInsertedId);

                MySqlDataReader dados02 = cmd02.ExecuteReader();

                return "Sucesso: Novo cliente cadastrado!";

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                if (myDBConnection.Conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.Conectar().Close();
                }
            }

        }

    }
}
