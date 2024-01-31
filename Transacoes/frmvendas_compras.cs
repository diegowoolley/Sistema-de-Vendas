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
        MySqlCommand cmd;               
        double precototal;        
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
                if (dataGridView1.Rows[i].Cells[11].Value != null)
                {
                    precototal += Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value);
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
                sql = "SELECT forma_pagamento FROM cad_pagamentos ORDER BY forma_pagamento asc";
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
                sql = "SELECT * FROM cad_clientes WHERE nome_clientes LIKE @nome or cod_clientes LIKE @cod_clientes";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();                
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbclientes.DataSource = dt;
                cbclientes.DisplayMember = "nome_clientes";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
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

        private void BuscarServicos()
        {
            try
            {
                string pesquisa = cbservico.Text;
                con.AbrirConexao();
                sql = "SELECT * FROM cad_servicos WHERE descricao LIKE @nome or cod_servico LIKE @cod_clientes";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");                
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbservico.DataSource = dt;
                cbservico.DisplayMember = "descricao";
                reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    
                    con.FecharConexao();
                    

                }
                else
                {
                    MessageBox.Show("Serviço não cadastrado!");
                    cbservico.Text = "";
                    cbservico.Focus();                    
                }
                
            }
            catch(Exception ex)
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
                sql = "SELECT * FROM cad_produtos WHERE nome_produto LIKE @nome or cod_produto LIKE @cod_produto or etiqueta LIKE @etiqueta";
                MySqlDataReader reader;
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
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
                        if (dataGridView1.Rows[i].Cells[3].Value != null && dataGridView1.Rows[i].Cells[3].Value.ToString() == cbproduto.Text)
                        {                            
                            double novaQuantidade = double.Parse(txtquantidade.Text.Trim());
                            double quantidadeAtual = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());                           

                            dataGridView1.Rows[i].Cells[4].Value = (quantidadeAtual + novaQuantidade).ToString();
                            double teste1 = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            double teste2 = double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            double resultado = teste1 * teste2;
                            dataGridView1.Rows[i].Cells[10].Value = resultado.ToString();

                            AtualizarTotais();

                            return;
                        }
                    }         
                        double preco = double.Parse(txtquantidade.Text.ToString()) * double.Parse(r[10].ToString());
                                            
                        dataGridView1.Rows.Add(dataGridView1.RowCount, r[0], cbtransacao.Text, cbclientes.Text, r[1], txtquantidade.Text.Trim(), r[2], Convert.ToDouble(r[10]), cbvendedor.Text, cbservico.Text, txtquantidadeservico.Text, preco);
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
              

        private void lbladdservico_DoubleClick(object sender, EventArgs e)
        {
            pnservico.Visible = true;
            cbservico.Text = "";
            txtquantidadeservico.Clear();
            cbservico.Focus();
        }

        private void pnservico_Leave(object sender, EventArgs e)
        {
            pnservico.Visible = false;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {           
            pnservico.Visible = false;
           
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
            btnadicionar.Enabled = true;
            btnremoveritens.Enabled = true;
            btnfecharvenda.Enabled = false;
            btnconcluir.Enabled = false;
            lbltotalitens.Text = "Total de itens: ";
            lblvalortotal.Text = "Valor Total: ";
            lbladdservico.Enabled = true;
            cbtransacao.Focus();
        }

        private void cbservico_Leave(object sender, EventArgs e)
        {
            BuscarServicos();
            
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
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
                

                try
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        con.AbrirConexao();
                        sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, vendedor, servico, quantidade_servico, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @vendedor, @servico, @quantidade_servico, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                        cmd.Parameters.AddWithValue("@tipo", cbtransacao.Text);
                        cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                        cmd.Parameters.AddWithValue("produto", dataGridView1.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@quantidade", dataGridView1.Rows[i].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@vendedor", dataGridView1.Rows[i].Cells[7].Value);
                        cmd.Parameters.AddWithValue("@servico", dataGridView1.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@quantidade_servico", dataGridView1.Rows[i].Cells[9].Value);
                        cmd.Parameters.AddWithValue("@descontos", txtdescontos.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                        cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@valor_pago", txtvalorpago.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@troco", txttroco.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@data", DateTime.Today);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                        
                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        


                    }
                    MessageBox.Show("Venda salva com sucesso!");

                    if(cbtransacao.Text == "VENDA")
                    {
                        AtualizarQuantidadeProdutosVendidos();
                        
                    }
                    if(cbtransacao.Text == "COMPRA")
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
                    txttroco.Clear();
                    btnadicionar.Enabled = true;
                    btnremoveritens.Enabled = true;
                    btnconcluir.Enabled = false;
                    lbladdservico.Enabled = true;
                    lbltotalitens.Text = "Total de itens: ";
                    lblvalortotal.Text = "Valor Total: ";
                  
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro de conexão!");
                }
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
            if (e.KeyChar == 13)
                txtdescontos.Focus();
        }

        private void txtdescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            double valorpago = double.Parse(txtvalorpago.Text);
            if(valorpago < precototal )
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
            CalcularValorVenda();
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
                btnconcluir.Enabled = true;
                cbproduto.Enabled = false;
                txtquantidade.Enabled = false;
                btnadicionar.Enabled = false;
                btnremoveritens.Enabled = false;
                btnfecharvenda.Enabled = false;
                lbladdservico.Enabled = false;
            }
                                   
                      
        }

        private void CalcularValorVenda()
        {
            if (decimal.TryParse(txtvalorpago.Text.Trim().Replace("R$ ", ""), out decimal valorpago) &&
                decimal.TryParse(txtdescontos.Text.Replace("%", ""), out decimal descontos))
            {
                decimal valordescontos =  valorpago * (1 - (descontos / 100)) ;
                decimal descontotal = valordescontos - (decimal)precototal;
                
                txttroco.Text = descontotal.ToString("C");
            }
            else
            {

                MessageBox.Show("Por favor, insira valores válidos para a compra e a margem de lucro.");
            }

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


    }
}
