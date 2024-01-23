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
                sql = "SELECT MAX(id) FROM vendas";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    if (val == "")
                    {
                        int i = 1;
                        lblcodigovenda.Text = "Número da venda: " + i;
                    }
                    else
                    {
                        int i;
                        i = int.Parse(dr[0].ToString());
                        i = i + 1;
                        lblcodigovenda.Text = "Número da venda: " + i.ToString();

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
            listarformapagamento();
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
                cbproduto.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de conexão"+ ex);
            }
           
        }

        private void btnbuscarservico_Click(object sender, EventArgs e)
        {
            BuscarServicos();
        }

        private void lbladdservico_DoubleClick(object sender, EventArgs e)
        {
            pnservico.Visible = true;
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
                    }
                }
                else
                {
                    precototal = 0;
                    MessageBox.Show("Não existem itens para remover!");
                    lbltotalitens.Text = "Total de itens: " +(dataGridView1.RowCount);
                    lblvalortotal.Text = "Valor total: " + precototal;
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
    }
}
