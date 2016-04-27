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
            String endereco = txtEndereco.Text;
            String email = txtEmail.Text;
            String dob = txtDOB.Text;
            String telefone = txtTelefone.Text;
            String dta_cadastro = DateTime.Now.ToShortDateString();

            try 
            {
                if (txtNome.TextLength <= 0)
                {
                    MessageBox.Show("Nome Inválido!\nDigite seu nome\n Exemplo: Eduardo da Silva Matias");
                    return;
                }//Fim do if nome
                
                //Verificar cpf. Pegar o algoritmo que verifica cpf<---------
                //if (){}

                if (txtLogin.TextLength <= 0 || txtLogin.TextLength > 10)
                {
                    MessageBox.Show("Login Inválido!\nDigite um login com no máximo 10 Dígitos!\nExemplo: Eduardo");
                    return;
                }//Fim do if login

                if (txtSenha.TextLength <= 0 || txtSenha.TextLength > 10)
                {
                    MessageBox.Show("Senha Inválida\nDigita um senha com no máximo 10 dígitos!");
                    return;
                }//Fim do if senha

                if (txtEndereco.TextLength <= 0)
                {
                    MessageBox.Show("Endereço inválido!\nDigite seu endereço!\nExemplo: Rua Astorga, 12, Centro, Curitiba-PR");
                    return;
                }//Fim do if endereco

                //Validar email. Pegar um algoritmo que valide email
                //if(){}

                if(txtDOB.TextLength <= 0)
                {
                    MessageBox.Show("Data de nascimento inválida!\nDigite o dia, mês e ano do seu nascimento!\nExemplo: 15/08/1994");
                    return;
                }//Fim do if dob

                if(txtTelefone.TextLength <= 0)
                {
                    MessageBox.Show("Telefone inválido!\nDigite o ddd e o número de seu telefone!\nExemplo: (41)9999-9999");
                    return;
                }//Fim do if telefone

            }//Fim do try
            catch { }//Fim do Catch

            if (controllogin.Verificasejatemcadastro(cpf))
            {
                controllogin.Atualizacadastrologin(nome, cpf, login, senha, endereco, email, dob, telefone, dta_cadastro);
                MessageBox.Show("CPF já existe no sistema!\nO cadastro foi atualizado com sucesso!");
            }
            else
            {
                controllogin.Inserenovologin(nome, cpf, login, senha, endereco, email, dob, telefone, dta_cadastro);
                MessageBox.Show("Novo login cadastrado com sucesso!");
            }//End of If else

        }//End of btnEnviar_Click
    }
}
