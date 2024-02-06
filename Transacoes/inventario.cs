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

        private int ContarProdutosAVencer()
        {
            int contador = 0;

            try
            {
                con.AbrirConexao();

                // Considere usar a função CURDATE() do MySQL para obter a data atual
                sql = "SELECT COUNT(*) FROM cad_produtos WHERE STR_TO_DATE(validade, '%d/%m/%Y') <= (CURDATE() + INTERVAL 30 DAY)";
                cmd = new MySqlCommand(sql, con.con);

                // ExecuteScalar retorna o resultado da consulta como um objeto
                object result = cmd.ExecuteScalar();

                // Verifique se o resultado não é nulo e é um número
                if (result != null && result != DBNull.Value)
                {
                    contador = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao contar produtos próximos a vencer" + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
            label2.Text = "Número de produtos próximos a vencer: "+contador.ToString();

            return contador;
             
        }

        private int ContarProdutosBaixoEstoque()
        {
            int contador = 0;

            try
            {
                con.AbrirConexao();

                sql = "SELECT COUNT(*) FROM cad_produtos WHERE quantidade <= estoque_minimo";
                cmd = new MySqlCommand(sql, con.con);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    contador = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao contar produtos com estoque baixo: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
            label3.Text = "Número de produtos com estoque baixo: " + contador.ToString();
            return contador;
        }

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

        private void listarminimo()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE quantidade <= estoque_minimo ORDER BY nome_produto ASC";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos com estoque mínimo: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }
        private void listarvalidade()
        {
            try
            {
                con.AbrirConexao();

                // Obter a data atual
                DateTime dataAtual = DateTime.Now;

                // Consulta SQL para selecionar produtos com validade próxima de vencer
                sql = "SELECT * FROM cad_produtos WHERE STR_TO_DATE(validade, '%d/%m/%Y') BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 MONTH) ORDER BY nome_produto ASC";
                cmd = new MySqlCommand(sql, con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos com validade para vencer: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
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
            ContarProdutosAVencer();
            ContarProdutosBaixoEstoque();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            
        }

        private void btnestoqueminimo_Click(object sender, EventArgs e)
        {
            listarminimo();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnlistarvalidade_Click(object sender, EventArgs e)
        {
            listarvalidade();
        }
    }
}
