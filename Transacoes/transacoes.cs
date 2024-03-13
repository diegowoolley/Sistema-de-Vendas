using MySql.Data.MySqlClient;
using Sistema_de_Vendas.Relatorios.Recibos;
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

namespace Sistema_de_Vendas.Transacoes
{
    public partial class transacoes : Form
    {
        public transacoes()
        {
            InitializeComponent();

        }


        conn con = new conn();        
        string sql;
        string sql1;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        int cod_venda;
        decimal valorfracionado;
        decimal precototal;
        

        private void transacoes_Load(object sender, EventArgs e)
        {
            Listar();
            listarformapagamento();
            formatargrid();

        }

        #region MÉTODOS
        private void Listar()
        {
            try
            {            
                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa ORDER BY cod_venda ASC";                
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

        private void Buscar()
        {
            try
            {
                string pesquisa = txtpesquisa.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND cliente LIKE @cliente AND tipo LIKE @tipo or cod_venda LIKE @cod_venda AND tipo LIKE @tipo or favorecido LIKE @favorecido AND tipo LIKE @tipo";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cliente", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@favorecido", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_venda", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@tipo", "%" + cbtransacao.Text + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Transação inexistente!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     

        }

        private void listarformapagamento()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT forma_pagamento FROM cad_pagamentos WHERE cod_empresa = @cod_empresa ORDER BY forma_pagamento desc";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbformadepagamento.DataSource = dt;
                cbformadepagamento.DisplayMember = "forma_pagamento";
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void calcularvalorvendafracionda()
        {

            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";
            }

            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }

            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }

            if (txtdesconto.Text.Trim() == "")
            {
                txtdesconto.Text = "0,00";
            }

            if (txttaxa.Text.Trim() == "")
            {
                txttaxa.Text = "0,00";
            }

            decimal dinheiro = decimal.Parse(txtdinheiro.Text.Trim().Replace("R$", ""));
            decimal pix = decimal.Parse(txtpix.Text.Trim().Replace("R$", ""));
            decimal cartao = decimal.Parse(txtcartao.Text.Trim().Replace("R$", ""));

            // Somar os valores de dinheiro, pix e cartão
            decimal somaFracionado = dinheiro + pix + cartao;
            valorfracionado = (decimal)somaFracionado;
            lblvalor_total.Text = "Total: " + precototal.ToString("C");

            // Calcular descontos
            decimal descontos = decimal.Parse(txtdesconto.Text.Replace("%", ""));
            decimal valorDescontos = (decimal)precototal * (descontos / 100);

            // Calcular valor com descontos
            decimal valorComDescontos = (decimal)precototal - valorDescontos;

            // Calcular taxa sobre o valor com descontos
            decimal taxa = decimal.Parse(txttaxa.Text.Replace("%", ""));
            decimal resultadoFracionado = valorComDescontos * (1 + (taxa / 100));

            // Calcular troco com descontos e taxas
            decimal troco = somaFracionado - resultadoFracionado;

            if (resultadoFracionado > precototal || cbformadepagamento.Text == "PIX" || cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
            {
                lbltroco.Text = "Troco: R$ 0,00";
            }
            else
            {
                // Atualizar o TextBox do troco
                lbltroco.Text = "Troco: " + troco.ToString("C", CultureInfo.CurrentCulture);
               
            }

            lblvalor_total.Text = "Total: " + resultadoFracionado.ToString("C");
        }

        private void AtualizarQuantidadeProdutosVendidos()
        {
            try
            {

                con.AbrirConexao();
                sql = "SELECT * FROM vendas WHERE cod_empresa = @cod_empresa AND cod_venda = @cod_venda";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);                
                con.FecharConexao();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    con.AbrirConexao();

                    int idProduto = Convert.ToInt32(dt.Rows[i]["cod_produto"].ToString());                    
                    int quantidadeVendida = Convert.ToInt32( dt.Rows[i]["quantidade"]);
                    
                    string updateQuery = $"UPDATE cad_produtos SET quantidade = quantidade - {quantidadeVendida} WHERE cod_produto = {idProduto}";

                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, con.con);
                    updateCommand.ExecuteNonQuery();

                    con.FecharConexao();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a quantidade de produtos: " + ex.Message);
            }

        }

        private void formatargrid()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Número nota";
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
            dataGridView1.Columns[4].HeaderText = "Vendedor";
            dataGridView1.Columns[9].HeaderText = "Data";
            dataGridView1.Columns[10].HeaderText = "Hora";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[14].HeaderText = "Vencimento";
            dataGridView1.Columns[16].HeaderText = "Código da empresa";
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Status";
            dataGridView1.Columns[18].HeaderText = "Favorecido";
            dataGridView1.Columns[19].HeaderText = "Documento";
            dataGridView1.Columns[20].HeaderText = "Descrição";

        }

        #endregion

        #region BOTÕES
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbtransacao.SelectedIndex = -1;
            txtpesquisa.Clear();
            
        }

        private void btncancelarmudanca_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            cbformadepagamento.SelectedIndex = -1;
            txtdinheiro.Text = "0,00";
            txtpix.Text = "0,00";
            txtcartao.Text = "0,00";
            lblvalor_total.Text = "Total:";
            lbltroco.Text = "Troco: ";
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            try
            {

                con.AbrirConexao();
                sql = "SELECT * FROM vendas WHERE cod_empresa = @cod_empresa AND cod_venda = @cod_venda";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.FecharConexao();




                con.AbrirConexao();
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    sql = "UPDATE vendas SET tipo = @tipo, forma_pagamento = @forma_pagamento, dinheiro = @dinheiro, pix = @pix, cartao = @cartao, taxa = @taxa, descontos = @descontos, valor_total = @valor_total, valor_pago = @valor_pago, troco = @troco WHERE cod_venda = @cod_venda";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                    cmd.Parameters.AddWithValue("@tipo", "VENDA");
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                    cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Trim().Replace("R$", ""));
                    cmd.Parameters.AddWithValue("@pix", txtpix.Text.Trim().Replace("R$", ""));
                    cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Trim().Replace("R$", ""));
                    cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Trim().Replace("R$", ""));
                    cmd.Parameters.AddWithValue("@descontos", txtdesconto.Text.Trim().Replace("R$", ""));
                    cmd.Parameters.AddWithValue("@valor_total", precototal);
                    cmd.Parameters.AddWithValue("valor_pago", valorfracionado);
                    cmd.Parameters.AddWithValue("@troco", lbltroco.Text.ToString().Replace("Troco: ", ""));

                    cmd.ExecuteNonQuery();

                }
                con.FecharConexao();


                con.AbrirConexao();
                sql1 = "UPDATE caixa SET tipo = @tipo, forma_pagamento = @forma_pagamento, dinheiro = @dinheiro, pix = @pix, cartao = @cartao, taxa = @taxa, desconto = @desconto, valor_total = @valor_total, valor_pago = @valor_pago, status = @status WHERE cod_venda = @cod_venda";
                cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd1.Parameters.AddWithValue("@tipo", "VENDA");
                cmd1.Parameters.AddWithValue("@desconto", txtdesconto.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                cmd1.Parameters.AddWithValue("@valor_total", precototal);
                cmd1.Parameters.AddWithValue("@valor_pago", valorfracionado);
                cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@status", "À RECEBER");
                cmd1.ExecuteNonQuery();

                con.FecharConexao();
                Listar();
                AtualizarQuantidadeProdutosVendidos();

                MessageBox.Show("Registro Alterado com Sucesso!!");
                panel1.Visible = false;

                DialogResult Result = MessageBox.Show("Deseja imprimir o recibo da Transação?", "Confirmação", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {   
                    cod_venda = cod_venda + 1;
                    funcoes.cod_venda = cod_venda;
                    frmrecibodetalhado frmrecibo = new frmrecibodetalhado();
                    frmrecibo.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #endregion

        #region DATAGRIDVIEW

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_venda = Convert.ToInt32(dataGridView1.CurrentRow.Cells["cod_venda"].Value);            
            precototal = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["valor_total"].Value);
            calcularvalorvendafracionda();
            lblcodigovenda.Text = "Código pagamento: " + cod_venda;

            if (dataGridView1.CurrentRow.Cells["tipo"].Value.ToString() == "ORÇAMENTO")
            {
                DialogResult result = MessageBox.Show("Deseja converter orçamento " + cod_venda + " em venda?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    panel1.Visible = true;
                    cbformadepagamento.SelectedIndex = -1;
                


                }
            }
       

        }


        #endregion

        #region KEYPRESS \ LEAVE \ ENTER \ INDEX CHANGED \ TEXT CHANGED
        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtpix_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txttaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdinheiro_Enter(object sender, EventArgs e)
        {
            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";
            }
            string valor = txtdinheiro.Text.Replace("R$ ", "");
            txtdinheiro.Text = valor;
        }

        private void txtpix_Enter(object sender, EventArgs e)
        {
            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }
            string valor = txtpix.Text.Replace("R$ ", "");
            txtpix.Text = valor;
        }

        private void txtcartao_Enter(object sender, EventArgs e)
        {
            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }
            string valor = txtcartao.Text.Replace("R$ ", "");
            txtcartao.Text = valor;
        }

        private void txtdinheiro_Leave(object sender, EventArgs e)
        {
            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";

            }
            if (decimal.TryParse(txtdinheiro.Text, out decimal valor))
            {

                txtdinheiro.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtpix_Leave(object sender, EventArgs e)
        {
            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }
            if (decimal.TryParse(txtpix.Text, out decimal valor))
            {

                txtpix.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtcartao_Leave(object sender, EventArgs e)
        {
            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }
            if (decimal.TryParse(txtcartao.Text, out decimal valor))
            {

                txtcartao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtdesconto_Leave(object sender, EventArgs e)
        {
            if (txtdesconto.Text == "")
            {
                txtdesconto.Text = "0,00";
            }
            if (decimal.Parse(txtdesconto.Text) > 100)
            {
                MessageBox.Show("Desconto não pode exceder 100%!");
                txtdesconto.Text = "0";
                txtdesconto.Focus();
            }
            txttaxa.Focus();

            calcularvalorvendafracionda();
        }

        private void txttaxa_Leave(object sender, EventArgs e)
        {
            if (txttaxa.Text == "")
            {
                txttaxa.Text = "0,00";
            }

            calcularvalorvendafracionda();
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            cbformadepagamento.SelectedIndex = -1;
            txtdinheiro.Text = "0,00";
            txtpix.Text = "0,00";
            txtcartao.Text = "0,00";
            lblvalor_total.Text = "Total:";
            lbltroco.Text = "Troco: ";
        }

        private void cbformadepagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbformadepagamento.Text == "FRACIONADO")
            {

                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = "R$ 0,00";
                txtdinheiro.Enabled = true;
                txtpix.Text = "R$ 0,00";
                txtpix.Enabled = true;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = true;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdinheiro.Focus();
            }

            if (cbformadepagamento.Text == "DINHEIRO")
            {

                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = precototal.ToString("C");
                txtdinheiro.Enabled = false;
                txtpix.Text = "R$ 0,00";
                txtpix.Enabled = false;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = false;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdesconto.Focus();
            }

            if (cbformadepagamento.Text == "CRÉDITO CLIENTE")
            {

                txtdinheiro.Text = "R$ 0,00"; ;
                txtpix.Text = "R$ 0,00"; ;
                txtcartao.Text = "R$ 0,00";
                txttaxa.Text = "0,00";
                txtdesconto.Text = "0,00";
                lbltroco.Text = "Troco: R$ 0,00";

            }


            if (cbformadepagamento.Text == "PIX" || cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
            {


                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = "0,00";
                txtdinheiro.Enabled = false;
                txtpix.Text = "0,00";
                txtpix.Enabled = false;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = false;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdesconto.Focus();


                if (cbformadepagamento.Text == "PIX")
                {
                    txtpix.Text = precototal.ToString("C");
                    txtdinheiro.Text = "R$ 0,00";
                    txtcartao.Text = "R$ 0,00";
                    txttaxa.Text = "0,00";
                    txtdesconto.Text = "0,00";
                }
                else if (cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
                {
                    txtpix.Text = "R$ 0,00";
                    txtdinheiro.Text = "R$ 0,00";
                    txttaxa.Text = "0,00";
                    txtdesconto.Text = "0,00";
                    txtcartao.Text = precototal.ToString("C");
                }

            }
            lblvalor_total.Text = "Total: " + precototal.ToString("C");
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }




        #endregion




    }
}
