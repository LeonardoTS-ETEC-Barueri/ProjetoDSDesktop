using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjetoDS;
using DTOL_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class BLL_Cadastro
    {
        public string ValidarCadastro(DTO_Cadastro obj_dtoCadastro)
        {
            obj_dtoCadastro.tipoUsuario = "Cliente";

            if (String.IsNullOrEmpty(obj_dtoCadastro.nomeCompleto)) {
                return "Por favor digite o seu Nome.";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.rg))
            {
                return "Por favor digite o seu RG.";
            }
            else if (obj_dtoCadastro.rg.Replace(" ", "").Length != 9)
            {
                return "RG Inválido, verifique o RG digitado";

            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.cpf))
            {
                return "Por favor digite o seu CPF.";
            }
            else if (obj_dtoCadastro.cpf.Replace(" ", "").Length != 11)
            {
                return "CPF Inválido, verifique o CPF digitado";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.userName))
            {
                return "Por favor digite o seu Nome de Usuário.";
            }
            else if (obj_dtoCadastro.userName.Contains(" "))
            {
                return "O nome de usuário não pode conter espaços em branco";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.email))
            {
                return "Por favor, digite o seu e-mail.";
            }
            else if (!obj_dtoCadastro.email.Contains("@") || !obj_dtoCadastro.email.Contains(".") || obj_dtoCadastro.email.Contains(" "))
            {
                return "E-mail inválido, por favor verifique seu endereço de e-mail.";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.userPass))
            {
                return "Por favor digite sua senha.";
            }
            else if (obj_dtoCadastro.userPass.Length > 50)
            {
                return "ERRO: A senha só pode conter 50 caracteres.";
            }
            else if (obj_dtoCadastro.userPass != obj_dtoCadastro.userPassConfirm)
            {
                return "Sua confirmação de senha não está identica, tente novamente.";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.userPassConfirm))
            {
                return "Por favor, confirme sua senha.";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.cep))
            {
                return "Por favor, digite o seu CEP.";
            }
            else if (obj_dtoCadastro.cep.Replace(" ", "").Length != 8)
            {
                return "CEP Inválido, verifique o CEP digitado";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.logradouro))
            {
                return "Por favor, digite o seu Logradouro (Rua, Avenida, ou outro...)";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.numero))
            {
                return "Por favor, digite o número de sua residência";
            }
            else if ( !obj_dtoCadastro.numero.Any(Char.IsDigit) || obj_dtoCadastro.numero.Any(Char.IsPunctuation) ){
                return "Por favor, digite apenas o número";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.bairro))
            {
                return "Por favor, digite o nome do bairro onde você mora";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.cidade))
            {
                return "Por favor, digite a cidade onde você mora";
            }
            else if (String.IsNullOrEmpty(obj_dtoCadastro.estado))
            {
                return "Por favor, digite o estado onde você mora";
            }

            obj_dtoCadastro.nomeCompleto.Trim();
            obj_dtoCadastro.rg.Replace(" ", "");
            obj_dtoCadastro.cpf.Replace(" ", "");
            obj_dtoCadastro.nomeCompleto.Trim();
            obj_dtoCadastro.cep.Replace(" ", "");
            obj_dtoCadastro.logradouro.Trim();
            obj_dtoCadastro.bairro.Trim();
            obj_dtoCadastro.cidade.Trim();
            obj_dtoCadastro.estado.Trim();

            
            return DAL_Cadastro.EfetuarCadastro(obj_dtoCadastro);

        }

    }
}
