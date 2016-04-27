namespace BuscaTattoo.src.View
{
    partial class CadastrarCliente
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblDigiteonome = new System.Windows.Forms.Label();
            this.lblDigiteocpf = new System.Windows.Forms.Label();
            this.lblDigiteoendereco = new System.Windows.Forms.Label();
            this.lblDigiteoemail = new System.Windows.Forms.Label();
            this.lblDigiteodob = new System.Windows.Forms.Label();
            this.lblDigiteotelefone = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(12, 60);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(43, 20);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 112);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(86, 20);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(12, 218);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(172, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Data de Nascimento";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(16, 268);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(79, 20);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(104, 112);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(238, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(61, 62);
            this.txtCPF.Mask = "000-000-000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(84, 20);
            this.txtCPF.TabIndex = 13;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(190, 218);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(66, 20);
            this.txtDOB.TabIndex = 16;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(101, 268);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(83, 20);
            this.txtTelefone.TabIndex = 17;
            // 
            // lblDigiteonome
            // 
            this.lblDigiteonome.AutoSize = true;
            this.lblDigiteonome.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteonome.Location = new System.Drawing.Point(13, 35);
            this.lblDigiteonome.Name = "lblDigiteonome";
            this.lblDigiteonome.Size = new System.Drawing.Size(81, 13);
            this.lblDigiteonome.TabIndex = 6;
            this.lblDigiteonome.Text = "* Digite o Nome";
            // 
            // lblDigiteocpf
            // 
            this.lblDigiteocpf.AutoSize = true;
            this.lblDigiteocpf.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteocpf.Location = new System.Drawing.Point(12, 85);
            this.lblDigiteocpf.Name = "lblDigiteocpf";
            this.lblDigiteocpf.Size = new System.Drawing.Size(73, 13);
            this.lblDigiteocpf.TabIndex = 7;
            this.lblDigiteocpf.Text = "* Digite o CPF";
            // 
            // lblDigiteoendereco
            // 
            this.lblDigiteoendereco.AutoSize = true;
            this.lblDigiteoendereco.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteoendereco.Location = new System.Drawing.Point(13, 135);
            this.lblDigiteoendereco.Name = "lblDigiteoendereco";
            this.lblDigiteoendereco.Size = new System.Drawing.Size(99, 13);
            this.lblDigiteoendereco.TabIndex = 8;
            this.lblDigiteoendereco.Text = "* Digite o Endereço";
            // 
            // lblDigiteoemail
            // 
            this.lblDigiteoemail.AutoSize = true;
            this.lblDigiteoemail.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteoemail.Location = new System.Drawing.Point(12, 189);
            this.lblDigiteoemail.Name = "lblDigiteoemail";
            this.lblDigiteoemail.Size = new System.Drawing.Size(82, 13);
            this.lblDigiteoemail.TabIndex = 9;
            this.lblDigiteoemail.Text = "* Digite o E-Mail";
            // 
            // lblDigiteodob
            // 
            this.lblDigiteodob.AutoSize = true;
            this.lblDigiteodob.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteodob.Location = new System.Drawing.Point(12, 238);
            this.lblDigiteodob.Name = "lblDigiteodob";
            this.lblDigiteodob.Size = new System.Drawing.Size(146, 13);
            this.lblDigiteodob.TabIndex = 10;
            this.lblDigiteodob.Text = "* Digite a data de nascimento";
            // 
            // lblDigiteotelefone
            // 
            this.lblDigiteotelefone.AutoSize = true;
            this.lblDigiteotelefone.ForeColor = System.Drawing.Color.Red;
            this.lblDigiteotelefone.Location = new System.Drawing.Point(17, 291);
            this.lblDigiteotelefone.Name = "lblDigiteotelefone";
            this.lblDigiteotelefone.Size = new System.Drawing.Size(91, 13);
            this.lblDigiteotelefone.TabIndex = 11;
            this.lblDigiteotelefone.Text = "* Digite o telefone";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(20, 316);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(322, 73);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 401);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblDigiteotelefone);
            this.Controls.Add(this.lblDigiteodob);
            this.Controls.Add(this.lblDigiteoemail);
            this.Controls.Add(this.lblDigiteoendereco);
            this.Controls.Add(this.lblDigiteocpf);
            this.Controls.Add(this.lblDigiteonome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastrarCliente";
            this.Text = "Busca Tattoo - Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblDigiteonome;
        private System.Windows.Forms.Label lblDigiteocpf;
        private System.Windows.Forms.Label lblDigiteoendereco;
        private System.Windows.Forms.Label lblDigiteoemail;
        private System.Windows.Forms.Label lblDigiteodob;
        private System.Windows.Forms.Label lblDigiteotelefone;
        private System.Windows.Forms.Button btnEnviar;
    }
}