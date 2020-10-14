using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOL_ProjetoDS
{

    public class DTO_Cadastro
    {
        
        public int idUsuario { get; set; }

        // Dados Sociais
        
        public string nomeCompleto { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        // Dados de Acesso

        public string tipoUsuario { get; set; }
        public string ativo { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string userPass { get; set; }
        public string userPassConfirm { get; set; }


        // Dados do Endereço
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }

}
