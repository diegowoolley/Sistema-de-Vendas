﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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

        private void inventario_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
            ContarProdutosAVencer();
            ContarProdutosBaixoEstoque();
            if(funcoes.permissao == "Usuário")
            {
                btnadcicionarproduto.Enabled = false;
            }
        }

        #region MÉTODOS
        private int ContarProdutosAVencer()
        {
            int contador = 0;

            try
            {
                con.AbrirConexao();

                // Considere usar a função CURDATE() do MySQL para obter a data atual
                sql = "SELECT COUNT(*) FROM cad_produtos WHERE cod_empresa = @cod_empresa AND STR_TO_DATE(validade, '%d/%m/%Y') <= (CURDATE() + INTERVAL 30 DAY)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

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
                MessageBox.Show("Erro ao contar produtos próximos de vencer" + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
            label2.Text = "Número de produtos próximos de vencer: " + contador.ToString();

            return contador;

        }

        private int ContarProdutosBaixoEstoque()
        {
            int contador = 0;

            try
            {
                con.AbrirConexao();

                sql = "SELECT COUNT(*) FROM cad_produtos WHERE cod_empresa = @cod_empresa AND quantidade <= estoque_minimo";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

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
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa ORDER BY cod_produto ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
                colorirvalidade();
                colorirestoqueminimo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listarminimo()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND quantidade <= estoque_minimo ORDER BY nome_produto ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                colorirestoqueminimo();
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

        private void colorirestoqueminimo()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                decimal.TryParse(row.Cells["quantidade"].Value.ToString(), out decimal estoqueAtual);

                decimal.TryParse(row.Cells["estoque_minimo"].Value.ToString(), out decimal estoqueMinimo);


                if (estoqueAtual < estoqueMinimo)
                {

                    row.Cells["quantidade"].Style.BackColor = Color.Yellow;
                }


                if (estoqueAtual < 0)
                {

                    row.Cells["quantidade"].Style.BackColor = Color.Red;
                }
            }

        }

        private void listarvalidade()
        {
            try
            {
                con.AbrirConexao();


                DateTime dataAtual = DateTime.Now;


                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND STR_TO_DATE(validade, '%d/%m/%Y') BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 MONTH) ORDER BY nome_produto ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                colorirvalidade();

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

        private void colorirvalidade()
        {

            DateTime dataAtual = DateTime.Now;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (DateTime.TryParse(row.Cells["validade"].Value.ToString(), out DateTime dataValidade))
                {

                    int diasRestantes = (dataValidade - dataAtual).Days;


                    if (diasRestantes <= 30 && diasRestantes >= 0)
                    {

                        row.Cells["validade"].Style.BackColor = Color.Yellow;
                    }
                    else if (diasRestantes < 0)
                    {

                        row.Cells["validade"].Style.BackColor = Color.Red;
                    }
                }

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
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].HeaderText = "Estoque Mínimo";
            dataGridView1.Columns[17].HeaderText = "Estoque Máximo";
            dataGridView1.Columns[18].HeaderText = "Validade";
            dataGridView1.Columns[19].HeaderText = "Etiqueta";
            dataGridView1.Columns[20].HeaderText = "Adicionado por";
            dataGridView1.Columns[21].HeaderText = "Data e hora da inclusão";
            dataGridView1.Columns[22].HeaderText = "Código Empresa";
            dataGridView1.Columns[22].Visible = false;




        }

        private void Buscar()
        {
            try
            {
                string pesquisa = txtpesquisa.Text;
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND nome_produto LIKE @nome or cod_empresa = @cod_empresa AND cod_produto LIKE @cod_produto or cod_empresa = @cod_empresa AND etiqueta LIKE @etiqueta";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
                colorirestoqueminimo();
                colorirvalidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region BOTÕES

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

        private void btnadcicionarproduto_Click(object sender, EventArgs e)
        {
            frmcadProdutos frmprodutos = new frmcadProdutos();
            frmprodutos.ShowDialog();
        }


        #endregion

        #region TEXTCHANGED

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();

        }

        #endregion
    }
}
