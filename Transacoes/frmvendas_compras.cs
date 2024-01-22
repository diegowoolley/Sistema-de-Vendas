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
        int precototal;

        private void listarvendedor()
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
        }      

        private void listarformapagamento()
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
        }

        private void Buscarclientes()
        {
            string pesquisa = cbclientes.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_clientes WHERE nome_clientes LIKE @nome or cod_clientes LIKE @cod_clientes";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbclientes.DataSource = dt;
            cbclientes.DisplayMember = "nome_clientes";
            con.FecharConexao();
           

        }

        private void BuscarServicos()
        {
            string pesquisa = cbservico.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_servicos WHERE descricao LIKE @nome or cod_servico LIKE @cod_clientes";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbclientes.DataSource = dt;
            cbclientes.DisplayMember = "descricao";
            con.FecharConexao();


        }

        private void Buscarprodutos()
        {
            string pesquisa = cbproduto.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos WHERE nome_produto LIKE @nome or cod_produto LIKE @cod_produto";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbproduto.DataSource = dt;
            cbproduto.DisplayMember = "nome_produto";
            con.FecharConexao();


        }


        private void frmvendas_compras_Load(object sender, EventArgs e)
        {
            listarvendedor();
            
            listarformapagamento();

        }

        private void btnbuscar_cliente_Click(object sender, EventArgs e)
        {
            Buscarclientes();
        }

        private void btnbuscar_produto_Click(object sender, EventArgs e)
        {
            Buscarprodutos();
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
                    precototal = preco;
                    dataGridView1.Rows.Add(dataGridView1.RowCount, cbtransacao.Text, cbclientes.Text, r[1], txtquantidade.Text.Trim(), r[10], cbvendedor.Text, cbservico.Text, txtquantidadeservico.Text, txtdescontos.Text, cbformapagamento.Text, txtvalorpago.Text, txttroco.Text, preco);
                }
                lbltotalitens.Text = "Total de itens: " +(dataGridView1.RowCount );
                lblvalortotal.Text = "Valor Total:" + precototal;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro de conexão"+ ex);
            }
           
        }

        private void btnbuscarservico_Click(object sender, EventArgs e)
        {
            BuscarServicos();
        }
    }
}
