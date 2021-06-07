
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLTestDataSet = new CRUD_Clientes2.SQLTestDataSet();
            this.grpClienteInfo = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpBusca = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblNomeBusca = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new CRUD_Clientes2.SQLTestDataSetTableAdapters.ClientsTableAdapter();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLTestDataSet)).BeginInit();
            this.grpClienteInfo.SuspendLayout();
            this.grpBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AutoGenerateColumns = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridViewClientes.DataSource = this.clientsBindingSource;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 305);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(664, 399);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 220;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 250;
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
            this.grpClienteInfo.Controls.Add(this.lblTelefone);
            this.grpClienteInfo.Controls.Add(this.lblNome);
            this.grpClienteInfo.Controls.Add(this.txtEndereco);
            this.grpClienteInfo.Controls.Add(this.txtTelefone);
            this.grpClienteInfo.Controls.Add(this.txtNome);
            this.grpClienteInfo.Location = new System.Drawing.Point(12, 72);
            this.grpClienteInfo.Name = "grpClienteInfo";
            this.grpClienteInfo.Size = new System.Drawing.Size(664, 151);
            this.grpClienteInfo.TabIndex = 1;
            this.grpClienteInfo.TabStop = false;
            this.grpClienteInfo.Text = "Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(528, 117);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbnSalvar
            // 
            this.tbnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tbnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbnSalvar.Location = new System.Drawing.Point(528, 73);
            this.tbnSalvar.Name = "tbnSalvar";
            this.tbnSalvar.Size = new System.Drawing.Size(119, 29);
            this.tbnSalvar.TabIndex = 4;
            this.tbnSalvar.Text = "Salvar";
            this.tbnSalvar.UseVisualStyleBackColor = false;
            this.tbnSalvar.Click += new System.EventHandler(this.tbnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(90, 111);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 29);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(367, 111);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 29);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(15, 79);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(69, 17);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(470, 38);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(39, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 79);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(357, 20);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(547, 38);
            this.txtTelefone.Mask = "(00) 0000 - 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // grpBusca
            // 
            this.grpBusca.Controls.Add(this.btnBuscarTodos);
            this.grpBusca.Controls.Add(this.btnBuscar);
            this.grpBusca.Controls.Add(this.txtBusca);
            this.grpBusca.Controls.Add(this.lblNomeBusca);
            this.grpBusca.Location = new System.Drawing.Point(12, 229);
            this.grpBusca.Name = "grpBusca";
            this.grpBusca.Size = new System.Drawing.Size(664, 70);
            this.grpBusca.TabIndex = 2;
            this.grpBusca.TabStop = false;
            this.grpBusca.Text = "Busca";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarTodos.ForeColor = System.Drawing.Color.Snow;
            this.btnBuscarTodos.Location = new System.Drawing.Point(534, 27);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(113, 23);
            this.btnBuscarTodos.TabIndex = 2;
            this.btnBuscarTodos.Text = "Todos os registros";
            this.btnBuscarTodos.UseVisualStyleBackColor = false;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.Location = new System.Drawing.Point(453, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(90, 29);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(357, 20);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblNomeBusca
            // 
            this.lblNomeBusca.AutoSize = true;
            this.lblNomeBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBusca.Location = new System.Drawing.Point(39, 29);
            this.lblNomeBusca.Name = "lblNomeBusca";
            this.lblNomeBusca.Size = new System.Drawing.Size(45, 17);
            this.lblNomeBusca.TabIndex = 0;
            this.lblNomeBusca.Text = "Nome";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(507, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(169, 54);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(7, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(494, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema de gerenciamento de usuários - Custom DPSP";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblSubTitulo.Location = new System.Drawing.Point(12, 41);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(155, 14);
            this.lblSubTitulo.TabIndex = 3;
            this.lblSubTitulo.Text = "Autor: Felipe Gomes Belarmino";
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 716);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.grpBusca);
            this.Controls.Add(this.grpClienteInfo);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCadastroClientes";
            this.Text = "Cadastro de clientes - DPSP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLTestDataSet)).EndInit();
            this.grpClienteInfo.ResumeLayout(false);
            this.grpClienteInfo.PerformLayout();
            this.grpBusca.ResumeLayout(false);
            this.grpBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button tbnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox grpBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblNomeBusca;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSubTitulo;
    }
}

