using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjetoDS;
using DTOL_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class BLL_Login
    {
        // Métodos Personalizados
        public string ValidarLogin(DTO_Login obj_dtoLogin)
        {
            if (String.IsNullOrEmpty(obj_dtoLogin.Usuario) && String.IsNullOrEmpty(obj_dtoLogin.Password))
            {
                return ("Por favor digite seu (Nome de usuário) e (Senha).");
            } else if (String.IsNullOrEmpty(obj_dtoLogin.Usuario))
            {
                return ("Por favor digite o (Nome de usuário).");
            } else if (String.IsNullOrEmpty(obj_dtoLogin.Password))
            {
                return ("Por favor digite sua (Senha).");
            } else
            {
                //return ("Sucesso!\nSeja bem-vindo " + obj_dtoLogin.Usuario + ".");

                return DAL_Login.VerificarLogin(obj_dtoLogin);
                // ↑ Retornará a 'string' retornada pelo método 'VerificarLogin()' para ser exibida na VIEW 'UI_ProjetoDS'.
                //   Se 'DAL_Login' não for uma classe estática, teremos que instânciá-la aqui [?].
            }
            
        }

    }
}
