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

namespace CRUD_Clientes2
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if(!txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo telefone corretamente.");
                return;
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
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Retorna o indice da linha no qual a célula foi clicada
            _linhaIndice = e.RowIndex;

            //Se _linhaIndice é menor que -1 então retorna
            if (_linhaIndice == -1)
            {
                return;
            }

            //Cria um objeto DataGridViewRow de um indice particular
            DataGridViewRow rowData = dataGridView1.Rows[_linhaIndice];

            //exibe os valores no textbox
            _clientId = rowData.Cells[0].Value.ToString();
            _clientName = rowData.Cells[1].Value.ToString();
            txtNome.Text = rowData.Cells[1].Value.ToString();
            txtTelefone.Text = rowData.Cells[2].Value.ToString();
            txtEndereco.Text = rowData.Cells[3].Value.ToString();

            btnExcluir.Visible = true;
            btnAlterar.Visible = true;
            tbnSalvar.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            tbnSalvar.Visible = true;
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
            catch(Exception ex)
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
            if (txtNome.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "")
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
            tbnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            clientsTableAdapter.Fill(sQLTestDataSet.Clients);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtNome.Text != "" && txtTelefone.Text != "")
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
            if(txtEndereco.Text != "" && txtNome.Text != "" && txtTelefone.Text != "")
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
        }
    }
}
