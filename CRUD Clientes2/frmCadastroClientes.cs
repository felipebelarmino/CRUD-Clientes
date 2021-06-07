using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Clientes2
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnBuscar.Visible = false;
            btnLimpar.Visible = false;
            tbnSalvar.Visible = false;
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQL Test;Data Source=WINAPM0DO3WYS9V\SQLEXPRESS";
        private string strSql = string.Empty;

        int _linhaIndice;
        string _clientId;
        string _clientName;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.sQLTestDataSet.Clients);
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtTelefone.MaskCompleted && txtNome.Text != "" && txtEndereco.Text != "")
            {
                MessageBox.Show("Campo telefone com preenchimento incorreto.");
                return;
            }

            if (txtNome.Text == "" && txtEndereco.Text != "")
            {
                MessageBox.Show("Favor preencher o campo nome.");
            }

            if (txtNome.Text != "" && txtEndereco.Text == "")
            {
                MessageBox.Show("Favor preencher o campo endereço.");
            }

            if (txtNome.Text == "" && txtEndereco.Text == "")
            {
                MessageBox.Show("Favor preencher os campos nome e endereço.");
            }

            strSql = "insert into Clients (Nome, Telefone, Endereco) values (@Nome, @Telefone, @Endereco)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                clientsTableAdapter.FillByName(sQLTestDataSet.Clients, txtBusca.Text);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                clientsTableAdapter.FillByName(sQLTestDataSet.Clients, txtBusca.Text);
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
            txtBusca.Text = "";
            btnLimpar.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtBusca.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            tbnSalvar.Visible = false;
            btnLimpar.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Clients WHERE ClientID=@ClientId";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientId", SqlDbType.Int).Value = _clientId;

            if (!(MessageBox.Show("Dejesa excluir o cliente: " + _clientName + " ?", "Excluir registro !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                return;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente: " + _clientName + ", excluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            tbnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Há algum campo vazio, favor preencher todos os campos!");
                return;
            }

            strSql = "UPDATE Clients SET Nome=@Nome, Telefone=@Telefone, Endereco=@Endereco WHERE ClientID=@ClientId";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientId", SqlDbType.Int).Value = _clientId;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
            tbnSalvar.Visible = false;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtNome.Text != "")
            {
                btnLimpar.Visible = true;
                tbnSalvar.Visible = true;
            }
            else
            {
                btnLimpar.Visible = false;
                tbnSalvar.Visible = false;
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtNome.Text != "")
            {
                btnLimpar.Visible = true;
                tbnSalvar.Visible = true;
            }
            else
            {
                btnLimpar.Visible = false;
                tbnSalvar.Visible = false;
            }
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Numero máximo de caracteres atingido ou foi digitado algum caractere diferente de número.");
            return;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _linhaIndice = e.RowIndex;

            if (_linhaIndice == -1)
            {
                return;
            }

            DataGridViewRow rowData = dataGridViewClientes.Rows[_linhaIndice];

            _clientId = rowData.Cells[0].Value.ToString();
            _clientName = rowData.Cells[1].Value.ToString();
            txtNome.Text = rowData.Cells[1].Value.ToString();
            txtTelefone.Text = rowData.Cells[2].Value.ToString();
            txtEndereco.Text = rowData.Cells[3].Value.ToString();

            btnExcluir.Visible = true;
            btnAlterar.Visible = true;
            tbnSalvar.Visible = false;
        }
    }
}
