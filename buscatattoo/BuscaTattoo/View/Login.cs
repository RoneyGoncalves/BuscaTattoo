using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BuscaTattoo.View;

namespace BuscaTattoo
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            String login = txtLogin.Text;
            String senha = txtSenha.Text;
        }
        
        //Conexão com o banco de dados
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Roninho\documents\visual studio 2012\Projects\BuscaTattoo\BuscaTattoo\DatabaseBuscaTattoo.mdf;Integrated Security=True");
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }
    }
}
