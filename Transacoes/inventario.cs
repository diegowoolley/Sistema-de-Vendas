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

namespace Sistema_de_Vendas
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;       
        
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos ORDER BY nome_produto ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.FecharConexao();
        }

        private void formatargrid()
        {
            dataGridView1.Columns[0].HeaderText = "Cód. Produto";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Categoria";
            dataGridView1.Columns[3].HeaderText = "Unidade de Medida";
            dataGridView1.Columns[4].HeaderText = "Quantidade";
            dataGridView1.Columns[5].HeaderText = "Fornecedor";
            dataGridView1.Columns[6].HeaderText = "Peso Médio";
            dataGridView1.Columns[7].HeaderText = "Peso Bruto";
            dataGridView1.Columns[8].HeaderText = "Fabricante";
            dataGridView1.Columns[9].HeaderText = "Valor Compra";
            dataGridView1.Columns[10].HeaderText = "Valor Venda";
            dataGridView1.Columns[11].HeaderText = "Margem de Lucro";
            dataGridView1.Columns[12].HeaderText = "Situação Tributária";
            dataGridView1.Columns[13].HeaderText = "Aliquota IPI";
            dataGridView1.Columns[14].HeaderText = "Código IPI";
            dataGridView1.Columns[15].HeaderText = "Foto";
            dataGridView1.Columns[16].HeaderText = "Estoque Mínimo";
            dataGridView1.Columns[17].HeaderText = "Estoque Máximo";
            dataGridView1.Columns[18].HeaderText = "Validade";
            dataGridView1.Columns[19].HeaderText = "Etiqueta";
            dataGridView1.Columns[20].HeaderText = "Adicionado por";
            dataGridView1.Columns[21].HeaderText = "Data e hora da inclusão";




        }


        private void Buscar()
        {
            string pesquisa = txtpesquisa.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos WHERE nome_produto LIKE @nome or cod_produto LIKE @cod_produto or etiqueta LIKE @etiqueta";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.FecharConexao();                      

        }

        private void inventario_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            
        }
    }
}
