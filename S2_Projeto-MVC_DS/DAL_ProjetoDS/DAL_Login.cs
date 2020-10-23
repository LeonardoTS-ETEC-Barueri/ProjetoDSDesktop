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


                string script = "SELECT tu.*, te.* " +
                    "FROM tbl_endereco te " +
                    "INNER JOIN tbl_usuario tu " +
                    "   ON te.idUsuario = tu.idUsuario " +
                    "WHERE (tu.userName = @login OR tu.email = @login) AND tu.senha = @password;";
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
                        
                        DTO_Usuario obj_dtoUsuario = new DTO_Usuario();
                        obj_dtoUsuario.idUsuario = int.Parse(dadosRetornados["idUsuario"].ToString());
                        obj_dtoUsuario.nomeCompleto = dadosRetornados["nome"].ToString();
                        obj_dtoUsuario.userName = dadosRetornados["userName"].ToString();
                        obj_dtoUsuario.userPass = dadosRetornados["senha"].ToString();
                        obj_dtoUsuario.tipoUsuario = dadosRetornados["tipo"].ToString();
                        obj_dtoUsuario.ativo = dadosRetornados["ativo"].ToString();
                        obj_dtoUsuario.cpf = dadosRetornados["cpf"].ToString();
                        obj_dtoUsuario.rg = dadosRetornados["rg"].ToString();
                        obj_dtoUsuario.cep = dadosRetornados["cep"].ToString();
                        obj_dtoUsuario.logradouro = dadosRetornados["logradouro"].ToString();
                        obj_dtoUsuario.numero = dadosRetornados["numero"].ToString();
                        obj_dtoUsuario.bairro = dadosRetornados["bairro"].ToString();
                        obj_dtoUsuario.cidade = dadosRetornados["cidade"].ToString();
                        obj_dtoUsuario.estado = dadosRetornados["estado"].ToString();
                        //return obj_dtoUsuario.ToString();


                        return "Usuário [" + obj_dtoUsuario.userName +"] encontrado!\n[" + obj_dtoUsuario.tipoUsuario + "] logado com sucesso!";
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
