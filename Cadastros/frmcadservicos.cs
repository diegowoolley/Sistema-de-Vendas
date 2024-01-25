using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Cadastros
{
    public partial class frmcadservicos : Form
    {
        public frmcadservicos()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string id;
        private void frmcadservicos_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_servicos ORDER BY descricao ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCliente.DataSource = dt;
            con.FecharConexao();
        }


        private void formatargrid()
        {
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[1].HeaderText = "Descrição";
            dgCliente.Columns[2].HeaderText = "Valor";
            dgCliente.Columns[0].Visible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = true;
            txtvalor.Enabled = true;
            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtnome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Serviço!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }

            if (txtvalor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Valor!");
                txtvalor.Clear();
                txtvalor.Focus();
                return;
            }

            else
            {       //verifica se o usuário já exite no banco de dados

                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_servicos WHERE descricao = @descricao", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@descricao", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Serviço já cadastrado!");
                        txtnome.Clear();
                        txtnome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_servicos(descricao, valor) VALUES (@descricao, @valor)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@descricao", txtnome.Text);
                        cmd.Parameters.AddWithValue("@valor", txtvalor.Text.Replace("R$", "").Trim().Replace(",", "."));




                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        //desabilitar botões e campos
                        txtnome.Enabled = false;
                        txtnome.Clear();
                        txtvalor.Enabled = false;
                        txtvalor.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Serviço cadastado com sucesso!");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar!" + ex);
                }

            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Serviço!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }

            if (txtvalor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Valor!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }


                try
                {
                                      
                        con.AbrirConexao();
                        sql = "UPDATE cad_servicos SET descricao = @descricao, valor = @valor WHERE cod_servico = @id";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@descricao", txtnome.Text);
                        cmd.Parameters.AddWithValue("@valor", txtvalor.Text.Replace("R$", "").Trim().Replace(",", "."));

                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        Listar();

                        MessageBox.Show("Registro Alterado com Sucesso!!");
                        txtnome.Enabled = false;
                        txtnome.Clear();
                        txtvalor.Enabled = false;
                        txtvalor.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Cadastrar!");
                }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_servicos WHERE cod_servico = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();

                txtnome.Enabled = false;
                txtnome.Clear();
                txtvalor.Enabled = false;
                txtvalor.Clear();
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
            else
            {
                Listar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = false;
            txtnome.Clear();
            txtvalor.Enabled = false;
            txtvalor.Clear();
            btnAdicionar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;



            btnNovo.Enabled = true;

            btnNovo.Focus();
            Listar();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                id = dgCliente.CurrentRow.Cells[0].Value.ToString();


                txtnome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                txtvalor.Text = "R$ " + dgCliente.CurrentRow.Cells[2].Value.ToString();
                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                txtnome.Enabled = true;
                txtnome.Focus();
                txtvalor.Enabled=true;
                
            }
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender , e);
            if (e.KeyChar == 13)
                txtnome.Focus();
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtvalor.Focus();
        }

        private void txtvalor_Enter(object sender, EventArgs e)
        {
            string valor = txtvalor.Text.Replace("R$ ", "");
            txtvalor.Text = valor;
        }

        private void txtvalor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtvalor.Text, out decimal valor))
            {

                txtvalor.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
        }
    }
}
