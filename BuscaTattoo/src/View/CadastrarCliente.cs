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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Instancializa a classe ControlPessoa
            ControlPessoa controlpessoa = new ControlPessoa();
            
            //Cia variáveis para receber as textbox
            String Nome = txtNome.Text;
            String Cpf = txtCPF.Text;
            String Endereco = txtEndereco.Text;
            String Email = txtEmail.Text;
            String Dob = txtDOB.Text;
            String Telefone = txtTelefone.Text;
            String Dta_cadastro = DateTime.Now.ToShortDateString();

            try 
            {
                //Verifica Nome
                if(txtNome.TextLength <= 0)
                {
                    MessageBox.Show("Digite um nome!\nExemplo: Eduardo Alves Machado");
                    return;
                }//Fim do if verifica nome

                //Verifica cpf
                //Pegar o algoritmo

                //Verifica endereço
                if(txtEndereco.TextLength <= 0)
                {
                    MessageBox.Show("Digite o endereço!\nExemplo: Rua Astorga, 122, Centro, Curitiba-PR");
                    return;
                }//Fim do if verifica endereco

                //Verifica email
                //Pegar algoritmo para verificar email

                //Verifica dob
                if(txtDOB.TextLength <= 0)
                {
                    MessageBox.Show("Digite a data de nascimento!\nExemplo: 15/08/1994");
                    return;
                }//Fim do if verifica dob

                //Verifica telefone
                if(txtTelefone.TextLength <= 0)
                {
                    MessageBox.Show("Digite o telefone!\nExemplo: (41)9898-9898");
                }//Fim do if verifica telefone

            }//Fim do try
            catch { }//Fim do catch

            if(controlpessoa.verificaIfExistCPFinDB(Cpf))
            {
                controlpessoa.atualizaCadastroCPF(Nome,Cpf,Endereco,Email,Dob,Telefone,Dta_cadastro);
                MessageBox.Show("Cpf Já existe em nosso sistema!\n O Cadastro foi atualizado com sucesso!");
            }else
            {
                controlpessoa.insereNovoCliente(Nome, Cpf, Endereco, Email, Dob, Telefone, Dta_cadastro);
                MessageBox.Show("Cadastrado com sucesso!");
            }//Fim do if else

        }//Fim do btnEnviar
    }//Fim da classe CadastrarCliente
}//Fim do namespace
