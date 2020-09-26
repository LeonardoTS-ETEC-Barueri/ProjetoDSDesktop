using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ProjetoDS;
using DTOL_ProjetoDS;

namespace UI_ProjetoDS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();    // Oculta o form atual (Login.cs)
            Cadastro telaCadastro = new Cadastro(); // Instanciamento da tela (Cadastro.cs)
            telaCadastro.ShowDialog();  // Exibe a tela (Cadastro.cs) e até que ela seja fechada, bloqueia manipulação na tela (Login.cs)
            this.Show();    // Volta a exibição do form atual.
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {


            try
            {
                DTO_Login obj_dtoLogin = new DTO_Login();
                BLL_Login obj_bllLogin = new BLL_Login();
                obj_dtoLogin.Usuario = this.txbUsername.Text;
                obj_dtoLogin.Password = this.txbPass.Text;

                string retornoBLL = obj_bllLogin.ValidarLogin(obj_dtoLogin);
                MessageBox.Show(retornoBLL);

            } catch (Exception ex)
            {
                MessageBox.Show("Ops... Algo deu errado, contacte o administrador do sistema.\nErro: " + ex);
            }




        }
    }
}
