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
        private void listarservicos()
        {
            con.AbrirConexao();
            sql = "SELECT descricao FROM cad_servicos ORDER BY descricao asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbservico.DataSource = dt;
            cbservico.DisplayMember = "descricao";
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
            listarservicos();
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
    }
}
