using Microsoft.Reporting.Map.WebForms.BingMaps;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Financeiro
{
    public partial class frmgerfinanceiro : Form
    {
        public frmgerfinanceiro()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;


        private void Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND DATE(data) = CURDATE() ORDER BY cod_venda ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buscarcliente()
        {

            try
            {
                string pesquisa = txtcliente.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_clientes WHERE cod_empresa = @cod_empresa AND nome_clientes LIKE @nome";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtcliente.DataSource = dt;
                txtcliente.DisplayMember = "nome_clientes";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    con.FecharConexao();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void Buscar()
        {

            try
            {
                con.AbrirConexao();

                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND @cod_venda = '' OR cod_venda LIKE @cod_venda AND tipo LIKE @tipo AND cliente LIKE @cliente AND data BETWEEN @dataInicial AND @dataFinal ORDER BY data DESC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                cmd.Parameters.AddWithValue("@cod_venda", "%" + txtnumeronota.Text + "%");
                cmd.Parameters.AddWithValue("@tipo", "%" + cbtransacao.Text + "%");
                cmd.Parameters.AddWithValue("@cliente", "%" + txtcliente.Text + "%");
                cmd.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(dtinicial.Text));
                cmd.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(dtfinal.Text));

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();

                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Transação inexistente!");
                    Listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void formatargrid()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Número nota";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Cliente";
            dataGridView1.Columns[2].HeaderText = "Descrição";
            dataGridView1.Columns[7].HeaderText = "Valor Total";
            dataGridView1.Columns[8].HeaderText = "Forma de pagamento";
            dataGridView1.Columns[5].HeaderText = "Desconto";
            dataGridView1.Columns[15].HeaderText = "Taxa";
            dataGridView1.Columns[11].HeaderText = "Dinheiro";
            dataGridView1.Columns[12].HeaderText = "Pix";
            dataGridView1.Columns[13].HeaderText = "Cartão";
            dataGridView1.Columns[6].HeaderText = "Total pago";
            dataGridView1.Columns[4].HeaderText = "´Vendedor";
            dataGridView1.Columns[9].HeaderText = "Data";
            dataGridView1.Columns[10].HeaderText = "Hora";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[14].HeaderText = "Vencimento";
            dataGridView1.Columns[16].HeaderText = "Código da empresa";
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Status";





        }

        private void TotalizarEntradaSaida()
        {
            decimal totalEntrada = 0;
            decimal totalSaida = 0;
            decimal totalDinheiro = 0;
            decimal totalPix = 0;
            decimal totalCartao = 0;
            decimal totalDescontos = 0;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["tipo"].Value != null && row.Cells["valor_total"].Value != null &&
                    row.Cells["dinheiro"].Value != null && row.Cells["pix"].Value != null &&
                    row.Cells["cartao"].Value != null && row.Cells["desconto"].Value != null)
                {
                    string tipo = row.Cells["tipo"].Value.ToString().ToUpper();
                    decimal valorTotal = Convert.ToDecimal(row.Cells["valor_Total"].Value);
                    decimal dinheiro = Convert.ToDecimal(row.Cells["dinheiro"].Value);
                    decimal pix = Convert.ToDecimal(row.Cells["pix"].Value);
                    decimal cartao = Convert.ToDecimal(row.Cells["cartao"].Value);
                    decimal desconto = Convert.ToDecimal(row.Cells["desconto"].Value);


                    if (tipo.Contains("COMPRA"))
                    {
                        totalSaida += valorTotal;
                       
                    }
                    
                    else if (tipo.Contains("VENDA"))
                    {
                        totalEntrada += valorTotal;
                        totalDinheiro += dinheiro;
                        totalPix += pix;
                        totalCartao += cartao;
                    }
                    totalDescontos += desconto;
                }
            }

            decimal saldo = totalEntrada - totalSaida;
            txtsaldo.Text = saldo.ToString("C");            
            txtsaldo.ForeColor = saldo >= 0 ? Color.Green : Color.Red;

            txtentradas.Text = totalEntrada.ToString("C");
            txtsaidas.Text = totalSaida.ToString("C");
            txtdinheiro.Text = totalDinheiro.ToString("C");
            txtpix.Text = totalPix.ToString("C");
            txtcartao.Text = totalCartao.ToString("C");
            txtdescontos.Text = totalDescontos.ToString("C");
        }    

        private void frmgerfinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();

                sql = "SELECT * FROM cad_empresas WHERE cod = @cod_empresa";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        lblempresa.Text = "Empresa: " + reader["nome"].ToString();
                        Listar();
                      
                    }
                }

                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão: " + ex.Message);
            }
            formatargrid();
            TotalizarEntradaSaida();
            pnpesquisa.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtinicial.Value > dtfinal.Value)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final!");                
                dtinicial.Focus();
                return;
            }
            Buscar();
            TotalizarEntradaSaida();
        }

        private void txtcliente_Leave(object sender, EventArgs e)
        {
            if (txtcliente.Text.Trim() == "")
            {
                dtinicial.Focus();
                return;
            }
                
            buscarcliente();
        }

        private void txtnumeronota_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                cbtransacao.Focus();
        }

        private void txtentradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtpix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtsaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtsaidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbtransacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtcliente.Focus();
        }

        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                dtinicial.Focus();
        }

        private void dtinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                dtfinal.Focus();
        }

        private void dtfinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button1.Focus();
        }
    }
}
