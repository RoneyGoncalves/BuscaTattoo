using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BuscaTattoo.src.Controller;

namespace BuscaTattoo
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Armazena o login e senha digitados pelo usuário
            String login = txtLogin.Text;
            String senha = txtSenha.Text;

            //Instancializa a classe ControlLogin
            ControlLogin controllogin = new ControlLogin();

            //Verifica se o login e redireciona para a tela principal
            //Caso contrario apresenta "login inválido"
            if (controllogin.Verificalogin(login, senha))
            {
                HomePage homepage = new HomePage();
                homepage.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Login e/ou Senha inválidos!");
            }

        }

        private void linkLblEsqueceuasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contate o Administrador do sistema!");
        }
    }
}
