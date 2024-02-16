﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Vendas.Transacoes
{
    public partial class frmvendas_compras : Form
    {
        public frmvendas_compras()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        string sql1;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        double precototal;
        decimal valorfracionado;
        int cod_venda;       
        string indiceselecionado;
       

        private void listarvendedor()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT nome_funcionario FROM cad_funcionarios WHERE cargo_funcionario = 'VENDEDOR' ORDER BY nome_funcionario asc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbvendedor.DataSource = dt;
                cbvendedor.DisplayMember = "nome_funcionario";
                con.FecharConexao();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão",ex.Message);
            }
            }

        private void AtualizarTotais()
        {
            precototal = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[9].Value != null)
                {
                    precototal += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
                }
            }

            lbltotalitens.Text = "Total de itens: " + dataGridView1.RowCount;
            lblvalortotal.Text = "Valor Total: " + precototal.ToString("C");
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
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }       

        private void Buscarclientes()
        {


            try
            {
                string pesquisa = cbclientes.Text;            
                              
                con.AbrirConexao();
                sql = "SELECT * FROM cad_clientes WHERE cod_empresa = @cod_empresa AND nome_clientes LIKE @nome or cod_clientes LIKE @cod_clientes";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();                
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbclientes.DataSource = dt;
                cbclientes.DisplayMember = "nome_clientes";
                reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    if (reader[13].ToString() == "BLOQUEADO")
                    {
                        cbclientes.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        cbclientes.BackColor = Color.White;
                    }
                    con.FecharConexao();

                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!");                    
                    cbclientes.Text = "";
                    cbclientes.Focus();                    
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }
             
        private void Buscarprodutos()
        {
            try
            {
                string pesquisa = cbproduto.Text;
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND nome_produto LIKE @nome or cod_produto LIKE @cod_produto or etiqueta LIKE @etiqueta";
                MySqlDataReader reader;
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbproduto.DataSource = dt;
                cbproduto.DisplayMember = "nome_produto";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    con.FecharConexao();
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!");
                    cbproduto.Text = "";
                    cbproduto.Focus();
                    return;
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

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

                    }
                }
                con.FecharConexao();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão",ex.Message);
            }
         }

        private void frmvendas_compras_Load(object sender, EventArgs e)
        {
            listarvendedor();   
            cbvendedor.SelectedIndex = -1;         
            listarformapagamento();
            cbformapagamento.SelectedIndex = -1;
            contarvendas();
            

        }

        private void trocadevolucao()
        {   
           
            cod_venda = int.Parse(txtretornagrid.Text);
            try
            {

                con.AbrirConexao();
                sql = "SELECT * FROM vendas WHERE cod_venda = @cod_venda ORDER BY cod_venda ASC";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_venda", cod_venda);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.FecharConexao();
                              

                if (dt.Rows.Count > 0 && dt.Rows[0]["tipo"].ToString() != "DEVOLUÇÃO" && dt.Rows[0]["tipo"].ToString() != "TROCA" && dt.Rows[0]["tipo"].ToString() != "VENDA PDV")
                {
                    
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            dataGridView1.RowCount,
                            dt.Rows[i]["cod_produto"],
                            dt.Rows[i]["tipo"],
                            dt.Rows[i]["cliente"],
                            dt.Rows[i]["produto"],
                            dt.Rows[i]["quantidade"],
                            dt.Rows[i]["categoria"],
                            dt.Rows[i]["valor_unitario"],
                            dt.Rows[i]["vendedor"],
                            dt.Rows[i]["valor_total"]                             
                        );                                             
                                              
                       
                    }
                    dataGridView1.Enabled = false;
                    txtretornagrid.Clear();
                    panel1.Visible = false;
                    cbtransacao.Enabled = false;
                    cbclientes.Enabled = false;
                    cbproduto.Enabled = false;
                    txtquantidade.Enabled = false;
                    cbvendedor.Enabled = false;
                    btnadicionar.Enabled = false;
                    btnremoveritens.Enabled = false;
                    lblcodigovenda.Text = "Código da transação: " + cod_venda;
                    lblvalortotal.Text = "Valor Total: " + dt.Rows[0]["valor_total"];
                    DialogResult result = MessageBox.Show("Realmente deseja fazer essa " + cbtransacao.Text + " ?", "Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if(cbtransacao.Text == "DEVOLUÇÃO")
                        {
                            
                            AdicionarProdutosAoEstoque();
                            
                        }
                        AtualizartransacaoEstoque();



                    }
                    else
                    {
                        txtretornagrid.Clear();
                        panel1.Visible = false;
                        dataGridView1.Enabled = true;                     
                        dataGridView1.Rows.Clear();
                        cbtransacao.Enabled = true;                       
                        cbclientes.Enabled = true;
                        cbproduto.Enabled = true;
                        txtquantidade.Enabled = true;
                        cbvendedor.Enabled = true;
                        btnadicionar.Enabled = true;
                        btnremoveritens.Enabled = true;
                        contarvendas();
                        lblvalortotal.Text = "Valor Total: ";                        
                        cbtransacao.SelectedIndex = -1;
                        cbtransacao.Focus();
                       
                    }



                }
                else
                {
                    MessageBox.Show("Transação não encontrada!");
                    contarvendas();
                    txtretornagrid.Clear();
                    txtretornagrid.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if(cbtransacao.Text == "")
            {
                MessageBox.Show("Selecione uma Transação!");
                cbtransacao.Focus();
                return;
            }

            if (cbclientes.Text == "")
            {
                MessageBox.Show("Selecione um Cliente!");
                cbclientes.Focus(); 
                return;
            }

            if(cbproduto.Text == "")
            {
                MessageBox.Show("Selecione um produto!");
                cbproduto.Focus();
                return;
            }
            if(txtquantidade.Text == "")
            {
                MessageBox.Show("Escolha uma quantidade para o produto");
                txtquantidade.Focus();
                return;
            }
            if (cbvendedor.Text == "")
            {
                MessageBox.Show("Selecione um vendedor");
                cbvendedor.Focus();
                return;
            }        
           
                                 
            
            
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE nome_produto = '" + cbproduto.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                
                MySqlDataReader r = cmd.ExecuteReader();

                              

                
                while (r.Read())
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value != null && dataGridView1.Rows[i].Cells[4].Value.ToString() == cbproduto.Text)
                        {                            
                            double novaQuantidade = double.Parse(txtquantidade.Text.Trim());
                            double quantidadeAtual = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());                           

                            dataGridView1.Rows[i].Cells[5].Value = (quantidadeAtual + novaQuantidade).ToString();
                            double teste1 = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                            double teste2 = double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                            double resultado = teste1 * teste2;
                            dataGridView1.Rows[i].Cells[9].Value = resultado.ToString();

                            AtualizarTotais();

                            return;
                        }
                    }         
                        double preco = double.Parse(txtquantidade.Text.ToString()) * double.Parse(r[9].ToString());
                                            
                        dataGridView1.Rows.Add(dataGridView1.RowCount, r[0], cbtransacao.Text, cbclientes.Text, r[1], txtquantidade.Text.Trim(), r[2], Convert.ToDouble(r[9]), cbvendedor.Text, preco);
                        AtualizarTotais();                                  

                }




                con.FecharConexao();
                btnfecharvenda.Enabled = true;
                cbproduto.Text = "";
                txtquantidade.Clear();
                cbtransacao.Enabled = false;
                cbclientes.Enabled = false;
                cbvendedor.Enabled = false;                
                cbproduto.Focus();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de conexão"+ ex);
            }
           
        }                              
       
        private void cbclientes_Leave(object sender, EventArgs e)
        {
            if (cbclientes.Text == "")
            {
                cbproduto.Focus();
                return;
            }
            Buscarclientes();
        }

        private void cbproduto_Leave(object sender, EventArgs e)
        {
            if(cbproduto.Text == "")
            {
                txtquantidade.Focus();
                return;
            }
            Buscarprodutos();
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                cbvendedor.Focus();
        }

        private void btnremoveritens_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.RemoveAt(int.Parse(indiceselecionado));
                    AtualizarTotais();
                    if (dataGridView1.RowCount < 1)
                    {
                        AtualizarTotais();
                        txtquantidade.Clear();
                        cbproduto.Focus();
                        btnfecharvenda.Enabled = true;
                        
                    }
                }
                else
                {
                        btnfecharvenda.Enabled = false;
                        MessageBox.Show("Não existem itens para remover!");
                        AtualizarTotais();                                       
                    
                }
                
            }catch (Exception)
            {
                MessageBox.Show("Selecione um item para excluir");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                indiceselecionado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbtransacao.Enabled = true;
            cbtransacao.SelectedIndex = -1;
            cbclientes.Enabled = true;
            cbclientes.Text = "";
            cbproduto.Enabled = true;
            cbproduto.Text = "";
            txtquantidade.Enabled = true;
            txtquantidade.Clear(); 
            cbvendedor.Enabled = true;
            cbvendedor.SelectedIndex = -1;
            cbformapagamento.SelectedIndex = -1;           
            dataGridView1.Rows.Clear();
            cbformapagamento.Enabled = false;
            cbformapagamento.SelectedIndex = -1;
            txtvalorpago.Enabled = false;
            txtvalorpago.Clear();
            txtdescontos.Enabled = false;
            txtdescontos.Clear();
            txttroco.Clear();
            txtdinheiro.Enabled = false;
            txtdinheiro.Clear();
            txtpix.Enabled = false;
            txtpix.Clear();
            txtcartao.Enabled = false;
            txtcartao.Clear();
            txttaxa.Enabled = false;
            txttaxa.Clear();
            btnadicionar.Enabled = true;
            btnremoveritens.Enabled = true;
            btnfecharvenda.Enabled = false;
            btnconcluir.Enabled = false;
            lbltotalitens.Text = "Total de itens: ";
            lblvalortotal.Text = "Valor Total: ";           
            cbtransacao.Focus();
            contarvendas();
        }
              
        private void btnconcluir_Click(object sender, EventArgs e)
        {
            funcoes.cod_venda = cod_venda;
            if (dataGridView1.Rows.Count == 0)
            {
                
                MessageBox.Show("Insira produtos na sua venda!");
                cbproduto.Focus();
                return;
            }
            else 
            {
                if (cbformapagamento.Text == "")
                {
                    MessageBox.Show("Selecione uma forma de pagamento!");
                    cbformapagamento.Focus();
                    return;
                }
                if (txtvalorpago.Text == "")
                {
                    MessageBox.Show("Digite o valor pago pagamento!");
                    cbformapagamento.Focus();
                    return;
                }
                if(cbformapagamento.Text == "FRACIONADO")
                {
                    if (valorfracionado < (decimal)precototal)
                    {
                        MessageBox.Show("Valor fracionado não pode ser menor q valor de venda!");
                        return;
                    }

                }               

                try
                {
                    con.AbrirConexao();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        
                        sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, categoria, cod_produto, valor_unitario, dinheiro, pix, cartao, vencimento, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa ) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @categoria, @cod_produto, @valor_unitario, @dinheiro, @pix, @cartao, @vencimento, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                        cmd.Parameters.AddWithValue("@tipo", cbtransacao.Text);
                        cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                        cmd.Parameters.AddWithValue("@produto", dataGridView1.Rows[i].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@quantidade", dataGridView1.Rows[i].Cells[5].Value);
                        cmd.Parameters.AddWithValue("@categoria", dataGridView1.Rows[i].Cells[6].Value);
                        cmd.Parameters.AddWithValue("@cod_produto", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@valor_unitario", dataGridView1.Rows[i].Cells[7].Value);
                        cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@vencimento", "");
                        cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@vendedor", dataGridView1.Rows[i].Cells[8].Value);                       
                        cmd.Parameters.AddWithValue("@descontos", txtdescontos.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                        cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@valor_pago", txtvalorpago.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@troco", txttroco.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@data", DateTime.Today);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                        cmd.ExecuteNonQuery();
                      
                        


                    }

                    
                    sql1 = "INSERT INTO caixa (cod_venda, tipo, cliente, vendedor, desconto, forma_pagamento, valor_total, valor_pago, data, hora, dinheiro, pix, cartao, vencimento, taxa, cod_empresa) VALUES (@cod_venda, @tipo, @cliente, @vendedor, @desconto, @forma_pagamento, @valor_total, @valor_pago, @data, @hora, @dinheiro, @pix, @cartao, @vencimento, @taxa, @cod_empresa)";
                    cmd1 = new MySqlCommand(sql1, con.con);
                    cmd1.Parameters.AddWithValue("@cod_venda", cod_venda);
                    cmd1.Parameters.AddWithValue("@tipo", cbtransacao.Text);
                    cmd1.Parameters.AddWithValue("@cliente", cbclientes.Text);                  
                    cmd1.Parameters.AddWithValue("@vendedor", cbvendedor.Text);
                    cmd1.Parameters.AddWithValue("@desconto", txtdescontos.Text.Replace("%", "").Trim());
                    cmd1.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                    cmd1.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                    cmd1.Parameters.AddWithValue("@valor_pago", txtvalorpago.Text.Replace("R$", "").Trim().Replace(",", "."));                    
                    cmd1.Parameters.AddWithValue("@data", DateTime.Today);
                    cmd1.Parameters.AddWithValue("@hora", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd1.Parameters.AddWithValue("@vencimento", "");
                    cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                    cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                    cmd1.ExecuteNonQuery();
                    con.FecharConexao();


                    MessageBox.Show("Venda salva com sucesso!");

                if (cbtransacao.Text == "VENDA")
                {
                    AtualizarQuantidadeProdutosVendidos();

                }
                if (cbtransacao.Text == "COMPRA")
                {
                    AdicionarProdutosAoEstoque();

                }
                    

                    dataGridView1.Rows.Clear();
                    contarvendas();
                    cbtransacao.Enabled = true;
                    cbtransacao.SelectedIndex = -1;
                    cbtransacao.Focus();
                    cbclientes.Enabled = true;
                    cbclientes.Text = "";
                    cbproduto.Enabled = true;
                    cbproduto.Text = "";
                    txtquantidade.Enabled = true;
                    txtquantidade.Clear();
                    cbvendedor.Enabled = true;
                    cbvendedor.SelectedIndex = -1;
                    cbformapagamento.Enabled = false;
                    cbformapagamento.SelectedIndex = -1;
                    txtvalorpago.Enabled = false;
                    txtvalorpago.Clear();
                    txtdescontos.Enabled = false;
                    txtdescontos.Clear();
                    txtdinheiro.Enabled = false;
                    txtdinheiro.Clear();
                    txtpix.Enabled = false;
                    txtpix.Clear();
                    txtcartao.Enabled = false;
                    txtcartao.Clear();
                    txttaxa.Enabled = false;
                    txttaxa.Clear();
                    
                    txttroco.Clear();
                    btnadicionar.Enabled = true;
                    btnremoveritens.Enabled = true;
                    btnconcluir.Enabled = false;                  
                    lbltotalitens.Text = "Total de itens: ";
                    lblvalortotal.Text = "Valor Total: ";


            }
                catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
                }


            }
            DialogResult Result = MessageBox.Show("Deseja imprimir o recibo da venda?", "Confirmação", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                frmrecibodetalhado frmrecibo = new frmrecibodetalhado();
                frmrecibo.ShowDialog();
            }

        }

        private void cbtransacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbclientes.Focus();
        }

        private void cbclientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbproduto.Focus();
        }

        private void cbproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtquantidade.Focus();
        }

        private void cbvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbformapagamento.Focus();
        }

        private void cbformapagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtvalorpago.Focus();
        }

        private void txtvalorpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtdescontos.Focus();
        }

        private void txtdescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                cbtransacao.Focus();
        }

        private void txtvalorpago_Enter(object sender, EventArgs e)
        {
            string valor = txtvalorpago.Text.Replace("R$ ", "");
            txtvalorpago.Text = valor;
        }

        private void txtvalorpago_Leave(object sender, EventArgs e)
        {
            if(txtvalorpago.Text.Trim() == "")
            {
                txtvalorpago.Text = "0";
            }
            
            double valorpago = double.Parse(txtvalorpago.Text);
            if(valorpago < precototal)
            {
                MessageBox.Show("Valor pago não pode ser menor que o valor total da venda!");
                txtvalorpago.Clear();
                txtvalorpago.Focus();
                return;
            }

            if (decimal.TryParse(txtvalorpago.Text, out decimal valor))
            {
                double troco = valorpago - precototal;
                txtvalorpago.Text = valor.ToString("C", CultureInfo.CurrentCulture);
                txttroco.Text = troco.ToString("C");

            }
        }

        private void txtdescontos_Leave(object sender, EventArgs e)
        {
            if(txtdescontos.Text == "")
            {
                txtdescontos.Text = "0";           
            }  
            if(decimal.Parse( txtdescontos.Text) > 100)
            {
                MessageBox.Show("Desconto não pode exceder 100%!");                
                txtdescontos.Text = "0";
                txtdescontos.Focus();
            }
            
            decimal valorPorcentagem = (decimal)float.Parse(txtdescontos.Text);

            txtdescontos.Text = (valorPorcentagem).ToString() + "%";           

            calcularvalorvendafracionda();
        }

        private void txtdescontos_Enter(object sender, EventArgs e)
        {
            string percentual = txtdescontos.Text.Replace("%", "");
            txtdescontos.Text = percentual;
        }

        private void txttroco_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdescontos.Text, out decimal valor))
            {

                txtdescontos.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void btnfecharvenda_Click(object sender, EventArgs e)
        {
               if(dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("Insira produtos antes de finalizar a venda!");
                cbproduto.Focus();

            }
            else
            {
                cbformapagamento.Enabled = true;
                txtvalorpago.Enabled = true;
                txtdescontos.Enabled = true;
                txttaxa.Enabled = true;
                btnconcluir.Enabled = true;
                cbproduto.Enabled = false;
                txtquantidade.Enabled = false;
                btnadicionar.Enabled = false;
                btnremoveritens.Enabled = false;
                btnfecharvenda.Enabled = false;
                
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

            if (txtdescontos.Text.Trim() == "")
            {
                txtdescontos.Text = "0";
            }

            if (txttaxa.Text.Trim() == "")
            {
                txttaxa.Text = "0";
            }

            if (txtvalorpago.Text.Trim() == "")
            {
                txtvalorpago.Text = "0";
            }           


            decimal dinheiro = decimal.Parse(txtdinheiro.Text.Trim().Replace("R$", ""));
            decimal pix = decimal.Parse(txtpix.Text.Trim().Replace("R$", ""));
            decimal cartao = decimal.Parse(txtcartao.Text.Trim().Replace("R$", ""));

            // Somar os valores de dinheiro, pix e cartão
            decimal somaFracionado = dinheiro + pix + cartao;
            valorfracionado = (decimal)somaFracionado;
           

            if (cbformapagamento.Text == "FRACIONADO")
            {                
                txtvalorpago.Text = somaFracionado.ToString();
            }
            else
            {
                somaFracionado = decimal.Parse(txtvalorpago.Text.Trim().Replace("R$", ""));
            }
            

            // Calcular descontos
            decimal descontos = decimal.Parse(txtdescontos.Text.Replace("%", ""));
            decimal valorDescontos = (decimal)precototal * (descontos / 100);

            // Calcular valor com descontos
            decimal valorComDescontos = (decimal)precototal - valorDescontos;

            // Calcular taxa sobre o valor com descontos
            decimal taxa = decimal.Parse(txttaxa.Text.Replace("%", ""));
            decimal resultadoFracionado = valorComDescontos * (1 + (taxa / 100));

            // Calcular troco com descontos e taxas
            decimal troco = somaFracionado - resultadoFracionado;

            // Atualizar o TextBox do troco
            txttroco.Text = troco.ToString("C", CultureInfo.CurrentCulture);
        }   

        private void AtualizarQuantidadeProdutosVendidos()
        {
            try
            {               

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    con.AbrirConexao();

                        int idProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        int quantidadeVendida = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

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

        private void AdicionarProdutosAoEstoque()
        {
            try
            {
                con.AbrirConexao();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int idProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    int quantidadeComprada = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);                   
                    string updateQuery = $"UPDATE cad_produtos SET quantidade = quantidade + {quantidadeComprada} WHERE cod_produto = {idProduto}";

                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, con.con);
                    updateCommand.ExecuteNonQuery();
                }

                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produtos ao estoque: " + ex.Message);
            }
        }

        private void AtualizartransacaoEstoque()
        {
            try
            {
                
                con.AbrirConexao();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    string updateQuery = "UPDATE vendas SET tipo = @tipo WHERE cod_venda = @cod_venda";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, con.con);
                    string updateQuery2 = "UPDATE caixa SET tipo = @tipo WHERE cod_venda = @cod_venda";
                    MySqlCommand updateCommand2 = new MySqlCommand(updateQuery2, con.con);

                    updateCommand.Parameters.AddWithValue("@tipo", cbtransacao.Text);
                    updateCommand.Parameters.AddWithValue("@cod_venda", cod_venda);
                    updateCommand2.Parameters.AddWithValue("@tipo", cbtransacao.Text);
                    updateCommand2.Parameters.AddWithValue("@cod_venda", cod_venda);

                    updateCommand.ExecuteNonQuery();
                    updateCommand2.ExecuteNonQuery();
                }

                MessageBox.Show("Transação realizada com sucesso!");

                
                cbtransacao.Enabled = true;
                cbtransacao.SelectedIndex = -1;
                cbclientes.Enabled = true;
                cbclientes.Text = "";
                cbproduto.Enabled = true;
                cbproduto.Text = "";
                txtquantidade.Enabled = true;
                txtquantidade.Clear();
                cbvendedor.Enabled = true;
                cbvendedor.SelectedIndex = -1;
                cbformapagamento.SelectedIndex = -1;
                dataGridView1.Rows.Clear();
                cbformapagamento.Enabled = false;
                cbformapagamento.SelectedIndex = -1;
                txtvalorpago.Enabled = false;
                txtvalorpago.Clear();
                txtdescontos.Enabled = false;
                txtdescontos.Clear();
                txttroco.Clear();
                btnadicionar.Enabled = true;
                btnremoveritens.Enabled = true;
                btnfecharvenda.Enabled = false;
                btnconcluir.Enabled = false;
                lbltotalitens.Text = "Total de itens: ";
                lblvalortotal.Text = "Valor Total: ";
                cbtransacao.Focus();
                contarvendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao devolver produtos ao estoque: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }

        private void cbtransacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbtransacao.SelectedIndex == 3 || cbtransacao.SelectedIndex == 4)
            {
                panel1.Visible = true;
                txtretornagrid.Clear();
                txtretornagrid.Focus();
            }
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            txtretornagrid.Clear();
            cbtransacao.SelectedIndex = -1;
            cbtransacao.Focus();
            panel1.Visible = false;
                       
        }

        private void txtretornagrid_Leave(object sender, EventArgs e)
        {
            if(txtretornagrid.Text.Trim() == "")
            {
                btncancelarretorno.Focus();
                return;
            }
           
                trocadevolucao();
           
             
            
           
        }

        private void txtretornagrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                panel1.Focus();
            txtretornagrid.Focus();
        }

        private void btncancelarretorno_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            cbtransacao.SelectedIndex = -1;
            cbtransacao.Focus();
        }

        private void cbformapagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(cbformapagamento.SelectedIndex == -1)
            {
                txtvalorpago.Enabled=false;
            }
            if(cbformapagamento.SelectedIndex == 1 || cbformapagamento.SelectedIndex == 2 || cbformapagamento.SelectedIndex == 3)
            {
                txtvalorpago.Enabled = false;
                txtvalorpago.Text = "R$ 0,00";
                txtdescontos.Text = "0%";
                txttaxa.Text = "0%";
                txtdinheiro.Enabled = true;
                txtdinheiro.Text = "0,00";
                txtdinheiro.Focus();
                txtpix.Enabled = true;
                txtpix.Text = "0,00";
                txtcartao.Enabled = true;
                txtcartao.Text = "0,00";
                txttroco.Clear();
            }
            if(cbformapagamento.SelectedIndex == 0 )
            {
                txtvalorpago.Enabled = false;               
                txtvalorpago.Text = precototal.ToString("C");
                txtdinheiro.Enabled = false;
                txtpix.Enabled = false;
                txtcartao.Enabled = false;
                txtdinheiro.Text = "0,00";
                txtpix.Text = precototal.ToString("C");
                txtcartao.Text = "0,00";
                txttaxa.Text = "0%";
                txtdescontos.Text = "0%";
                txttroco.Clear();
                txtdescontos.Focus();
            }

            if (cbformapagamento.SelectedIndex == 4 || cbformapagamento.SelectedIndex == 5)
            {
                txtvalorpago.Enabled = false;                
                txtvalorpago.Text = precototal.ToString("C");
                txtdinheiro.Enabled = false;
                txtpix.Enabled = false;
                txtcartao.Enabled = false;
                txtdinheiro.Text = "0,00";
                txtpix.Text = "0,00";
                txtcartao.Text = precototal.ToString("C");
                txttaxa.Text = "0%";
                txtdescontos.Text = "0%";
                txttroco.Clear();
                txtdescontos.Focus();
            }
        }

        private void txtdinheiro_Leave(object sender, EventArgs e)
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
    }
}
