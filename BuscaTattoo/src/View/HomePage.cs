using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuscaTattoo.src.View;

namespace BuscaTattoo
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseBuscaTattooDataSet2.sessao' table. You can move, or remove it, as needed.
            this.sessaoTableAdapter1.Fill(this.databaseBuscaTattooDataSet2.sessao);
            // TODO: This line of code loads data into the 'databaseBuscaTattooDataSet1.sessao' table. You can move, or remove it, as needed.
            this.sessaoTableAdapter.Fill(this.databaseBuscaTattooDataSet1.sessao);

        }

        private void novoUsuárioDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarLogin cadastrarlogin = new CadastrarLogin();
            cadastrarlogin.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarcliente = new CadastrarCliente();
            cadastrarcliente.ShowDialog();
        }
    }
}
