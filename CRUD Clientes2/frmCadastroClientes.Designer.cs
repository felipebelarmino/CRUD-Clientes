
namespace CRUD_Clientes2
{
    partial class frmCadastroClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLTestDataSet = new CRUD_Clientes2.SQLTestDataSet();
            this.grpClienteInfo = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.grpBusca = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblNomeBusca = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new CRUD_Clientes2.SQLTestDataSetTableAdapters.ClientsTableAdapter();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dataGridViewTelefones = new System.Windows.Forms.DataGridView();
            this.grpTelefones = new System.Windows.Forms.GroupBox();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.btnAlterarTelefone = new System.Windows.Forms.Button();
            this.btnExcluirTelefone = new System.Windows.Forms.Button();
            this.btnExcluirTodosTelefones = new System.Windows.Forms.Button();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_TestDataSet = new CRUD_Clientes2.SQL_TestDataSet();
            this.phonesTableAdapter = new CRUD_Clientes2.SQL_TestDataSetTableAdapters.PhonesTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLTestDataSet)).BeginInit();
            this.grpClienteInfo.SuspendLayout();
            this.grpBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefones)).BeginInit();
            this.grpTelefones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_TestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.AutoGenerateColumns = false;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridViewClientes.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.dataGridViewClientes, "dataGridViewClientes");
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.sQLTestDataSet;
            // 
            // sQLTestDataSet
            // 
            this.sQLTestDataSet.DataSetName = "SQLTestDataSet";
            this.sQLTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpClienteInfo
            // 
            this.grpClienteInfo.Controls.Add(this.btnLimpar);
            this.grpClienteInfo.Controls.Add(this.tbnSalvar);
            this.grpClienteInfo.Controls.Add(this.btnExcluir);
            this.grpClienteInfo.Controls.Add(this.btnAlterar);
            this.grpClienteInfo.Controls.Add(this.lblEndereco);
            this.grpClienteInfo.Controls.Add(this.lblNome);
            this.grpClienteInfo.Controls.Add(this.txtEndereco);
            this.grpClienteInfo.Controls.Add(this.txtNome);
            resources.ApplyResources(this.grpClienteInfo, "grpClienteInfo");
            this.grpClienteInfo.Name = "grpClienteInfo";
            this.grpClienteInfo.TabStop = false;
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbnSalvar
            // 
            this.tbnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.tbnSalvar, "tbnSalvar");
            this.tbnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbnSalvar.Name = "tbnSalvar";
            this.tbnSalvar.UseVisualStyleBackColor = false;
            this.tbnSalvar.Click += new System.EventHandler(this.tbnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.Name = "lblEndereco";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // txtEndereco
            // 
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTelefone
            // 
            resources.ApplyResources(this.txtTelefone, "txtTelefone");
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // grpBusca
            // 
            this.grpBusca.Controls.Add(this.btnBuscarTodos);
            this.grpBusca.Controls.Add(this.txtBusca);
            this.grpBusca.Controls.Add(this.lblNomeBusca);
            resources.ApplyResources(this.grpBusca, "grpBusca");
            this.grpBusca.Name = "grpBusca";
            this.grpBusca.TabStop = false;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarTodos.ForeColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.btnBuscarTodos, "btnBuscarTodos");
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.UseVisualStyleBackColor = false;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // txtBusca
            // 
            resources.ApplyResources(this.txtBusca, "txtBusca");
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblNomeBusca
            // 
            resources.ApplyResources(this.lblNomeBusca, "lblNomeBusca");
            this.lblNomeBusca.Name = "lblNomeBusca";
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // lblSubTitulo
            // 
            resources.ApplyResources(this.lblSubTitulo, "lblSubTitulo");
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblSubTitulo.Name = "lblSubTitulo";
            // 
            // dataGridViewTelefones
            // 
            this.dataGridViewTelefones.AllowUserToAddRows = false;
            this.dataGridViewTelefones.AllowUserToDeleteRows = false;
            this.dataGridViewTelefones.AutoGenerateColumns = false;
            this.dataGridViewTelefones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTelefones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.telefoneDataGridViewTextBoxColumn,
            this.Nome});
            this.dataGridViewTelefones.DataSource = this.phonesBindingSource;
            resources.ApplyResources(this.dataGridViewTelefones, "dataGridViewTelefones");
            this.dataGridViewTelefones.Name = "dataGridViewTelefones";
            this.dataGridViewTelefones.ReadOnly = true;
            this.dataGridViewTelefones.RowHeadersVisible = false;
            this.dataGridViewTelefones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTelefones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelefones_CellClick);
            // 
            // grpTelefones
            // 
            this.grpTelefones.Controls.Add(this.lblTelefone);
            this.grpTelefones.Controls.Add(this.btnExcluirTodosTelefones);
            this.grpTelefones.Controls.Add(this.btnExcluirTelefone);
            this.grpTelefones.Controls.Add(this.btnAlterarTelefone);
            this.grpTelefones.Controls.Add(this.btnAdicionarTelefone);
            this.grpTelefones.Controls.Add(this.txtTelefone);
            this.grpTelefones.Controls.Add(this.dataGridViewTelefones);
            resources.ApplyResources(this.grpTelefones, "grpTelefones");
            this.grpTelefones.Name = "grpTelefones";
            this.grpTelefones.TabStop = false;
            // 
            // btnAdicionarTelefone
            // 
            resources.ApplyResources(this.btnAdicionarTelefone, "btnAdicionarTelefone");
            this.btnAdicionarTelefone.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = true;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click);
            // 
            // btnAlterarTelefone
            // 
            this.btnAlterarTelefone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlterarTelefone.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAlterarTelefone, "btnAlterarTelefone");
            this.btnAlterarTelefone.Name = "btnAlterarTelefone";
            this.btnAlterarTelefone.UseVisualStyleBackColor = false;
            this.btnAlterarTelefone.Click += new System.EventHandler(this.btnAlterarTelefone_Click);
            // 
            // btnExcluirTelefone
            // 
            this.btnExcluirTelefone.BackColor = System.Drawing.Color.Red;
            this.btnExcluirTelefone.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnExcluirTelefone, "btnExcluirTelefone");
            this.btnExcluirTelefone.Name = "btnExcluirTelefone";
            this.btnExcluirTelefone.UseVisualStyleBackColor = false;
            this.btnExcluirTelefone.Click += new System.EventHandler(this.btnExcluirTelefone_Click);
            // 
            // btnExcluirTodosTelefones
            // 
            this.btnExcluirTodosTelefones.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExcluirTodosTelefones, "btnExcluirTodosTelefones");
            this.btnExcluirTodosTelefones.ForeColor = System.Drawing.Color.White;
            this.btnExcluirTodosTelefones.Name = "btnExcluirTodosTelefones";
            this.btnExcluirTodosTelefones.UseVisualStyleBackColor = false;
            this.btnExcluirTodosTelefones.Click += new System.EventHandler(this.btnExcluirTodosTelefones_Click);
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            resources.ApplyResources(this.ClientID, "ClientID");
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            resources.ApplyResources(this.enderecoDataGridViewTextBoxColumn, "enderecoDataGridViewTextBoxColumn");
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.sQL_TestDataSet;
            // 
            // sQL_TestDataSet
            // 
            this.sQL_TestDataSet.DataSetName = "SQL_TestDataSet";
            this.sQL_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PhoneID";
            this.ID.FillWeight = 45.15199F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.FillWeight = 106.599F;
            resources.ApplyResources(this.telefoneDataGridViewTextBoxColumn, "telefoneDataGridViewTextBoxColumn");
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 148.249F;
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            // 
            // frmCadastroClientes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTelefones);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.grpBusca);
            this.Controls.Add(this.grpClienteInfo);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "frmCadastroClientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLTestDataSet)).EndInit();
            this.grpClienteInfo.ResumeLayout(false);
            this.grpClienteInfo.PerformLayout();
            this.grpBusca.ResumeLayout(false);
            this.grpBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefones)).EndInit();
            this.grpTelefones.ResumeLayout(false);
            this.grpTelefones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_TestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private SQLTestDataSet sQLTestDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private SQLTestDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.GroupBox grpClienteInfo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button tbnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox grpBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblNomeBusca;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dataGridViewTelefones;
        private SQL_TestDataSet sQL_TestDataSet;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private SQL_TestDataSetTableAdapters.PhonesTableAdapter phonesTableAdapter;
        private System.Windows.Forms.GroupBox grpTelefones;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.Button btnExcluirTelefone;
        private System.Windows.Forms.Button btnAlterarTelefone;
        private System.Windows.Forms.Button btnExcluirTodosTelefones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Label lblTelefone;
    }
}

