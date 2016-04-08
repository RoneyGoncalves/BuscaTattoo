using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaTattoo.View
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String login = txtLogin.Text;
            String senha = txtSenha.Text;
            String endereco = txtEndereco.Text;
            String email = txtEmail.Text;
            String dob = txtDOB.Text;
            String ddd = txtDDD.Text;
            String telefone = txtTelefone.Text;
            //Criar uma variavel inicializada com a data do sistema String dta_cadastro = ;

            try
            {
                //Verifica Nome
                if (nome.Length == 0)
                {
                    MessageBox.Show("Digite Seu Nome");
                }
                
                //Verifica login
                if (login.Length > 10) 
                {
                    MessageBox.Show("Login Muito Longo!\nDigite um login com no máximo 10 characteres!");
                    return;
                }else if (login.Length == 0)
                {
                    MessageBox.Show("Digite um Login!");
                    return;
                }

                //Verifica senha
                if(senha.Length > 10)
                {
                    MessageBox.Show("Senha muito Longa!\nDigite uma senha de até 10 dígitos!");
                    return;
                }else if(senha.Length == 0)
                {
                    MessageBox.Show("Digite uma senha");
                    return;
                }

                //Verifica email
                if(email.Length > 50)
                {
                    MessageBox.Show("E-mail muito longo!\nDigite um e-mail com até 50 characteres");
                    return;
                }

            }
            catch { }

            //Cria um objeto para se conectar ao banco
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Roninho\documents\visual studio 2012\Projects\BuscaTattoo\BuscaTattoo\DatabaseBuscaTattoo.mdf;Integrated Security=True");

            //Cria um objeto para fazer o insert
            SqlCommand command = new SqlCommand("insert into pessoa(nome,login,senha,endereco,email,dob,ddd,telefone,dta_cadastro) values(@nome,@login,@senha,@endereco,@email,@dob,@ddd,@telefone,@dta_cadastro)");

            //Abre a conexão com o banco
            conn.Open();
            
            //Informa os parametros para o insert
            command.Parameters.AddWithValue("@nome",nome);
            command.Parameters.AddWithValue("@login",login);
            command.Parameters.AddWithValue("@senha",senha);
            command.Parameters.AddWithValue("@endereco",endereco);
            command.Parameters.AddWithValue("@email",email);
            command.Parameters.AddWithValue("@dob",dob);
            command.Parameters.AddWithValue("@ddd",ddd);
            command.Parameters.AddWithValue("@telefone",telefone);
            //command.Parameters.AddWithValue("@dta_cadastro",dta_cadastro);
        }
    }
}
