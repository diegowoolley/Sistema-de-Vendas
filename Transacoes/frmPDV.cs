using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Transacoes
{
    public partial class frmPDV : Form
    {
        public frmPDV()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        string sql1;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        double precototal;
        int cod_venda;
        decimal valorfracionado;
        


        private void Buscarprodutos()
        {
            try
            {
                              
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE etiqueta LIKE @etiqueta";
                MySqlDataReader reader;
                cmd = new MySqlCommand(sql, con.con);                               
                cmd.Parameters.AddWithValue("@etiqueta", "%" + txtcod_barras.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                            
                reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    txtcod_barras.Text = reader[19].ToString();
                    txtproduto.Text = reader[1].ToString();
                    if (reader[15] != DBNull.Value)
                    {
                        byte[] image = (byte[])reader[15];
                        MemoryStream es = new MemoryStream(image);
                        pbFoto.Image = Image.FromStream(es);

                    }
                    else
                    {
                        pbFoto.Image = Properties.Resources.download;
                    }
                    con.FecharConexao();
                    
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!");
                    txtcod_barras.Clear();
                    txtproduto.Clear();
                    txtcod_barras.Focus();
                    
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void Buscarclientes()
        {


            try
            {
                string pesquisa = txtClientes.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_clientes WHERE nome_clientes LIKE @nome or cod_clientes LIKE @cod_clientes";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    decimal valoraberto = Convert.ToDecimal(reader[11].ToString());
                    txtClientes.Text = reader[1].ToString();
                    lblCliente.Text = reader[1].ToString();
                    lblClienteBloqueado.Text = reader[13].ToString();
                    lblValoremAberto.Text = valoraberto.ToString("C2");
                    con.FecharConexao();

                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!");
                    txtClientes.Text = "";
                    txtClientes.Focus();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void AtualizarTotais()
        {
            precototal = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null)
                {
                    precototal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
            }

            //lbltotalitens.Text = "Total de itens: " + dataGridView1.RowCount;
            txtsubtotal.Text = precototal.ToString("C");
        }

        private void contarvendas()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT MAX(cod_venda) FROM vendas";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    if (val == "")
                    {
                        cod_venda = 1;
                        lblcodigovenda.Text = "Número da venda: " + cod_venda;
                    }
                    else
                    {

                        cod_venda = int.Parse(dr[0].ToString());
                        cod_venda = cod_venda + 1;
                        lblcodigovenda.Text = "Número da venda: " + cod_venda.ToString();
                        funcoes.cod_venda = cod_venda;

                    }
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão", ex.Message);
            }
        }

        private void listarformapagamento()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT forma_pagamento FROM cad_pagamentos ORDER BY forma_pagamento desc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbformapagamento.DataSource = dt;
                cbformapagamento.DisplayMember = "forma_pagamento";
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void calcularvalorvendafracionda()
        {

            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0";
            }

            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0";
            }

            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0";
            }

            if (txtdesconto.Text.Trim() == "")
            {
                txtdesconto.Text = "0";
            }

            if (txttaxa.Text.Trim() == "")
            {
                txttaxa.Text = "0";
            }         

            decimal dinheiro = decimal.Parse(txtdinheiro.Text.Trim().Replace("R$", ""));
            decimal pix = decimal.Parse(txtpix.Text.Trim().Replace("R$", ""));
            decimal cartao = decimal.Parse(txtcartao.Text.Trim().Replace("R$", ""));

            // Somar os valores de dinheiro, pix e cartão
            decimal somaFracionado = dinheiro + pix + cartao;
            valorfracionado = (decimal)somaFracionado;
            txttotalpagar.Text = precototal.ToString("C");
            
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

            // Atualizar o TextBox do troco
            lbltroco.Text = "Troco: " + troco.ToString("C", CultureInfo.CurrentCulture);
        }

        private void AtualizarQuantidadeProdutosVendidos()
        {
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    con.AbrirConexao();

                    string idProduto = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int quantidadeVendida = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                    string updateQuery = $"UPDATE cad_produtos SET quantidade = quantidade - {quantidadeVendida} WHERE etiqueta = {idProduto}";

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

        private void frmPDV_Load(object sender, EventArgs e)
        {
            
            txtcod_barras.Focus();
            contarvendas();
            listarformapagamento();
            cbformapagamento.SelectedIndex = -1;
            lbloperador.Text = "Operador: " + funcoes.conectado;

        }

        private void txtcod_barras_Leave(object sender, EventArgs e)
        {  
            if(txtcod_barras.Text.Trim() == "")
            {
                txtproduto.Focus();
            }
            else
            {
                Buscarprodutos();
            }
            panel2.Visible =false;
            
        }

        private void cbproduto_Leave(object sender, EventArgs e)
        {
            Buscarprodutos();
        }

        private void txtquantidade_Leave(object sender, EventArgs e)
        {
                       
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE nome_produto = '" + txtproduto.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);

                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null && dataGridView1.Rows[i].Cells[1].Value.ToString() == txtproduto.Text)
                        {
                            double novaQuantidade = double.Parse(txtquantidade.Text.Trim());
                            double quantidadeAtual = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                            dataGridView1.Rows[i].Cells[2].Value = (quantidadeAtual + novaQuantidade).ToString();
                            double teste1 = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                            double teste2 = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                            double resultado = teste1 * teste2;
                            dataGridView1.Rows[i].Cells[4].Value = resultado.ToString("N2");
                            
                            txtcod_barras.Focus();
                            txtitens.Text = r[4].ToString();
                            txtdescricao.Text = r[1].ToString();
                            txtquantidadeun.Text = txtquantidade.Text;
                            txtvalorun.Text = r[10].ToString();
                            txtcod_barras.Clear();
                            txtproduto.Clear();
                            txtquantidade.Text = "1";

                            AtualizarTotais();

                            return;
                        }
                    }
                    double preco = double.Parse(txtquantidade.Text.ToString()) * double.Parse(r[10].ToString());

                    
                    dataGridView1.Rows.Add(r[19],txtproduto.Text, txtquantidade.Text, r[10], preco.ToString("N2"));
                    txtitens.Text = r[4].ToString();
                    txtdescricao.Text = r[1].ToString();
                    txtquantidadeun.Text = txtquantidade.Text;
                    txtvalorun.Text = r[10].ToString();
                   AtualizarTotais();

                }
                con.FecharConexao();
                txtcod_barras.Clear();
                txtproduto.Clear();
                txtquantidade.Text = "1";
                txtcod_barras.Focus();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    int selectedIndex = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    AtualizarTotais();
                    if (dataGridView1.RowCount < 1)
                    {
                        AtualizarTotais();
                        txtcod_barras.Clear();
                        txtproduto.Clear();
                        txtquantidade.Clear();
                        txtcod_barras.Focus();
                        

                    }
                }
                else
                {
                   
                    MessageBox.Show("Não existem itens para remover!");
                    AtualizarTotais();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item para excluir");
            }
        }

        private void txtcod_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtproduto.Focus();
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtcod_barras.Focus();
        }   

        private void cbformapagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbformapagamento.SelectedIndex == 1 || cbformapagamento.SelectedIndex == 2)
            {
                pnfracionado.Enabled = true;
                pnvendaprazo.Visible = false;
                txtClientes.Clear();                
                lblCliente.Text = "...";
                lblClienteBloqueado.Text = "...";
                lblValoremAberto.Text = "0";
                lbltroco.Text = "Troco: ";
                txtdinheiro.Text = "R$ 0.00"; ;
                txtpix.Text = "R$ 0.00"; ;
                txtcartao.Text = "R$ 0.00";
                txttaxa.Text = "0.00";
                txtdesconto.Text = "0.00";
                txtdinheiro.Focus();
            }
            if(cbformapagamento.SelectedIndex == 3)
            {
                pnvendaprazo.Visible=true;
                pnfracionado.Enabled=false;
                txtdinheiro.Text = "R$ 0.00"; ;
                txtpix.Text = "R$ 0.00";;
                txtcartao.Text = "R$ 0.00";
                txttaxa.Text = "0.00";
                txtdesconto.Text = "0.00";
                lbltroco.Text = "Troco: ";
                txtClientes.Focus();
            }
            if (cbformapagamento.SelectedIndex == 0 || cbformapagamento.SelectedIndex == 4 || cbformapagamento.SelectedIndex == 5)
            {
               
                pnvendaprazo.Visible = false;
                pnfracionado.Enabled = false;
                txtdinheiro.Clear();
                txtpix.Clear();
                txtcartao.Clear();
                txttaxa.Clear();
                txtdesconto.Clear();
                txtClientes.Clear();
                lblCliente.Text = "...";
                lblClienteBloqueado.Text = "...";
                lblValoremAberto.Text = "0";
                lbltroco.Text = "Troco: ";
                if (cbformapagamento.SelectedIndex == 0)
                {
                    txtpix.Text = precototal.ToString("C");
                    txtdinheiro.Text = "R$ 0.00";
                    txtcartao.Text = "R$ 0.00";
                    txttaxa.Text = "0.00";
                    txtdesconto.Text = "0.00";
                }
                else if (cbformapagamento.SelectedIndex == 4 || cbformapagamento.SelectedIndex == 5)
                {
                    txtpix.Text = "R$ 0.00";
                    txtdinheiro.Text = "R$ 0.00";
                    txttaxa.Text = "0.00";
                    txtdesconto.Text = "0.00";
                    txtcartao.Text = precototal.ToString("C");
                }

            }
            txttotalpagar.Text = precototal.ToString("C");



        }

        private void txtClientes_Leave(object sender, EventArgs e)
        {
            if(txtClientes.Text.Trim() == "")
            {
                dtVencimento.Focus();
                return;
            }
            Buscarclientes();
        }

        private void txtproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtquantidade.Focus();
        }

        private void txtDinheiro_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdinheiro.Text, out decimal valor))
            {

                txtdinheiro.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtdinheiro_Enter(object sender, EventArgs e)
        {
            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0";
            }
            string valor = txtdinheiro.Text.Replace("R$ ", "");
            txtdinheiro.Text = valor;
        }

        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtpix_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtpix.Text, out decimal valor))
            {

                txtpix.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtpix_Enter(object sender, EventArgs e)
        {
            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0";
            }
            string valor = txtpix.Text.Replace("R$ ", "");
            txtpix.Text = valor;
        }

        private void txtpix_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtcartao_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtcartao.Text, out decimal valor))
            {

                txtcartao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtcartao_Enter(object sender, EventArgs e)
        {
            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0";
            }
            string valor = txtcartao.Text.Replace("R$ ", "");
            txtcartao.Text = valor;
        }

        private void txtcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txttaxa_Leave(object sender, EventArgs e)
        {
            if (txttaxa.Text == "")
            {
                txttaxa.Text = "0";
            }

            decimal valorPorcentagem = (decimal)float.Parse(txttaxa.Text);

            txttaxa.Text = (valorPorcentagem).ToString() + "%";
            calcularvalorvendafracionda();
        }

        private void txttaxa_Enter(object sender, EventArgs e)
        {
            if (txttaxa.Text.Trim() == "")
            {
                txttaxa.Text = "0";
            }
            string valor = txttaxa.Text.Replace("%", "");
            txttaxa.Text = valor;
        }

        private void txttaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdesconto_Leave(object sender, EventArgs e)
        {
            if (txtdesconto.Text == "")
            {
                txtdesconto.Text = "0";
            }
            if (decimal.Parse(txtdesconto.Text) > 100)
            {
                MessageBox.Show("Desconto não pode exceder 100%!");
                txtdesconto.Text = "0";
                txtdesconto.Focus();
            }

            decimal valorPorcentagem = (decimal)float.Parse(txtdesconto.Text);

            txtdesconto.Text = (valorPorcentagem).ToString() + "%";

            calcularvalorvendafracionda();
        }

        private void txtdesconto_Enter(object sender, EventArgs e)
        {
            if (txtdesconto.Text.Trim() == "")
            {
                txtdesconto.Text = "0";
            }
            string valor = txtdesconto.Text.Replace("%", "");
            txtdesconto.Text = valor;
        }

        private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

                MessageBox.Show("Insira produtos na sua venda!");
                txtcod_barras.Focus();
                return;
            }

            if (cbformapagamento.Text == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                cbformapagamento.Focus();
                return;
            }

            if (cbformapagamento.Text == "FRACIONADO" || cbformapagamento.Text == "DINHEIRO")
            {
                if (valorfracionado < (decimal)precototal)
                {
                    MessageBox.Show("Valor fracionado não pode ser menor que o valor de venda!");
                    cbformapagamento.Focus();
                    return;
                }

            }
            string descricaoProduto = Convert.ToString(dataGridView1.Rows[0].Cells["descricao"].Value);
                       

            if (string.IsNullOrEmpty(descricaoProduto))
            {
                MessageBox.Show("A descrição do produto não pode ser nula ou vazia." + descricaoProduto);
                
                return;
            }

            if (dtVencimento.Value < DateTime.Now.Date)
            {
                MessageBox.Show("A data de vencimento não pode ser menor que a data atual!");
                dtVencimento.Focus();
                return;
            }



            try
            {
                con.AbrirConexao();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, valor_unitario, dinheiro, pix, cartao, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa, vencimento, status) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @valor_unitario, @dinheiro, @pix, @cartao, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa, @vencimento, @status)";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                    cmd.Parameters.AddWithValue("@tipo", "VENDA PDV");
                    cmd.Parameters.AddWithValue("@cliente", txtClientes.Text);
                    cmd.Parameters.AddWithValue("@produto", dataGridView1.Rows[i].Cells["descricao"].Value);
                    cmd.Parameters.AddWithValue("@quantidade", dataGridView1.Rows[i].Cells["quantidade"].Value);
                    cmd.Parameters.AddWithValue("@valor_unitario", dataGridView1.Rows[i].Cells["valor_unitario"].Value);
                    cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@vencimento", DateTime.Parse(dtVencimento.Value.Date.ToString("yyyy/MM/dd")));
                    cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                    cmd.Parameters.AddWithValue("@vendedor", funcoes.conectado);
                    cmd.Parameters.AddWithValue("@descontos", txtdesconto.Text.Replace("%", "").Trim());
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                    cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@valor_pago", txttotalpagar.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@troco", lbltroco.Text.Replace("Troco: ", "").Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@data", DateTime.Today);
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                    cmd.Parameters.AddWithValue("@status", "FATURADA");

                    cmd.ExecuteNonQuery();

                }

                sql1 = "INSERT INTO caixa (cod_venda, tipo, cliente, vendedor, desconto, forma_pagamento, valor_total, valor_pago, data, hora, dinheiro, pix, cartao, vencimento, taxa, cod_empresa, status) VALUES (@cod_venda, @tipo, @cliente, @vendedor, @desconto, @forma_pagamento, @valor_total, @valor_pago, @data, @hora, @dinheiro, @pix, @cartao, @vencimento, @taxa, @cod_empresa, @status)";
                cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd1.Parameters.AddWithValue("@tipo", "VENDA PDV");
                cmd1.Parameters.AddWithValue("@cliente", txtClientes.Text);
                cmd1.Parameters.AddWithValue("@vendedor", funcoes.conectado);
                cmd1.Parameters.AddWithValue("@desconto", txtdesconto.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                cmd1.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@valor_pago", Convert.ToString(precototal).Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@data", DateTime.Today);
                cmd1.Parameters.AddWithValue("@hora", DateTime.Now);
                cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@vencimento", DateTime.Parse(dtVencimento.Value.Date.ToString("yyyy/MM/dd")));
                cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                cmd1.Parameters.AddWithValue("@status", "FATURADA");

                cmd1.ExecuteNonQuery();
                con.FecharConexao();


                MessageBox.Show("Venda salva com sucesso!");

                AtualizarQuantidadeProdutosVendidos();
                contarvendas();
                dataGridView1.Rows.Clear();
                txtcod_barras.Clear();
                txtproduto.Clear();
                txtquantidade.Text = "1";
                txtitens.Clear();
                txtdescricao.Clear();
                txtquantidadeun.Clear();
                txtvalorun.Clear();
                txtsubtotal.Clear();
                txttotalpagar.Clear();
                dataGridView1.Rows.Clear();
                txtcod_barras.Focus();
                cbformapagamento.SelectedIndex = -1;
                pnfracionado.Visible = false;
                pnvendaprazo.Visible = false;
                txtdinheiro.Clear();
                txtpix.Clear();
                txtcartao.Clear();
                txttaxa.Clear();
                txtdesconto.Clear();
                txtClientes.Clear();                
                lblCliente.Text = "...";
                lblClienteBloqueado.Text = "...";
                lblValoremAberto.Text = "0";
                precototal = 0;
                txttotalpagar.Clear();
                txtcod_barras.Focus();
                pbFoto.Image = Properties.Resources.download;
                panel2.Visible = true;
                cbformapagamento.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        

        }

        private void frmPDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento do formulário
            }
        }

        private void btnfecharvenda_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                panel1.Enabled = false;
                btnremover.Enabled = false;
                btnfecharvenda.Enabled = false;
                cbformapagamento.Enabled = true;
                cbformapagamento.Focus();
            }
            else
            {
                MessageBox.Show("Insira produtos para fechar uma venda!");
                txtcod_barras.Focus();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Deseja realmente cancelar a venda de número " + cod_venda + " ?", "Cancelamento", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                txtcod_barras.Clear();
                txtproduto.Clear();
                txtquantidade.Text = "1";
                txtitens.Clear();
                txtdescricao.Clear();
                txtquantidadeun.Clear();
                txtvalorun.Clear();
                txtsubtotal.Clear();
                txttotalpagar.Clear();
                dataGridView1.Rows.Clear();
                txtcod_barras.Focus();
                cbformapagamento.SelectedIndex = -1;
                cbformapagamento.Enabled = false;
                pnfracionado.Enabled = false;
                pnvendaprazo.Visible = false;
                panel1.Enabled = true;
                txtdinheiro.Text = "R$ 0.00";
                txtpix.Text = "R$ 0.00";
                txtcartao.Text = "R$ 0.00";
                txttaxa.Text = "0.00";
                txtdesconto.Text = "0.00";
                txtClientes.Clear();
                lblCliente.Text = "...";
                lblClienteBloqueado.Text = "...";
                lblValoremAberto.Text = "0";
                precototal = 0;
                txttotalpagar.Clear();

                MessageBox.Show("Venda cancelada com sucesso!");
            }
            txtcod_barras.Focus();
        }

        
    }
    
}
