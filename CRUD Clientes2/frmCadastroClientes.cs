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
            btnLimpar.Visible = false;
            tbnSalvar.Visible = false;
            btnExcluirTelefone.Visible = false;
            btnAlterarTelefone.Visible = false;
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQL Test;Data Source=WINAPM0DO3WYS9V\SQLEXPRESS";
        private string strSql = string.Empty;

        int _linhaIndice;
        string _clientId;
        string _clientName;
        string _clientPhoneID;
        string _clientPhoneNumber;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.phonesTableAdapter.Fill(this.sQL_TestDataSet.Phones);
            this.clientsTableAdapter.Fill(this.sQLTestDataSet.Clients);
            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, -1);

            if(txtNome.Text == "")
            {
                btnAdicionarTelefone.Visible = false;
                btnExcluirTodosTelefones.Visible = false;               
            }
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtEndereco.Text == "")
            {
                MessageBox.Show("Favor preencher nome e endereço.");
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

            strSql = "insert into Clients (Nome, Endereco) values (@Nome, @Endereco)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;            
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
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
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
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            btnLimpar.Visible = false;
            btnExcluirTelefone.Visible = false;
            btnExcluirTodosTelefones.Visible = false;
            btnExcluir.Visible = false;
            btnAlterar.Visible = false;
            btnAlterarTelefone.Visible = false;

            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, -1);
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
            strSql = 
                "DELETE FROM Phones WHERE ClientID_FK=@ClientId;" +
                "DELETE FROM Clients WHERE ClientID=@ClientId";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientId", SqlDbType.Int).Value = _clientId;

            if (!(MessageBox.Show("Dejesa excluir todos os dados do cliente: " + _clientName + " ?", "Excluir registro !",
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

            strSql = "UPDATE Clients SET Nome=@Nome, Endereco=@Endereco WHERE ClientID=@ClientId";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientId", SqlDbType.Int).Value = _clientId;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
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
            txtEndereco.Text = rowData.Cells[2].Value.ToString();

            btnExcluir.Visible = true;
            btnAlterar.Visible = true;
            tbnSalvar.Visible = false;

            btnExcluirTelefone.Visible = false;
            btnAlterarTelefone.Visible = false;
            btnAdicionarTelefone.Visible = true;

            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, Int32.Parse(_clientId));

            if (dataGridViewTelefones.Rows.Count < 1 || dataGridViewTelefones.Rows == null)
            {                
                return;
            }           
        }

        private void dataGridViewTelefones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _linhaIndice = e.RowIndex;

            if (_linhaIndice == -1)
            {
                return;
            }

            DataGridViewRow rowData = dataGridViewTelefones.Rows[_linhaIndice];

            _clientPhoneID = rowData.Cells[0].Value.ToString();
            txtTelefone.Text = rowData.Cells[1].Value.ToString();
            _clientPhoneNumber = rowData.Cells[1].Value.ToString();

            btnAdicionarTelefone.Visible = false;
            btnExcluirTelefone.Visible = true;
            btnAlterarTelefone.Visible = true;

        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            if (!txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Favor preencher campo telefone.");
            }

            strSql = "insert into Phones (Telefone, Nome, ClientID_FK) values (@Telefone, @Nome, @ClientID)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = _clientName;
            comando.Parameters.Add("@ClientID", SqlDbType.VarChar).Value = _clientId;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Telefone cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtTelefone.Text = "";
            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, Int32.Parse(_clientId));
        }

        private void btnAlterarTelefone_Click(object sender, EventArgs e)
        {
            if (_clientName == "" || _clientId == null)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            strSql = "UPDATE Phones SET Telefone=@Telefone WHERE PhoneID=@PhoneID";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@PhoneID", SqlDbType.Int).Value = _clientPhoneID;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;

            if (!(MessageBox.Show("Dejesa alterar o telefone: " + _clientPhoneNumber + ", para: " + txtTelefone.Text + " ? ", "Alterar registro !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                return;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Telefone alterado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            btnAdicionarTelefone.Visible = true;
            btnAlterarTelefone.Visible = false;
            btnExcluirTelefone.Visible = false;

            txtTelefone.Text = "";

            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
            txtTelefone.Text = "";
            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, Int32.Parse(_clientId));
        }

        private void btnExcluirTelefone_Click(object sender, EventArgs e)
        {
            if(_clientName == "" || _clientId == null)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            strSql = "DELETE FROM Phones WHERE PhoneID=@PhoneID";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@PhoneID", SqlDbType.Int).Value = _clientPhoneID;

            if (!(MessageBox.Show("Dejesa excluir todos os telefones de: " + _clientName + " ?", "Excluir registro !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                return;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Todos os telefones do cliente: " + _clientName + ", excluídos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
            txtTelefone.Text = "";
            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, Int32.Parse(_clientId));
        }

        private void btnExcluirTodosTelefones_Click(object sender, EventArgs e)
        {
            if (dataGridViewTelefones.Rows.Count < 1 || dataGridViewTelefones.Rows == null)
            {
                MessageBox.Show("O cliente: " + _clientName + ", não possui telefones cadastrados.");
                return;
            }

                if (_clientId == null)
            {
                MessageBox.Show("Nenhum cliente não selecionado.");
                return;
            }

            strSql = "DELETE FROM Phones WHERE ClientID_FK=@ClientId";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientId", SqlDbType.Int).Value = _clientId;

            if (!(MessageBox.Show("Dejesa excluir todos os telefones de: " + _clientName + " ?", "Excluir registro !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                return;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Todos os telefones do cliente: " + _clientName + ", excluídos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
            txtTelefone.Text = "";
            phonesTableAdapter.FillByClientFK(sQL_TestDataSet.Phones, Int32.Parse(_clientId));
        }
    }
}
