namespace UI_ProjetoDS
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lklRecuperacao = new System.Windows.Forms.LinkLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lklCadastrar = new System.Windows.Forms.LinkLabel();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(407, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seja bem vindo ao Sistema ETEC";
            // 
            // btnLogar
            // 
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(173, 207);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(122, 54);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "ENVIAR";
            this.btnLogar.UseVisualStyleBackColor = true;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(12, 95);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(444, 20);
            this.txbUsuario.TabIndex = 2;
            // 
            // lklRecuperacao
            // 
            this.lklRecuperacao.AutoSize = true;
            this.lklRecuperacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRecuperacao.Location = new System.Drawing.Point(333, 185);
            this.lklRecuperacao.Name = "lklRecuperacao";
            this.lklRecuperacao.Size = new System.Drawing.Size(123, 15);
            this.lklRecuperacao.TabIndex = 7;
            this.lklRecuperacao.TabStop = true;
            this.lklRecuperacao.Text = "Esqueci minha senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(7, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(162, 26);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "E-mail ou Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(7, 133);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 26);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(12, 162);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(444, 20);
            this.txbSenha.TabIndex = 4;
            // 
            // lklCadastrar
            // 
            this.lklCadastrar.AutoSize = true;
            this.lklCadastrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCadastrar.Location = new System.Drawing.Point(9, 246);
            this.lklCadastrar.Name = "lklCadastrar";
            this.lklCadastrar.Size = new System.Drawing.Size(117, 15);
            this.lklCadastrar.TabIndex = 6;
            this.lklCadastrar.TabStop = true;
            this.lklCadastrar.Text = "Quero me cadastrar";
            // 
            // imgLogin
            // 
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogin.Image = global::UI_ProjetoDS.Properties.Resources.segurancaWeb50px;
            this.imgLogin.Location = new System.Drawing.Point(408, 133);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(50, 50);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogin.TabIndex = 8;
            this.imgLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(470, 275);
            this.Controls.Add(this.lklCadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lklRecuperacao);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgLogin);
            this.MaximumSize = new System.Drawing.Size(486, 314);
            this.MinimumSize = new System.Drawing.Size(486, 314);
            this.Name = "Login";
            this.Text = "Tela de Login Marota";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.LinkLabel lklRecuperacao;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.LinkLabel lklCadastrar;
        private System.Windows.Forms.PictureBox imgLogin;
    }
}

