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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void lklReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try { 
                DTO_Cadastro obj_dtoCadastro = new DTO_Cadastro();
                BLL_Cadastro obj_bllCadastro = new BLL_Cadastro();
                obj_dtoCadastro.nomeCompleto = this.txbFullName.Text;
                obj_dtoCadastro.rg = this.mtxbRG.Text;
                obj_dtoCadastro.cpf = this.mtxbCPF.Text;
                obj_dtoCadastro.userName = this.txbUsername.Text;
                obj_dtoCadastro.email = this.txbEmail.Text;
                obj_dtoCadastro.userPass = this.txbPass.Text;
                obj_dtoCadastro.userPassConfirm = this.txbPassConfirm.Text;
                obj_dtoCadastro.cep = this.mtxbCEP.Text;
                obj_dtoCadastro.logradouro = this.txbLogradouro.Text;
                obj_dtoCadastro.numero = this.txbNumEnd.Text;
                obj_dtoCadastro.bairro = this.txbBairro.Text;
                obj_dtoCadastro.cidade = this.txbCidade.Text;
                obj_dtoCadastro.estado = this.txbEstado.Text;

                //Console.WriteLine("RG: {0}\nCPF: {1}\nCEP: {2}", obj_dtoCadastro.rg.Trim(), obj_dtoCadastro.cpf, obj_dtoCadastro.cep);
                string retornoBLL = obj_bllCadastro.ValidarCadastro(obj_dtoCadastro);
                if (retornoBLL.Contains("Sucesso: Novo cliente cadastrado!")) { 
                    Controls.Clear();
                    InitializeComponent();
                }
                MessageBox.Show(retornoBLL);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops... Algo deu errado, contacte o administrador do sistema.\nErro: " + ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}
