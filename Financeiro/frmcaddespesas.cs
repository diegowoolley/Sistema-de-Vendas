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

namespace Sistema_de_Vendas.Financeiro
{
    public partial class frmcaddespesas : Form
    {
        public frmcaddespesas()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        int cod_venda;

        private void buscarfavorecido()
        {
            if (cbfavorecido.Text.Trim() == "")
            {
                txtvalor.Focus();
                return;
            }
            try
            {
                string pesquisa = cbfavorecido.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND favorecido LIKE @favorecido";
                cmd = new MySqlCommand(sql, con.con);               
                cmd.Parameters.AddWithValue("@favorecido", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                             
                con.FecharConexao();   
                if(dt.Rows.Count > 0)
                {
                    cbfavorecido.DataSource = dt;
                    cbfavorecido.DisplayMember = "favorecido";
                }
                else
                {
                    txtvalor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        lblcodigovenda.Text = "Número do Lançamento: " + cod_venda;
                    }
                    else
                    {

                        cod_venda = int.Parse(dr[0].ToString());
                        cod_venda = cod_venda + 1;
                        lblcodigovenda.Text = "Número do Lançamento: " + cod_venda.ToString();
                        funcoes.cod_venda = cod_venda;

                    }
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão", ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbtipo.SelectedIndex = -1;
            txtdocumento.Clear();
            txtdescricao.Clear();
            cbfavorecido.Text = "";
            txtvalor.Text = "0";
            cbformapagamento.SelectedIndex = -1;
            dtvencimento.Value = DateTime.Now;
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }
       
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO caixa (cod_venda, tipo, cliente, vendedor, desconto, forma_pagamento, valor_total, valor_pago, data, hora, dinheiro, pix, cartao, vencimento, taxa, cod_empresa, status, descricao, favorecido, documento) VALUES (@cod_venda, @tipo, @cliente, @vendedor, @desconto, @forma_pagamento, @valor_total, @valor_pago, @data, @hora, @dinheiro, @pix, @cartao, @vencimento, @taxa, @cod_empresa, @status, @descricao, @favorecido, @documento)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd.Parameters.AddWithValue("@tipo", cbtipo.Text);
                cmd.Parameters.AddWithValue("@cliente", "");
                cmd.Parameters.AddWithValue("@vendedor", "");
                cmd.Parameters.AddWithValue("@desconto", "");
                cmd.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                cmd.Parameters.AddWithValue("@valor_total", txtvalor.Text);
                cmd.Parameters.AddWithValue("@valor_pago", "");
                cmd.Parameters.AddWithValue("@data", DateTime.Today);
                cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                cmd.Parameters.AddWithValue("@dinheiro", "");
                cmd.Parameters.AddWithValue("@pix","");
                cmd.Parameters.AddWithValue("@cartao", "");
                cmd.Parameters.AddWithValue("@vencimento", DateTime.Parse(dtvencimento.Value.Date.ToString("yyyy/MM/dd")));
                cmd.Parameters.AddWithValue("@taxa","");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                cmd.Parameters.AddWithValue("@status", "À PAGAR");
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@favorecido", cbfavorecido.Text);
                cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);
                


                cmd.ExecuteNonQuery();
                con.FecharConexao();


                MessageBox.Show("Despesa lançada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            contarvendas();
            cbtipo.SelectedIndex = -1;
            txtdocumento.Clear();
            txtdescricao.Clear();
            cbfavorecido.Text = "";
            txtvalor.Text = "0";
            cbformapagamento.SelectedIndex = -1;
            dtvencimento.Value = DateTime.Now;
            cbtipo.Focus();
        }
       
        private void frmcaddespesas_Load(object sender, EventArgs e)
        {
            contarvendas();            
        }

        private void cbfavorecido_Leave(object sender, EventArgs e)
        {
            string favorecido = cbfavorecido.Text;
            cbfavorecido.Text = favorecido.ToUpper();
            buscarfavorecido();
        }
    }
}
