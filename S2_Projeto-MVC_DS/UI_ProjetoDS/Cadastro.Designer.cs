namespace UI_ProjetoDS
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblDadosLogin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lklReturn = new System.Windows.Forms.LinkLabel();
            this.lblPassConfirm = new System.Windows.Forms.Label();
            this.txbPassConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPessoais.Location = new System.Drawing.Point(12, 9);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(201, 36);
            this.lblDadosPessoais.TabIndex = 1;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblDadosLogin
            // 
            this.lblDadosLogin.AutoSize = true;
            this.lblDadosLogin.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosLogin.Location = new System.Drawing.Point(348, 9);
            this.lblDadosLogin.Name = "lblDadosLogin";
            this.lblDadosLogin.Size = new System.Drawing.Size(201, 36);
            this.lblDadosLogin.TabIndex = 2;
            this.lblDadosLogin.Text = "Dados de Login";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Digite seu nome";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(18, 94);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(279, 20);
            this.txbName.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(13, 126);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(133, 26);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "Digite seu CPF";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(18, 155);
            this.txbCPF.MaxLength = 11;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(279, 20);
            this.txbCPF.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(349, 65);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(284, 26);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Qual será seu nome de usuário?";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(354, 94);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(279, 20);
            this.txbUsername.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(349, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(151, 26);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Digite sua senha";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(354, 155);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(279, 20);
            this.txbPass.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatAppearance.BorderSize = 3;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(164, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 54);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "CADASTRAR";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(354, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 54);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "LIMPAR";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lklReturn
            // 
            this.lklReturn.AutoSize = true;
            this.lklReturn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklReturn.Location = new System.Drawing.Point(453, 327);
            this.lklReturn.Name = "lklReturn";
            this.lklReturn.Size = new System.Drawing.Size(34, 13);
            this.lklReturn.TabIndex = 15;
            this.lklReturn.TabStop = true;
            this.lklReturn.Text = "Voltar";
            this.lklReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklReturn_LinkClicked);
            // 
            // lblPassConfirm
            // 
            this.lblPassConfirm.AutoSize = true;
            this.lblPassConfirm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassConfirm.Location = new System.Drawing.Point(349, 188);
            this.lblPassConfirm.Name = "lblPassConfirm";
            this.lblPassConfirm.Size = new System.Drawing.Size(179, 26);
            this.lblPassConfirm.TabIndex = 11;
            this.lblPassConfirm.Text = "Confirme sua senha";
            // 
            // txbPassConfirm
            // 
            this.txbPassConfirm.Location = new System.Drawing.Point(354, 217);
            this.txbPassConfirm.Name = "txbPassConfirm";
            this.txbPassConfirm.PasswordChar = '*';
            this.txbPassConfirm.Size = new System.Drawing.Size(279, 20);
            this.txbPassConfirm.TabIndex = 12;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 354);
            this.Controls.Add(this.txbPassConfirm);
            this.Controls.Add(this.lblPassConfirm);
            this.Controls.Add(this.lklReturn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDadosLogin);
            this.Controls.Add(this.lblDadosPessoais);
            this.MaximumSize = new System.Drawing.Size(672, 393);
            this.MinimumSize = new System.Drawing.Size(672, 393);
            this.Name = "Cadastro";
            this.Text = "Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblDadosLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel lklReturn;
        private System.Windows.Forms.Label lblPassConfirm;
        private System.Windows.Forms.TextBox txbPassConfirm;
    }
}