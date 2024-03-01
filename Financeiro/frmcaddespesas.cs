using Microsoft.SqlServer.Server;
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
        string sql1;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        int cod_venda;

        private void frmcaddespesas_Load(object sender, EventArgs e)
        {
            contarvendas();
        }

        #region MÉTODOS
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
            cod_venda = 0;
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

        #endregion

        #region BOTÕES
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

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            if (cbtipo.Text == "")
            {
                MessageBox.Show("Informe um tipo antes de salvar o lançamento!");
                cbtipo.Focus();
                return;
            }
            if (txtdescricao.Text.Trim() == "")
            {
                MessageBox.Show("Selecione uma descrição antes de salvar o lançamento!");
                txtdescricao.Focus();
                return;
            }
            if (cbfavorecido.Text.Trim() == "")
            {
                MessageBox.Show("Informe um favorecido antes de salvar o lanlamento!");
                cbfavorecido.Focus();
                return;
            }
            if (txtvalor.Text == "0" || txtvalor.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor antes de salvar o lançamento!");
                txtvalor.Focus();
                return;
            }
            if (cbformapagamento.Text == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento antes de salvar o lançamento!");
                cbformapagamento.Focus();
                return;
            }
            if (dtvencimento.Value < DateTime.Now.Date)
            {
                MessageBox.Show("O vencimento não pode ser menor que a data atual!");
                dtvencimento.Focus();
                return;
            }

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
                cmd.Parameters.AddWithValue("@pix", "");
                cmd.Parameters.AddWithValue("@cartao", "");
                cmd.Parameters.AddWithValue("@vencimento", DateTime.Parse(dtvencimento.Value.Date.ToString("yyyy/MM/dd")));
                cmd.Parameters.AddWithValue("@taxa", "");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                cmd.Parameters.AddWithValue("@status", "À PAGAR");
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@favorecido", cbfavorecido.Text);
                cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);





                sql1 = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, valor_unitario, dinheiro, pix, cartao, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa, vencimento) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @valor_unitario, @dinheiro, @pix, @cartao, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa, @vencimento)";
                cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_venda", cod_venda);
                cmd1.Parameters.AddWithValue("@tipo", cbtipo.Text);
                cmd1.Parameters.AddWithValue("@cliente", "");
                cmd1.Parameters.AddWithValue("@produto", "");
                cmd1.Parameters.AddWithValue("@quantidade", "");
                cmd1.Parameters.AddWithValue("@valor_unitario", "");
                cmd1.Parameters.AddWithValue("@dinheiro", "");
                cmd1.Parameters.AddWithValue("@pix", "");
                cmd1.Parameters.AddWithValue("@cartao", "");
                cmd1.Parameters.AddWithValue("@vencimento", dtvencimento.Value.Date);
                cmd1.Parameters.AddWithValue("@taxa", "");
                cmd1.Parameters.AddWithValue("@vendedor", "");
                cmd1.Parameters.AddWithValue("@descontos", "");
                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformapagamento.Text);
                cmd1.Parameters.AddWithValue("@valor_total", txtvalor.Text);
                cmd1.Parameters.AddWithValue("@valor_pago", "");
                cmd1.Parameters.AddWithValue("@troco", "");
                cmd1.Parameters.AddWithValue("@data", DateTime.Today);
                cmd1.Parameters.AddWithValue("@hora", DateTime.Now);
                cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);



                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Despesa lançada com sucesso!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        #endregion

        #region KEYPRESS \ LEAVE
        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void cbfavorecido_Leave(object sender, EventArgs e)
        {
            string favorecido = cbfavorecido.Text;
            cbfavorecido.Text = favorecido.ToUpper();
            buscarfavorecido();
        }

        #endregion

        

        
    }
}
