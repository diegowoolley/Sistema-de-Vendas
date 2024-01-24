using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string id;
        int subtotal;
        int precototal;
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
            }catch(Exception ex)
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
                sql = "SELECT * FROM cad_produtos WHERE nome_produto LIKE @nome or cod_produto LIKE @cod_produto";
                MySqlDataReader reader;
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
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
            if(cbformapagamento.Text == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                cbformapagamento.Focus();
                return;
            }
           
                                 
            
            
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE nome_produto = '" + cbproduto.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                
                MySqlDataReader r = cmd.ExecuteReader();
               
                while(r.Read())
                {
                   
                    int preco = int.Parse(txtquantidade.Text.ToString()) * int.Parse(r[10].ToString());
                    subtotal = preco;                    
                    dataGridView1.Rows.Add(dataGridView1.RowCount, cbtransacao.Text, cbclientes.Text, r[1], txtquantidade.Text.Trim(), r[2], r[10], cbvendedor.Text, cbservico.Text, txtquantidadeservico.Text, preco);
                    
                }
                precototal = subtotal + precototal;
                lbltotalitens.Text = "Total de itens: " +(dataGridView1.RowCount);
                lblvalortotal.Text = "Valor Total: " + precototal;

                con.FecharConexao();
                cbproduto.Text = "";
                txtquantidade.Clear();
                cbtransacao.Enabled = false;
                cbclientes.Enabled = false;
                cbvendedor.Enabled = false;
                cbformapagamento.Enabled = false;
                cbproduto.Focus();
                btnconcluir.Enabled = true;
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
                    precototal = precototal - subtotal;
                    lbltotalitens.Text = "Total de itens: " + (dataGridView1.RowCount);
                    lblvalortotal.Text = "Valor total: " + precototal;
                    if (dataGridView1.RowCount < 1)
                    {
                        precototal = 0;
                        lblvalortotal.Text = "Valor total: " + precototal;
                        btnconcluir.Enabled = true;
                    }
                }
                else
                {
                    precototal = 0;
                    MessageBox.Show("Não existem itens para remover!");
                    lbltotalitens.Text = "Total de itens: " +(dataGridView1.RowCount);
                    lblvalortotal.Text = "Valor total: " + precototal;
                    btnconcluir.Enabled = false;
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
                subtotal = int.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbtransacao.SelectedIndex = 0;
            cbclientes.Text = "";
            cbproduto.Text = "";
            txtquantidade.Clear();            
            //cbvendedor.SelectedIndex = 0;
            //cbformapagamento.SelectedIndex = 0;
            txtvalorpago.Clear();
            txtdescontos.Clear();
            txttroco.Clear();
        }

        private void cbservico_Leave(object sender, EventArgs e)
        {
            BuscarServicos();
            
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                btnconcluir.Enabled = false;
                MessageBox.Show("Insira produtos na sua venda!");
                cbproduto.Focus();
                return;
            }
            else 
            {

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
                        cmd.Parameters.AddWithValue("@descontos", txtdescontos.Text);
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                        cmd.Parameters.AddWithValue("@valor_total", precototal);
                        cmd.Parameters.AddWithValue("@valor_pago", txtvalorpago.Text);
                        cmd.Parameters.AddWithValue("@troco", txttroco.Text);
                        cmd.Parameters.AddWithValue("@data", DateTime.Today);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        con.FecharConexao();

                    }
                    MessageBox.Show("Venda salva com sucesso!");

                    dataGridView1.Rows.Clear();
                    contarvendas();
                    cbtransacao.Enabled = true;
                    cbtransacao.SelectedIndex = -1;
                    cbtransacao.Focus();
                    cbclientes.Enabled = true;
                    cbclientes.Text = "";
                    cbproduto.Text = "";
                    txtquantidade.Clear();
                    cbvendedor.Enabled = true;
                    cbvendedor.SelectedIndex = -1;
                    cbformapagamento.Enabled = true;
                    cbformapagamento.SelectedIndex = -1;
                    txtvalorpago.Clear();
                    txtdescontos.Clear();
                    txttroco.Clear();
                    btnconcluir.Enabled = false;
                    lbltotalitens.Text = "Total de itens: ";
                    lblvalortotal.Text = "Valor Total: ";
                    precototal = 0;
                    subtotal = 0;
                   
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
               
    }
}
