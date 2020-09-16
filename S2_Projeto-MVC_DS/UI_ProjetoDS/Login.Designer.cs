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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lklRecovery = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lklRegister = new System.Windows.Forms.LinkLabel();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Seja bem vindo ao Sistema ETEC";
            // 
            // btnLogar
            // 
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnLogar.FlatAppearance.BorderSize = 3;
            this.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
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
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(12, 95);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(444, 20);
            this.txbUsername.TabIndex = 2;
            // 
            // lklRecovery
            // 
            this.lklRecovery.AutoSize = true;
            this.lklRecovery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRecovery.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklRecovery.Location = new System.Drawing.Point(333, 185);
            this.lklRecovery.Name = "lklRecovery";
            this.lklRecovery.Size = new System.Drawing.Size(123, 15);
            this.lklRecovery.TabIndex = 7;
            this.lklRecovery.TabStop = true;
            this.lklRecovery.Text = "Esqueci minha senha";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 66);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(162, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "E-mail ou Usuário";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(7, 133);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 26);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Senha";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(12, 162);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(444, 20);
            this.txbPass.TabIndex = 4;
            // 
            // lklRegister
            // 
            this.lklRegister.AutoSize = true;
            this.lklRegister.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklRegister.Location = new System.Drawing.Point(9, 246);
            this.lklRegister.Name = "lklRegister";
            this.lklRegister.Size = new System.Drawing.Size(117, 15);
            this.lklRegister.TabIndex = 6;
            this.lklRegister.TabStop = true;
            this.lklRegister.Text = "Quero me cadastrar";
            this.lklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegister_LinkClicked);
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
            this.Controls.Add(this.lklRegister);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lklRecovery);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgLogin);
            this.MaximumSize = new System.Drawing.Size(486, 314);
            this.MinimumSize = new System.Drawing.Size(486, 314);
            this.Name = "Login";
            this.Text = "Login - Sistema ETEC";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.LinkLabel lklRecovery;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.LinkLabel lklRegister;
        private System.Windows.Forms.PictureBox imgLogin;
    }
}

