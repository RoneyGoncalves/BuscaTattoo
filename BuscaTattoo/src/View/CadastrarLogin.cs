using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuscaTattoo.src.Controller;

namespace BuscaTattoo.src.View
{
    public partial class CadastrarLogin : Form
    {
        public CadastrarLogin()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Instancializa a classe ControlLogin
            ControlLogin controllogin = new ControlLogin();

            String nome = txtNome.Text;
            String cpf = txtCPF.Text;
            String login = txtLogin.Text;
            String senha = txtSenha.Text;
            String endereco = null;
            String email = null;
            String dob = null;
            String telefone = null;
            String dta_cadastro = DateTime.Now.ToShortDateString();

            if (controllogin.Verificasejatemcadastro(cpf))
            {
                controllogin.Atualizacadastrologin(nome, cpf, login, senha);
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            else
            {
                controllogin.Inserenovologin(nome, cpf, login, senha, endereco, email, dob, telefone, dta_cadastro);
                MessageBox.Show("Novo login cadastrado com sucesso!");
            }//End of If else

        }//End of btnEnviar_Click
    }
}
