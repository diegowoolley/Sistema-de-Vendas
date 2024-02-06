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
    public partial class frmPDV : Form
    {
        public frmPDV()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;       
        MySqlCommand cmd;
        double precototal;
        int cod_venda;




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

                    }
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão", ex.Message);
            }
        }

        private void AtualizarQuantidadeProdutosVendidos()
        {
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    con.AbrirConexao();

                    int idProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
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
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
           DialogResult Result = MessageBox.Show("Deseja realmente cancelar a venda de número "+ cod_venda+" ?", "Cancelamento", MessageBoxButtons.YesNo);
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
                MessageBox.Show("Venda cancelada com sucesso!");
            }
            txtcod_barras.Focus();

        }
    }
    
}
