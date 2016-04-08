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
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String senha = txtSenha.Text;


        }

        private void linkLblEsqueceuasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contate o Administrador do sistema!");
        }
    }
}
