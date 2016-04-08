namespace BuscaTattoo.src.View
{
    partial class CadastrarLogin
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblDigiteseunome = new System.Windows.Forms.Label();
            this.lblDigiteologin = new System.Windows.Forms.Label();
            this.lblDigiteasenha = new System.Windows.Forms.Label();
            this.lblDigiteseucpf = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(14, 110);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 20);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(6, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(73, 110);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(252, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(73, 160);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(252, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblDigiteseunome
            // 
            this.lblDigiteseunome.AutoSize = true;
            this.lblDigiteseunome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteseunome.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteseunome.Location = new System.Drawing.Point(70, 35);
            this.lblDigiteseunome.Name = "lblDigiteseunome";
            this.lblDigiteseunome.Size = new System.Drawing.Size(90, 13);
            this.lblDigiteseunome.TabIndex = 6;
            this.lblDigiteseunome.Text = "* Digite seu nome";
            // 
            // lblDigiteologin
            // 
            this.lblDigiteologin.AutoSize = true;
            this.lblDigiteologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteologin.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteologin.Location = new System.Drawing.Point(70, 133);
            this.lblDigiteologin.Name = "lblDigiteologin";
            this.lblDigiteologin.Size = new System.Drawing.Size(148, 13);
            this.lblDigiteologin.TabIndex = 7;
            this.lblDigiteologin.Text = "* Digite um login e memorize-o";
            // 
            // lblDigiteasenha
            // 
            this.lblDigiteasenha.AutoSize = true;
            this.lblDigiteasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteasenha.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteasenha.Location = new System.Drawing.Point(70, 185);
            this.lblDigiteasenha.Name = "lblDigiteasenha";
            this.lblDigiteasenha.Size = new System.Drawing.Size(161, 13);
            this.lblDigiteasenha.TabIndex = 8;
            this.lblDigiteasenha.Text = "* Digite uma senha e memorize-a";
            // 
            // lblDigiteseucpf
            // 
            this.lblDigiteseucpf.AutoSize = true;
            this.lblDigiteseucpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteseucpf.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteseucpf.Location = new System.Drawing.Point(70, 84);
            this.lblDigiteseucpf.Name = "lblDigiteseucpf";
            this.lblDigiteseucpf.Size = new System.Drawing.Size(79, 13);
            this.lblDigiteseucpf.TabIndex = 11;
            this.lblDigiteseucpf.Text = "* Digite seu cpf";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(14, 61);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(53, 20);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "C P F";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(10, 213);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(315, 63);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(73, 61);
            this.txtCPF.Mask = "000-000-000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(252, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // CadastrarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 288);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblDigiteseucpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDigiteasenha);
            this.Controls.Add(this.lblDigiteologin);
            this.Controls.Add(this.lblDigiteseunome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastrarLogin";
            this.Text = "Busca Tattoo - Cadastrar Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblDigiteseunome;
        private System.Windows.Forms.Label lblDigiteologin;
        private System.Windows.Forms.Label lblDigiteasenha;
        private System.Windows.Forms.Label lblDigiteseucpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}