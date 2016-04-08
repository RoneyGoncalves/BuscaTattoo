namespace BuscaTattoo
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtasessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tefeloneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBuscaTattooDataSet2 = new BuscaTattoo.DatabaseBuscaTattooDataSet2();
            this.databaseBuscaTattooDataSet = new BuscaTattoo.DatabaseBuscaTattooDataSet();
            this.databaseBuscaTattooDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBuscaTattooDataSet1 = new BuscaTattoo.DatabaseBuscaTattooDataSet1();
            this.sessaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessaoTableAdapter = new BuscaTattoo.DatabaseBuscaTattooDataSet1TableAdapters.sessaoTableAdapter();
            this.sessaoTableAdapter1 = new BuscaTattoo.DatabaseBuscaTattooDataSet2TableAdapters.sessaoTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovoAgendamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.dtasessaoDataGridViewTextBoxColumn,
            this.horasessaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.valorpagoDataGridViewTextBoxColumn,
            this.dddDataGridViewTextBoxColumn,
            this.tefeloneDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.dtacadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessaoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtasessaoDataGridViewTextBoxColumn
            // 
            this.dtasessaoDataGridViewTextBoxColumn.DataPropertyName = "dta_sessao";
            this.dtasessaoDataGridViewTextBoxColumn.HeaderText = "dta_sessao";
            this.dtasessaoDataGridViewTextBoxColumn.Name = "dtasessaoDataGridViewTextBoxColumn";
            this.dtasessaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasessaoDataGridViewTextBoxColumn
            // 
            this.horasessaoDataGridViewTextBoxColumn.DataPropertyName = "hora_sessao";
            this.horasessaoDataGridViewTextBoxColumn.HeaderText = "hora_sessao";
            this.horasessaoDataGridViewTextBoxColumn.Name = "horasessaoDataGridViewTextBoxColumn";
            this.horasessaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorpagoDataGridViewTextBoxColumn
            // 
            this.valorpagoDataGridViewTextBoxColumn.DataPropertyName = "valor_pago";
            this.valorpagoDataGridViewTextBoxColumn.HeaderText = "valor_pago";
            this.valorpagoDataGridViewTextBoxColumn.Name = "valorpagoDataGridViewTextBoxColumn";
            this.valorpagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dddDataGridViewTextBoxColumn
            // 
            this.dddDataGridViewTextBoxColumn.DataPropertyName = "ddd";
            this.dddDataGridViewTextBoxColumn.HeaderText = "ddd";
            this.dddDataGridViewTextBoxColumn.Name = "dddDataGridViewTextBoxColumn";
            this.dddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tefeloneDataGridViewTextBoxColumn
            // 
            this.tefeloneDataGridViewTextBoxColumn.DataPropertyName = "tefelone";
            this.tefeloneDataGridViewTextBoxColumn.HeaderText = "tefelone";
            this.tefeloneDataGridViewTextBoxColumn.Name = "tefeloneDataGridViewTextBoxColumn";
            this.tefeloneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtacadastroDataGridViewTextBoxColumn
            // 
            this.dtacadastroDataGridViewTextBoxColumn.DataPropertyName = "dta_cadastro";
            this.dtacadastroDataGridViewTextBoxColumn.HeaderText = "dta_cadastro";
            this.dtacadastroDataGridViewTextBoxColumn.Name = "dtacadastroDataGridViewTextBoxColumn";
            this.dtacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessaoBindingSource1
            // 
            this.sessaoBindingSource1.DataMember = "sessao";
            this.sessaoBindingSource1.DataSource = this.databaseBuscaTattooDataSet2;
            // 
            // databaseBuscaTattooDataSet2
            // 
            this.databaseBuscaTattooDataSet2.DataSetName = "DatabaseBuscaTattooDataSet2";
            this.databaseBuscaTattooDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseBuscaTattooDataSet
            // 
            this.databaseBuscaTattooDataSet.DataSetName = "DatabaseBuscaTattooDataSet";
            this.databaseBuscaTattooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseBuscaTattooDataSetBindingSource
            // 
            this.databaseBuscaTattooDataSetBindingSource.DataSource = this.databaseBuscaTattooDataSet;
            this.databaseBuscaTattooDataSetBindingSource.Position = 0;
            // 
            // databaseBuscaTattooDataSet1
            // 
            this.databaseBuscaTattooDataSet1.DataSetName = "DatabaseBuscaTattooDataSet1";
            this.databaseBuscaTattooDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessaoBindingSource
            // 
            this.sessaoBindingSource.DataMember = "sessao";
            this.sessaoBindingSource.DataSource = this.databaseBuscaTattooDataSet1;
            // 
            // sessaoTableAdapter
            // 
            this.sessaoTableAdapter.ClearBeforeFill = true;
            // 
            // sessaoTableAdapter1
            // 
            this.sessaoTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(638, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgendamento.Location = new System.Drawing.Point(12, 27);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new System.Drawing.Size(177, 42);
            this.btnNovoAgendamento.TabIndex = 4;
            this.btnNovoAgendamento.Text = "Novo Agendamento";
            this.btnNovoAgendamento.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar Agendamento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(413, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar Agendamento";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cadastrarNovoHorarioDisponivelToolStripMenuItem
            // 
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosDoSistemaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem.Name = "cadastrarNovoHorarioDisponivelToolStripMenuItem";
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarNovoHorarioDisponivelToolStripMenuItem.Text = "Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioDoSistemaToolStripMenuItem,
            this.novoClienteToolStripMenuItem,
            this.novoHorarioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // novoUsuárioDoSistemaToolStripMenuItem
            // 
            this.novoUsuárioDoSistemaToolStripMenuItem.Name = "novoUsuárioDoSistemaToolStripMenuItem";
            this.novoUsuárioDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.novoUsuárioDoSistemaToolStripMenuItem.Text = "Novo Usuário do Sistema";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            // 
            // novoHorarioToolStripMenuItem
            // 
            this.novoHorarioToolStripMenuItem.Name = "novoHorarioToolStripMenuItem";
            this.novoHorarioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.novoHorarioToolStripMenuItem.Text = "Novo Horario";
            // 
            // usuariosDoSistemaToolStripMenuItem
            // 
            this.usuariosDoSistemaToolStripMenuItem.Name = "usuariosDoSistemaToolStripMenuItem";
            this.usuariosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosDoSistemaToolStripMenuItem.Text = "Usuarios do Sistema";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNovoAgendamento);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomePage";
            this.Text = "Busca Tattoo - HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBuscaTattooDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseBuscaTattooDataSet databaseBuscaTattooDataSet;
        private System.Windows.Forms.BindingSource databaseBuscaTattooDataSetBindingSource;
        private DatabaseBuscaTattooDataSet1 databaseBuscaTattooDataSet1;
        private System.Windows.Forms.BindingSource sessaoBindingSource;
        private DatabaseBuscaTattooDataSet1TableAdapters.sessaoTableAdapter sessaoTableAdapter;
        private DatabaseBuscaTattooDataSet2 databaseBuscaTattooDataSet2;
        private System.Windows.Forms.BindingSource sessaoBindingSource1;
        private DatabaseBuscaTattooDataSet2TableAdapters.sessaoTableAdapter sessaoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtasessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tefeloneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button btnNovoAgendamento;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoHorarioDisponivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem novoHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
    }
}