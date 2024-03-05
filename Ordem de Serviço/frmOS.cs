using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Resultset;
using Sistema_de_Vendas.Relatorios.Recibos;
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

namespace Sistema_de_Vendas.Ordem_de_Serviço
{
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        string sql1;
        MySqlCommand cmd;
        MySqlCommand cmd1;     
        int conta_venda;
        decimal precototal;
        decimal valorfracionado;
     
       

        private void frmOS_Load(object sender, EventArgs e)
        {
           
            contarvendas();
            listar();
            listarformapagamento();
        }

        #region MÉTODOS
        private void Buscarclientes()
        {


            try
            {
                string pesquisa = cbclientes.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_clientes WHERE cod_empresa = @cod_empresa AND nome_clientes LIKE @nome or cod_clientes LIKE @cod_clientes";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_clientes", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbclientes.DataSource = dt;
                cbclientes.DisplayMember = "nome_clientes";
                reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    if (reader[13].ToString() == "BLOQUEADO")
                    {
                        cbclientes.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        cbclientes.BackColor = Color.White;
                    }
                    con.FecharConexao();

                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!");
                    cbclientes.BackColor = Color.White;
                    cbclientes.Text = "";
                    cbclientes.Focus();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void Buscarfuncionario()
        {


            try
            {
                string pesquisa = cbtecnico.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_funcionarios WHERE cod_empresa = @cod_empresa AND cargo_funcionario = 'TÉCNICO' AND nome_funcionario LIKE @nome or cod_funcionario LIKE @cod_funcionario";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_funcionario", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbtecnico.DataSource = dt;
                cbtecnico.DisplayMember = "nome_funcionario";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    con.FecharConexao();

                }
                else
                {
                    MessageBox.Show("Técnico não cadastrado!");
                    cbtecnico.Focus();
                  
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void Buscarservico()
        {


            try
            {
                string pesquisa = cbservico.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_servicos WHERE cod_empresa = @cod_empresa AND descricao LIKE @nome or cod_servico LIKE @cod_servico";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_servico", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
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
                    txtquantidades.Clear();
                    cbservico.Focus();
                  
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Buscarproduto()
        {

            try
            {
                string pesquisa = cbproduto.Text;
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND nome_produto LIKE @nome or cod_produto LIKE @cod_produto or etiqueta LIKE @etiqueta";
                MySqlDataReader reader;
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
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
                    txtquantidadep.Clear();
                    cbproduto.Focus();
                    
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
                        conta_venda = 1;
                        lblcodigovenda.Text = "Código pagamento: " + conta_venda;
                        lblnumeroos.Text = "Número da OS: " + conta_venda;
                        funcoes.cod_venda = conta_venda;
                    }
                    else
                    {

                        conta_venda = int.Parse(dr[0].ToString());
                        conta_venda = conta_venda + 1;
                        lblcodigovenda.Text = "Código pagamento: " + conta_venda;
                        lblnumeroos.Text = "Número da OS: " + conta_venda;
                        funcoes.cod_venda = conta_venda;


                    }
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão", ex.Message);
            }
        }

        private void formatargrid()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Código venda";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Cliente";
            dataGridView1.Columns[3].HeaderText = "Técnico";
            dataGridView1.Columns[4].HeaderText = "Status";
            dataGridView1.Columns[5].HeaderText = "Data inicial";
            dataGridView1.Columns[6].HeaderText = "Data final";
            dataGridView1.Columns[7].HeaderText = "Garantia";
            dataGridView1.Columns[8].HeaderText = "Termo de garantia";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "Descrição";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Defeito";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Observações";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "Láudo técnico";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].HeaderText = "Código da empresa";
            dataGridView1.Columns[13].Visible = false;


        }

        private void listar()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_os WHERE cod_empresa = @cod_empresa AND status <> 'FINALIZADO' ORDER BY id asc";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }
            formatargrid();
        }

        private void listarformapagamento()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT forma_pagamento FROM cad_pagamentos ORDER BY forma_pagamento desc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbformadepagamento.DataSource = dt;
                cbformadepagamento.DisplayMember = "forma_pagamento";
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }

        }

        private void AtualizarTotais()
        {
            precototal = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells["valor_total"].Value != null)
                {
                    precototal += Convert.ToDecimal(dataGridView2.Rows[i].Cells["valor_total"].Value);
                }
            }

            //lbltotalitens.Text = "Total de itens: " + dataGridView1.RowCount;
            lblvalor_total.Text = "Total: " + precototal.ToString("C");
        }

        private void calcularvalorvendafracionda()
        {

            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";
            }

            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }

            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }

            if (txtdesconto.Text.Trim() == "")
            {
                txtdesconto.Text = "0,00";
            }

            if (txttaxa.Text.Trim() == "")
            {
                txttaxa.Text = "0,00";
            }

            decimal dinheiro = decimal.Parse(txtdinheiro.Text.Trim().Replace("R$", ""));
            decimal pix = decimal.Parse(txtpix.Text.Trim().Replace("R$", ""));
            decimal cartao = decimal.Parse(txtcartao.Text.Trim().Replace("R$", ""));

            // Somar os valores de dinheiro, pix e cartão
            decimal somaFracionado = dinheiro + pix + cartao;
            valorfracionado = (decimal)somaFracionado;
            lblvalor_total.Text = "Total: " + precototal.ToString("C");

            // Calcular descontos
            decimal descontos = decimal.Parse(txtdesconto.Text.Replace("%", ""));
            decimal valorDescontos = (decimal)precototal * (descontos / 100);

            // Calcular valor com descontos
            decimal valorComDescontos = (decimal)precototal - valorDescontos;

            // Calcular taxa sobre o valor com descontos
            decimal taxa = decimal.Parse(txttaxa.Text.Replace("%", ""));
            decimal resultadoFracionado = valorComDescontos * (1 + (taxa / 100));

            // Calcular troco com descontos e taxas
            decimal troco = somaFracionado - resultadoFracionado;

            if (resultadoFracionado > precototal || cbformadepagamento.Text == "PIX" || cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
            {
                lbltroco.Text = "Troco: R$ 0,00";
            }
            else
            {
                // Atualizar o TextBox do troco
                lbltroco.Text = "Troco: " + troco.ToString("C", CultureInfo.CurrentCulture);
            }

            lblvalor_total.Text = "Total: " + resultadoFracionado.ToString("C");
        }

        private void AtualizarQuantidadeProdutosVendidos()
        {
            try
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    con.AbrirConexao();

                    string idProduto = dataGridView2.Rows[i].Cells["codigo"].Value.ToString();
                    int quantidadeVendida = Convert.ToInt32(dataGridView2.Rows[i].Cells["quantidade"].Value);

                    string updateQuery = $"UPDATE cad_produtos SET quantidade = quantidade - {quantidadeVendida} WHERE cod_produto = {idProduto}";

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




        #endregion

        #region KEYPRESS \ ENTER \ LEAVE \ SELECTED INDEX CHANGED
        private void txtgarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtquantidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtquantidadep_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtpix_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txttaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtdinheiro_Enter(object sender, EventArgs e)
        {
            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";
            }
            string valor = txtdinheiro.Text.Replace("R$ ", "");
            txtdinheiro.Text = valor;
        }

        private void txtpix_Enter(object sender, EventArgs e)
        {
            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }
            string valor = txtpix.Text.Replace("R$ ", "");
            txtpix.Text = valor;
        }

        private void txtcartao_Enter(object sender, EventArgs e)
        {
            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }
            string valor = txtcartao.Text.Replace("R$ ", "");
            txtcartao.Text = valor;
        }     

        private void cbclientes_Leave(object sender, EventArgs e)
        {
            if (cbclientes.Text.Trim() == "")
            {
                cbtecnico.Focus();
                cbclientes.BackColor = Color.White;
                return;
            }
            Buscarclientes();
        }

        private void cbtecnico_Leave(object sender, EventArgs e)
        {
            if (cbtecnico.Text.Trim() == "")
            {
                cbstatus.Focus();
                return;
            }
            Buscarfuncionario();
        }

        private void cbservico_Leave(object sender, EventArgs e)
        {
            if (cbservico.Text.Trim() == "")
            {
                txtquantidades.Focus();
                return;
            }
            Buscarservico();
        }

        private void cbproduto_Leave(object sender, EventArgs e)
        {
            if (cbproduto.Text.Trim() == "")
            {
                txtquantidadep.Focus();
                return;
            }
            Buscarproduto();
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            cbformadepagamento.SelectedIndex = -1;
            txtdinheiro.Text = "0,00";
            txtpix.Text = "0,00";
            txtcartao.Text = "0,00";
            lblvalor_total.Text = "Total:";
        }

        private void txtdinheiro_Leave(object sender, EventArgs e)
        {
            if (txtdinheiro.Text.Trim() == "")
            {
                txtdinheiro.Text = "0,00";

            }
            if (decimal.TryParse(txtdinheiro.Text, out decimal valor))
            {

                txtdinheiro.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtpix_Leave(object sender, EventArgs e)
        {
            if (txtpix.Text.Trim() == "")
            {
                txtpix.Text = "0,00";
            }
            if (decimal.TryParse(txtpix.Text, out decimal valor))
            {

                txtpix.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtcartao_Leave(object sender, EventArgs e)
        {
            if (txtcartao.Text.Trim() == "")
            {
                txtcartao.Text = "0,00";
            }
            if (decimal.TryParse(txtcartao.Text, out decimal valor))
            {

                txtcartao.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }
            calcularvalorvendafracionda();
        }

        private void txtdesconto_Leave(object sender, EventArgs e)
        {
            if (txtdesconto.Text == "")
            {
                txtdesconto.Text = "0,00";
            }
            if (decimal.Parse(txtdesconto.Text) > 100)
            {
                MessageBox.Show("Desconto não pode exceder 100%!");
                txtdesconto.Text = "0";
                txtdesconto.Focus();
            }
            txttaxa.Focus();          

            calcularvalorvendafracionda();
        }

        private void txttaxa_Leave(object sender, EventArgs e)
        {
            if(txttaxa.Text == "")
            {
                txttaxa.Text = "0,00";
            }
                        
            calcularvalorvendafracionda();
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstatus.Text == "FINALIZADO" && (cbclientes.Text.Trim() == "" || cbtecnico.Text.Trim() == "" || txtdescricao.Text.Trim() == "" || txtlaudo.Text == "" || dataGridView2.Rows.Count < 1 ))
            {
                MessageBox.Show("Verifique se a OS está salva, caso esteja, verifique os seguintes campos antes de finalizar a OS: (Clientes), (técnico), (descrição), (laudo técnico), (Adicionar pelo menos um serviço ou produto para gerar valor a pagar)");
                cbstatus.SelectedIndex = -1;
                cbstatus.Focus();
                btngerarpagamento.Enabled = false; 
            }
            else if (cbstatus.Text == "FINALIZADO" && (cbclientes.Text.Trim() != "" && cbtecnico.Text.Trim() != "" && txtdescricao.Text.Trim() != "" && txtlaudo.Text.Trim() != "" && dataGridView2.Rows.Count > 0 && btnadicionar.Enabled != true))
            {
                btngerarpagamento.Enabled = true;
            }
            else
            {
                btngerarpagamento.Enabled = false; 
            }
        }

        private void cbformadepagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbformadepagamento.Text == "FRACIONADO")
            {

                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = "R$ 0,00";
                txtdinheiro.Enabled = true;
                txtpix.Text = "R$ 0,00";
                txtpix.Enabled = true;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = true;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdinheiro.Focus();
            }

            if (cbformadepagamento.Text == "DINHEIRO")
            {

                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = precototal.ToString("C");
                txtdinheiro.Enabled = false;
                txtpix.Text = "R$ 0,00";
                txtpix.Enabled = false;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = false;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdesconto.Focus();
            }

            if (cbformadepagamento.Text == "CRÉDITO CLIENTE")
            {

                txtdinheiro.Text = "R$ 0,00"; ;
                txtpix.Text = "R$ 0,00"; ;
                txtcartao.Text = "R$ 0,00";
                txttaxa.Text = "0,00";
                txtdesconto.Text = "0,00";
                lbltroco.Text = "Troco: R$ 0,00";

            }


            if (cbformadepagamento.Text == "PIX" || cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
            {


                lbltroco.Text = "Troco: R$ 0,00";
                txtdinheiro.Text = "0,00";
                txtdinheiro.Enabled = false;
                txtpix.Text = "0,00";
                txtpix.Enabled = false;
                txtcartao.Text = "R$ 0,00";
                txtcartao.Enabled = false;
                txttaxa.Text = "0,00";
                txttaxa.Enabled = true;
                txtdesconto.Text = "0,00";
                txtdesconto.Enabled = true;
                txtdesconto.Focus();


                if (cbformadepagamento.Text == "PIX")
                {
                    txtpix.Text = precototal.ToString("C");
                    txtdinheiro.Text = "R$ 0,00";
                    txtcartao.Text = "R$ 0,00";
                    txttaxa.Text = "0,00";
                    txtdesconto.Text = "0,00";
                }
                else if (cbformadepagamento.Text == "CARTÃO DE CRÉDITO" || cbformadepagamento.Text == "CARTÃO DE DÉBITO")
                {
                    txtpix.Text = "R$ 0,00";
                    txtdinheiro.Text = "R$ 0,00";
                    txttaxa.Text = "0,00";
                    txtdesconto.Text = "0,00";
                    txtcartao.Text = precototal.ToString("C");
                }

            }
            lblvalor_total.Text = "Total: " + precototal.ToString("C");

        }




        #endregion

        #region BOTÕES
        private void btnnovo_Click(object sender, EventArgs e)
        {
            cbclientes.Enabled = true;
            cbclientes.Text = "";
            cbtecnico.Enabled = true;
            cbtecnico.Text = "";
            cbstatus.Enabled = true;
            cbstatus.SelectedIndex = -1;
            dtinicial.Enabled = true;
            dtinicial.Value = DateTime.Now;
            dtfinal.Enabled = true;
            dtfinal.Value = DateTime.Now;
            txtgarantia.Enabled = true;
            txtgarantia.Clear();
            txttermo.Enabled = true;
            txttermo.Clear();
            txtdescricao.Enabled = true;
            txtdescricao.Clear();
            txtdefeito.Enabled = true;
            txtdefeito.Clear();
            txtobservacao.Enabled = true;
            txtobservacao.Clear();
            txtlaudo.Enabled = true;
            txtlaudo.Clear();
            cbservico.Enabled = true;
            cbservico.Text = "";
            cbproduto.Enabled = true;
            cbproduto.Text = "";
            txtquantidades.Enabled = true;
            txtquantidades.Clear();
            txtquantidadep.Enabled = true;
            txtquantidadep.Clear();
            btnadicionars.Enabled = true;
            btnadicionarp.Enabled = true;
            btnexcluirlista.Enabled = true;
            btnnovo.Enabled = false;
            btnadicionar.Enabled = true;
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            btncancelar.Enabled = true;
            btngerarpagamento.Enabled = false;
            dataGridView2.Rows.Clear();
            cbclientes.Focus();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbclientes.Enabled = false;
            cbclientes.Text = "";
            cbtecnico.Enabled = false;
            cbtecnico.Text = "";
            cbstatus.Enabled = false;
            cbstatus.SelectedIndex = -1;
            dtinicial.Enabled = false;
            dtinicial.Value = DateTime.Now;
            dtfinal.Enabled = false;
            dtfinal.Value = DateTime.Now;
            txtgarantia.Enabled = false;
            txtgarantia.Clear();
            txttermo.Enabled = false;
            txttermo.Clear();
            txtdescricao.Enabled = false;
            txtdescricao.Clear();
            txtdefeito.Enabled = false;
            txtdefeito.Clear();
            txtobservacao.Enabled = false;
            txtobservacao.Clear();
            txtlaudo.Enabled = false;
            txtlaudo.Clear();
            cbservico.Enabled = false;
            cbservico.Text = "";
            cbproduto.Enabled = false;
            cbproduto.Text = "";
            txtquantidades.Enabled = false;
            txtquantidades.Clear();
            txtquantidadep.Enabled = false;
            txtquantidadep.Clear();
            btnadicionars.Enabled = false;
            btnadicionarp.Enabled = false;
            btnexcluirlista.Enabled = false;
            btnnovo.Enabled = true;
            btnadicionar.Enabled = false;
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            btncancelar.Enabled = true;
            btngerarpagamento.Enabled = false;
            dataGridView2.Rows.Clear();
            panel1.Visible = false;
            btnnovo.Focus();
            contarvendas();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {

            if (cbclientes.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um cliente antes de adicionar OS!");
                cbclientes.Focus();
                return;
            }

            if (cbtecnico.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um técnico antes de adicionar OS!");
                cbtecnico.Focus();
                return;
            }

            if (cbstatus.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um status antes de adicionar OS!");
                cbstatus.Focus();
                return;
            }

            if (cbstatus.Text == "FINALIZADO")
            {
                MessageBox.Show("O status FINALIZADO só pode ser escolhido depois que a OS for salva!");
                cbstatus.SelectedIndex = -1;
                cbstatus.Focus(); 
                return;
            }

            if (dtinicial.Value.Date > dtfinal.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final");
                dtinicial.Focus();
                return;
            }

            if (txtgarantia.Text.Trim() == "")
            {
                MessageBox.Show("Informe a garantia antes de adicionar OS!");
                txtgarantia.Focus();
                return;
            }

            if (txtdescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição dos equipamentos antes de adicionar OS!");
                txtdescricao.Focus();
                return;
            }

            if (txtdefeito.Text.Trim() == "")
            {
                MessageBox.Show("Informe o defeito dos equipamentos antes de adicionar OS!");
                txtdefeito.Focus();
                return;
            }

            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO cad_os (cod_os, cliente, tecnico, status, data_inicial, data_final, garantia, termo, descricao, defeito, observacoes, laudo, cod_empresa) VALUES(@cod_os, @cliente, @tecnico, @status, @data_inicial, @data_final, @garantia, @termo, @descricao, @defeito, @observacoes, @laudo, @cod_empresa)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                cmd.Parameters.AddWithValue("@tecnico", cbtecnico.Text);
                cmd.Parameters.AddWithValue("@status", cbstatus.Text);
                cmd.Parameters.AddWithValue("@data_inicial", dtinicial.Value.Date);
                cmd.Parameters.AddWithValue("@data_final", dtfinal.Value.Date);
                cmd.Parameters.AddWithValue("@garantia", txtgarantia.Text);
                cmd.Parameters.AddWithValue("@termo", txttermo.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@defeito", txtdefeito.Text);
                cmd.Parameters.AddWithValue("@observacoes", txtobservacao.Text);
                cmd.Parameters.AddWithValue("@laudo", txtlaudo.Text);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    sql1 = "INSERT INTO detalhes_os (cod_os, descricao, quantidade, cod_empresa, preco_unitario, preco_total, codigo) VALUES (@cod_os, @descricao, @quantidade, @cod_empresa, @preco_unitario, @preco_total, @codigo)";
                    cmd1 = new MySqlCommand(sql1, con.con);
                    cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                    cmd1.Parameters.AddWithValue("@codigo", dataGridView2.Rows[i].Cells["codigo"].Value);
                    cmd1.Parameters.AddWithValue("@descricao", dataGridView2.Rows[i].Cells["descricao"].Value);
                    cmd1.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                    cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                    cmd1.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                    cmd1.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);
                    cmd1.ExecuteNonQuery();
                }

                cmd.ExecuteNonQuery();
                con.FecharConexao();



                con.AbrirConexao();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, valor_unitario, dinheiro, pix, cartao, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa, vencimento, cod_produto) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @valor_unitario, @dinheiro, @pix, @cartao, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa, @vencimento, @cod_produto)";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@cod_venda", conta_venda);
                    cmd.Parameters.AddWithValue("@tipo", "ORDEM DE SERVIÇO");
                    cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                    cmd.Parameters.AddWithValue("@produto", dataGridView2.Rows[i].Cells["descricao"].Value);
                    cmd.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                    cmd.Parameters.AddWithValue("@valor_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                    cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@vencimento", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                    cmd.Parameters.AddWithValue("@vendedor", cbtecnico.Text);
                    cmd.Parameters.AddWithValue("@descontos", txtdesconto.Text.Replace("%", "").Trim());
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                    cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@valor_pago", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@troco", lbltroco.Text.Replace("Troco: ", "").Replace("R$", "").Trim().Replace(",", "."));
                    cmd.Parameters.AddWithValue("@data", DateTime.Today);
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                    cmd.Parameters.AddWithValue("@cod_produto", dataGridView2.Rows[i].Cells["codigo"].Value);


                    cmd.ExecuteNonQuery();

                }
                con.FecharConexao();



                MessageBox.Show("OS adicionada com sucesso!");

                cbclientes.Enabled = false;
                cbclientes.Text = "";
                cbtecnico.Enabled = false;
                cbtecnico.Text = "";
                cbstatus.Enabled = false;
                cbstatus.SelectedIndex = -1;
                dtinicial.Enabled = false;
                dtinicial.Value = DateTime.Now;
                dtfinal.Enabled = false;
                dtfinal.Value = DateTime.Now;
                txtgarantia.Enabled = false;
                txtgarantia.Clear();
                txttermo.Enabled = false;
                txttermo.Clear();
                txtdescricao.Enabled = false;
                txtdescricao.Clear();
                txtdefeito.Enabled = false;
                txtdefeito.Clear();
                txtobservacao.Enabled = false;
                txtobservacao.Clear();
                txtlaudo.Enabled = false;
                txtlaudo.Clear();
                cbservico.Enabled = false;
                cbservico.Text = "";
                cbproduto.Enabled = false;
                cbproduto.Text = "";
                txtquantidades.Enabled = false;
                txtquantidades.Clear();
                txtquantidadep.Enabled = false;
                txtquantidadep.Clear();
                btnadicionars.Enabled = false;
                btnadicionarp.Enabled = false;
                btnexcluirlista.Enabled = false;
                btnnovo.Enabled = true;
                btnadicionar.Enabled = false;
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
                btncancelar.Enabled = true;
                btngerarpagamento.Enabled = false;
                dataGridView2.Rows.Clear();
                btnnovo.Focus();
                listar();
                contarvendas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    con.AbrirConexao();

                    // Excluir da tabela cad_os
                    sql = "DELETE FROM cad_os WHERE cod_os = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", conta_venda);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();


                    con.AbrirConexao();
                    // Excluir da tabela detalhes_os
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        sql1 = "DELETE FROM detalhes_os WHERE cod_os = @id";
                        cmd1 = new MySqlCommand(sql1, con.con);
                        cmd1.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["cod_os"].Value);
                        cmd1.ExecuteNonQuery();
                    }
                    con.FecharConexao();


                    con.AbrirConexao();
                    // Excluir da tabela Vendas
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        sql1 = "DELETE FROM vendas WHERE cod_venda = @id";
                        cmd1 = new MySqlCommand(sql1, con.con);
                        cmd1.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["cod_os"].Value);
                        cmd1.ExecuteNonQuery();
                    }
                    con.FecharConexao();


                    MessageBox.Show("OS excluída com sucesso!");

                    listar();



                    cbclientes.Enabled = false;
                    cbclientes.Text = "";
                    cbtecnico.Enabled = false;
                    cbtecnico.Text = "";
                    cbstatus.Enabled = false;
                    cbstatus.SelectedIndex = -1;
                    dtinicial.Enabled = false;
                    dtinicial.Value = DateTime.Now;
                    dtfinal.Enabled = false;
                    dtfinal.Value = DateTime.Now;
                    txtgarantia.Enabled = false;
                    txtgarantia.Clear();
                    txttermo.Enabled = false;
                    txttermo.Clear();
                    txtdescricao.Enabled = false;
                    txtdescricao.Clear();
                    txtdefeito.Enabled = false;
                    txtdefeito.Clear();
                    txtobservacao.Enabled = false;
                    txtobservacao.Clear();
                    txtlaudo.Enabled = false;
                    txtlaudo.Clear();
                    cbservico.Enabled = false;
                    cbservico.Text = "";
                    cbproduto.Enabled = false;
                    cbproduto.Text = "";
                    txtquantidades.Enabled = false;
                    txtquantidades.Clear();
                    txtquantidadep.Enabled = false;
                    txtquantidadep.Clear();
                    btnadicionars.Enabled = false;
                    btnadicionarp.Enabled = false;
                    btnexcluirlista.Enabled = false;
                    btnnovo.Enabled = true;
                    btnadicionar.Enabled = false;
                    btnalterar.Enabled = false;
                    btnexcluir.Enabled = false;
                    btncancelar.Enabled = true;
                    btngerarpagamento.Enabled = false;
                    dataGridView2.Rows.Clear();
                    btnnovo.Focus();

                }
                else
                {
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnadicionars_Click(object sender, EventArgs e)
        {


            if(cbservico.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um serviço para adicionar à lista!");
                cbservico.Focus();
                return;
            }
            if(txtquantidades.Text.Trim() == "")
            {
                MessageBox.Show("Digite uma quantidade para adicionar à lista!");
                txtquantidades.Focus();
                return;
            }

            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_servicos WHERE cod_empresa = @cod_empresa AND descricao = '" + cbservico.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                MySqlDataReader r = cmd.ExecuteReader();




                while (r.Read())
                {

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells["descricao"].Value != null && dataGridView2.Rows[i].Cells["descricao"].Value.ToString() == cbservico.Text)
                        {
                            double novaQuantidade = double.Parse(txtquantidades.Text.Trim());
                            double quantidadeAtual = double.Parse(dataGridView2.Rows[i].Cells["quantidade"].Value.ToString());
                            dataGridView2.Rows[i].Cells["quantidade"].Value = (quantidadeAtual + novaQuantidade).ToString();


                            double teste1 = double.Parse(dataGridView2.Rows[i].Cells["quantidade"].Value.ToString());
                            double teste2 = double.Parse(dataGridView2.Rows[i].Cells["valor_unitario"].Value.ToString());
                            double resultado = teste1 * teste2;
                            dataGridView2.Rows[i].Cells["valor_total"].Value = resultado.ToString();
                            cbservico.Text = "";
                            txtquantidades.Text = "";
                            cbservico.Focus();
                            return;
                        }
                    }
                    double preco = double.Parse(txtquantidades.Text.ToString()) * double.Parse(r["valor"].ToString());

                    dataGridView2.Rows.Add(conta_venda, r["cod_servico"], r["descricao"], txtquantidades.Text, r["valor"], preco);
                    cbservico.Text = "";
                    txtquantidades.Text = "";
                    cbservico.Focus();

                }
                con.FecharConexao();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnadicionarp_Click(object sender, EventArgs e)
        {

            if(cbproduto.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um produto para adicionar à lista!");
                cbproduto.Focus();
                return;
            }

            if(txtquantidadep.Text.Trim() == "")
            {
                MessageBox.Show("Digite uma quantidade para adicionar à lista!");
                txtquantidadep.Focus();
                return;
            }


            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa AND nome_produto = '" + cbproduto.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                MySqlDataReader r = cmd.ExecuteReader();




                while (r.Read())
                {

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells["descricao"].Value != null && dataGridView2.Rows[i].Cells["descricao"].Value.ToString() == cbproduto.Text)
                        {
                            double novaQuantidade = double.Parse(txtquantidadep.Text.Trim());
                            double quantidadeAtual = double.Parse(dataGridView2.Rows[i].Cells["quantidade"].Value.ToString());
                            dataGridView2.Rows[i].Cells["quantidade"].Value = (quantidadeAtual + novaQuantidade).ToString();


                            double teste1 = double.Parse(dataGridView2.Rows[i].Cells["quantidade"].Value.ToString());
                            double teste2 = double.Parse(dataGridView2.Rows[i].Cells["valor_unitario"].Value.ToString());
                            double resultado = teste1 * teste2;
                            dataGridView2.Rows[i].Cells["valor_total"].Value = resultado.ToString();
                            cbproduto.Text = "";
                            txtquantidadep.Text = "";
                            cbproduto.Focus();
                            return;
                        }
                    }
                    double preco = double.Parse(txtquantidadep.Text.ToString()) * double.Parse(r["valor_venda"].ToString());

                    dataGridView2.Rows.Add(conta_venda, r["cod_produto"], r["nome_produto"], txtquantidadep.Text, r["valor_venda"], preco);
                    cbproduto.Text = "";
                    txtquantidadep.Text = "";
                    cbproduto.Focus();

                }
                con.FecharConexao();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcluirlista_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.RowCount > 0)
                {
                    int selectedIndex = dataGridView2.CurrentRow.Index;
                    dataGridView2.Rows.RemoveAt(selectedIndex);

                    if (dataGridView2.RowCount < 1)
                    {

                        cbservico.Focus();


                    }
                }
                else
                {

                    MessageBox.Show("Não existem itens para remover!");


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item para excluir");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (cbclientes.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um cliente antes de adicionar OS!");
                cbclientes.Focus();
                return;
            }

            if (cbtecnico.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um técnico antes de adicionar OS!");
                cbtecnico.Focus();
                return;
            }

            if (cbstatus.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um status antes de adicionar OS!");
                cbstatus.Focus();
                return;
            }

            if(cbstatus.Text == "FINALIZADO")
            {
                MessageBox.Show("O status não pode ser FINALIZADO para efetuar alterações!");
                cbstatus.SelectedIndex = -1;
                cbstatus.Focus();
                return;
            }

            if (dtinicial.Value.Date > dtfinal.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final");
                dtinicial.Focus();
                return;
            }

            if (txtgarantia.Text.Trim() == "")
            {
                MessageBox.Show("Informe a garantia antes de adicionar OS!");
                txtgarantia.Focus();
                return;
            }

            if (txtdescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição dos equipamentos antes de adicionar OS!");
                txtdescricao.Focus();
                return;
            }

            if (txtdefeito.Text.Trim() == "")
            {
                MessageBox.Show("Informe o defeito dos equipamentos antes de adicionar OS!");
                txtdefeito.Focus();
                return;
            }


            try
            {
                con.AbrirConexao();
                sql = "UPDATE cad_os SET cliente = @cliente, tecnico = @tecnico, status = @status, data_inicial = @data_inicial, data_final = @data_final, garantia = @garantia, termo = @termo, descricao = @descricao, defeito = @defeito, observacoes = @observacoes, laudo = @laudo WHERE cod_os = @cod_os";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                cmd.Parameters.AddWithValue("@tecnico", cbtecnico.Text);
                cmd.Parameters.AddWithValue("@status", cbstatus.Text);
                cmd.Parameters.AddWithValue("@data_inicial", dtinicial.Value.Date);
                cmd.Parameters.AddWithValue("@data_final", dtfinal.Value.Date);
                cmd.Parameters.AddWithValue("@garantia", txtgarantia.Text);
                cmd.Parameters.AddWithValue("@termo", txttermo.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@defeito", txtdefeito.Text);
                cmd.Parameters.AddWithValue("@observacoes", txtobservacao.Text);
                cmd.Parameters.AddWithValue("@laudo", txtlaudo.Text);


                cmd.ExecuteNonQuery();
                con.FecharConexao();


                con.AbrirConexao();
                sql1 = "SELECT * FROM detalhes_os WHERE cod_empresa = @cod_empresa AND cod_os = @cod_os";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd1;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.FecharConexao();

                int indiceoriginal = dt.Rows.Count;
                int novoindice = dataGridView2.Rows.Count;





                if (novoindice > indiceoriginal)
                {
                    con.AbrirConexao();

                    for (int i = indiceoriginal; i < novoindice; i++)
                    {
                        sql1 = "INSERT INTO detalhes_os (cod_os, descricao, quantidade, cod_empresa, preco_unitario, preco_total, codigo) VALUES (@cod_os, @descricao, @quantidade, @cod_empresa, @preco_unitario, @preco_total, @codigo)";
                        cmd1 = new MySqlCommand(sql1, con.con);
                        cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                        cmd1.Parameters.AddWithValue("@codigo", dataGridView2.Rows[i].Cells["codigo"].Value);
                        cmd1.Parameters.AddWithValue("@descricao", dataGridView2.Rows[i].Cells["descricao"].Value);
                        cmd1.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                        cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                        cmd1.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                        cmd1.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);
                        cmd1.ExecuteNonQuery();

                    }
                    con.FecharConexao();

                    con.AbrirConexao();

                    for (int i = indiceoriginal; i < novoindice; i++)
                    {
                        sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, valor_unitario, dinheiro, pix, cartao, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa, vencimento, cod_produto) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @valor_unitario, @dinheiro, @pix, @cartao, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa, @vencimento, @cod_produto)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@cod_venda", conta_venda);
                        cmd.Parameters.AddWithValue("@tipo", "ORDEM DE SERVIÇO");
                        cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                        cmd.Parameters.AddWithValue("@produto", dataGridView2.Rows[i].Cells["descricao"].Value);
                        cmd.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                        cmd.Parameters.AddWithValue("@valor_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                        cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@vencimento", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@vendedor", cbtecnico.Text);
                        cmd.Parameters.AddWithValue("@descontos", txtdesconto.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                        cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@valor_pago", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@troco", lbltroco.Text.Replace("Troco: ", "").Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@data", DateTime.Today);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                        cmd.Parameters.AddWithValue("@cod_produto", dataGridView2.Rows[i].Cells["codigo"].Value);


                        cmd.ExecuteNonQuery();

                    }
                    con.FecharConexao();

                }
                else
                {

                    if (novoindice < indiceoriginal)
                    {
                        con.AbrirConexao();

                        // Criar uma lista para armazenar os IDs das linhas a serem removidas
                        List<int> idsParaRemover = new List<int>();

                        // Preencher a lista com os IDs das linhas a serem removidas
                        for (int i = novoindice; i < indiceoriginal; i++)
                        {
                            int codigoRemovido = Convert.ToInt32(dt.Rows[i]["id"]); // Substitua "id" pelo nome da coluna de ID na tabela detalhes_os
                            idsParaRemover.Add(codigoRemovido);
                        }

                        // Excluir as linhas no banco de dados usando os IDs armazenados na lista
                        foreach (int idParaRemover in idsParaRemover)
                        {
                            sql1 = "DELETE FROM detalhes_os WHERE id = @codigo";
                            cmd1 = new MySqlCommand(sql1, con.con);
                            cmd1.Parameters.AddWithValue("@codigo", idParaRemover);
                            cmd1.ExecuteNonQuery();
                        }

                        con.FecharConexao();


                        con.AbrirConexao();

                        // Criar uma lista para armazenar os IDs das linhas a serem removidas
                        List<int> idsParaRemover1 = new List<int>();

                        // Preencher a lista com os IDs das linhas a serem removidas
                        for (int i = novoindice; i < indiceoriginal; i++)
                        {
                            int codigoRemovido1 = Convert.ToInt32(dt.Rows[i]["id"]); // Substitua "id" pelo nome da coluna de ID na tabela vendas
                            idsParaRemover1.Add(codigoRemovido1);
                        }

                        // Excluir as linhas no banco de dados usando os IDs armazenados na lista
                        foreach (int idParaRemover1 in idsParaRemover1)
                        {
                            sql = "DELETE FROM vendas WHERE id = @codigo";
                            cmd = new MySqlCommand(sql, con.con);
                            cmd.Parameters.AddWithValue("@codigo", idParaRemover1);
                            cmd.ExecuteNonQuery();
                        }

                        con.FecharConexao();

                    }
                    else
                    {
                        if (dataGridView2.Rows.Count > 0)
                        {
                            con.AbrirConexao();
                            for (int i = 0; i < novoindice; i++)
                            {

                                sql = "UPDATE detalhes_os SET quantidade = @quantidade, preco_unitario = @preco_unitario, preco_total = @preco_total WHERE cod_os = @cod_os AND codigo = @id";
                                cmd = new MySqlCommand(sql, con.con);
                                cmd.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["codigo"].Value);
                                cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                                cmd.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                                cmd.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                                cmd.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);

                                cmd.ExecuteNonQuery();

                            }
                            con.FecharConexao();


                            con.AbrirConexao();
                            for (int i = 0; i < novoindice; i++)
                            {

                                sql1 = "UPDATE vendas SET quantidade = @quantidade, valor_unitario = @preco_unitario, valor_total = @preco_total, forma_pagamento = @forma_pagamento, dinheiro = @dinheiro, pix = @pix, taxa = @taxa, descontos = @descontos WHERE cod_venda = @cod_os AND cod_produto = @id";
                                cmd1 = new MySqlCommand(sql1, con.con);
                                cmd1.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["codigo"].Value);
                                cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                                cmd1.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                                cmd1.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                                cmd1.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);
                                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                                cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@descontos", txtdesconto.Text.Trim().Replace("R$", ""));

                                cmd1.ExecuteNonQuery();

                            }
                            con.FecharConexao();

                        }
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("OS alterada com sucesso!");


            cbclientes.Enabled = false;
            cbclientes.Text = "";
            cbtecnico.Enabled = false;
            cbtecnico.Text = "";
            cbstatus.Enabled = false;
            cbstatus.SelectedIndex = -1;
            dtinicial.Enabled = false;
            dtinicial.Value = DateTime.Now;
            dtfinal.Enabled = false;
            dtfinal.Value = DateTime.Now;
            txtgarantia.Enabled = false;
            txtgarantia.Clear();
            txttermo.Enabled = false;
            txttermo.Clear();
            txtdescricao.Enabled = false;
            txtdescricao.Clear();
            txtdefeito.Enabled = false;
            txtdefeito.Clear();
            txtobservacao.Enabled = false;
            txtobservacao.Clear();
            txtlaudo.Enabled = false;
            txtlaudo.Clear();
            cbservico.Enabled = false;
            cbservico.Text = "";
            cbproduto.Enabled = false;
            cbproduto.Text = "";
            txtquantidades.Enabled = false;
            txtquantidades.Clear();
            txtquantidadep.Enabled = false;
            txtquantidadep.Clear();
            btnadicionars.Enabled = false;
            btnadicionarp.Enabled = false;
            btnexcluirlista.Enabled = false;
            btnnovo.Enabled = true;
            btnadicionar.Enabled = false;
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            btncancelar.Enabled = true;
            btngerarpagamento.Enabled = false;
            dataGridView2.Rows.Clear();
            btnnovo.Focus();
            listar();
            contarvendas();



        }

        private void btngerarpagamento_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cbformadepagamento.SelectedIndex = -1;
            cbformadepagamento.Focus();
            AtualizarTotais();
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            if (cbclientes.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um cliente antes de adicionar OS!");
                cbclientes.Focus();
                return;
            }

            if (cbtecnico.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um técnico antes de adicionar OS!");
                cbtecnico.Focus();
                return;
            }

            if (cbstatus.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um status antes de adicionar OS!");
                cbstatus.Focus();
                return;
            }            

            if (dtinicial.Value.Date > dtfinal.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final");
                dtinicial.Focus();
                return;
            }

            if (txtgarantia.Text.Trim() == "")
            {
                MessageBox.Show("Informe a garantia antes de adicionar OS!");
                txtgarantia.Focus();
                return;
            }

            if (txtdescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição dos equipamentos antes de adicionar OS!");
                txtdescricao.Focus();
                return;
            }

            if (txtdefeito.Text.Trim() == "")
            {
                MessageBox.Show("Informe o defeito dos equipamentos antes de adicionar OS!");
                txtdefeito.Focus();
                return;
            }

            if(cbformadepagamento.Text == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                cbformadepagamento.Focus();
                return;
            }

            if(valorfracionado < precototal)
            {
                MessageBox.Show("O valor pago não pode ser menor que o valor total!");                
                return;
            }


            try
            {
                con.AbrirConexao();
                sql = "UPDATE cad_os SET cliente = @cliente, tecnico = @tecnico, status = @status, data_inicial = @data_inicial, data_final = @data_final, garantia = @garantia, termo = @termo, descricao = @descricao, defeito = @defeito, observacoes = @observacoes, laudo = @laudo WHERE cod_os = @cod_os";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                cmd.Parameters.AddWithValue("@tecnico", cbtecnico.Text);
                cmd.Parameters.AddWithValue("@status", cbstatus.Text);
                cmd.Parameters.AddWithValue("@data_inicial", dtinicial.Value.Date);
                cmd.Parameters.AddWithValue("@data_final", dtfinal.Value.Date);
                cmd.Parameters.AddWithValue("@garantia", txtgarantia.Text);
                cmd.Parameters.AddWithValue("@termo", txttermo.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@defeito", txtdefeito.Text);
                cmd.Parameters.AddWithValue("@observacoes", txtobservacao.Text);
                cmd.Parameters.AddWithValue("@laudo", txtlaudo.Text);


                cmd.ExecuteNonQuery();
                con.FecharConexao();

                con.AbrirConexao();
                sql1 = "SELECT * FROM detalhes_os WHERE cod_empresa = @cod_empresa AND cod_os = @cod_os";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd1;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.FecharConexao();

                int indiceoriginal = dt.Rows.Count;
                int novoindice = dataGridView2.Rows.Count;





                if (novoindice > indiceoriginal)
                {
                    con.AbrirConexao();

                    for (int i = indiceoriginal; i < novoindice; i++)
                    {
                        sql1 = "INSERT INTO detalhes_os (cod_os, descricao, quantidade, cod_empresa, preco_unitario, preco_total, codigo) VALUES (@cod_os, @descricao, @quantidade, @cod_empresa, @preco_unitario, @preco_total, @codigo)";
                        cmd1 = new MySqlCommand(sql1, con.con);
                        cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                        cmd1.Parameters.AddWithValue("@codigo", dataGridView2.Rows[i].Cells["codigo"].Value);
                        cmd1.Parameters.AddWithValue("@descricao", dataGridView2.Rows[i].Cells["descricao"].Value);
                        cmd1.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                        cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                        cmd1.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                        cmd1.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);
                        cmd1.ExecuteNonQuery();

                    }
                    con.FecharConexao();

                    con.AbrirConexao();

                    for (int i = indiceoriginal; i < novoindice; i++)
                    {
                        sql = "INSERT INTO vendas (cod_venda, tipo, cliente, produto, quantidade, valor_unitario, dinheiro, pix, cartao, taxa, vendedor, descontos, forma_pagamento, valor_total, valor_pago, troco, data, hora, cod_empresa, vencimento, cod_produto) VALUES (@cod_venda, @tipo, @cliente, @produto, @quantidade, @valor_unitario, @dinheiro, @pix, @cartao, @taxa, @vendedor, @descontos, @forma_pagamento, @valor_total, @valor_pago, @troco, @data, @hora, @cod_empresa, @vencimento, @cod_produto)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@cod_venda", conta_venda);
                        cmd.Parameters.AddWithValue("@tipo", "ORDEM DE SERVIÇO");
                        cmd.Parameters.AddWithValue("@cliente", cbclientes.Text);
                        cmd.Parameters.AddWithValue("@produto", dataGridView2.Rows[i].Cells["descricao"].Value);
                        cmd.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                        cmd.Parameters.AddWithValue("@valor_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                        cmd.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@vencimento", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@vendedor", cbtecnico.Text);
                        cmd.Parameters.AddWithValue("@descontos", txtdesconto.Text.Replace("%", "").Trim());
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                        cmd.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@valor_pago", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@troco", lbltroco.Text.Replace("Troco: ", "").Replace("R$", "").Trim().Replace(",", "."));
                        cmd.Parameters.AddWithValue("@data", DateTime.Today);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                        cmd.Parameters.AddWithValue("@cod_produto", dataGridView2.Rows[i].Cells["codigo"].Value);


                        cmd.ExecuteNonQuery();

                    }
                    con.FecharConexao();

                }
                else
                {

                    if (novoindice < indiceoriginal)
                    {
                        con.AbrirConexao();

                        // Criar uma lista para armazenar os IDs das linhas a serem removidas
                        List<int> idsParaRemover = new List<int>();

                        // Preencher a lista com os IDs das linhas a serem removidas
                        for (int i = novoindice; i < indiceoriginal; i++)
                        {
                            int codigoRemovido = Convert.ToInt32(dt.Rows[i]["id"]); // Substitua "id" pelo nome da coluna de ID na tabela detalhes_os
                            idsParaRemover.Add(codigoRemovido);
                        }

                        // Excluir as linhas no banco de dados usando os IDs armazenados na lista
                        foreach (int idParaRemover in idsParaRemover)
                        {
                            sql1 = "DELETE FROM detalhes_os WHERE id = @codigo";
                            cmd1 = new MySqlCommand(sql1, con.con);
                            cmd1.Parameters.AddWithValue("@codigo", idParaRemover);
                            cmd1.ExecuteNonQuery();
                        }

                        con.FecharConexao();



                        con.AbrirConexao();

                        // Criar uma lista para armazenar os IDs das linhas a serem removidas
                        List<int> idsParaRemover1 = new List<int>();

                        // Preencher a lista com os IDs das linhas a serem removidas
                        for (int i = novoindice; i < indiceoriginal; i++)
                        {
                            int codigoRemovido1 = Convert.ToInt32(dt.Rows[i]["id"]); // Substitua "id" pelo nome da coluna de ID na tabela detalhes_os
                            idsParaRemover1.Add(codigoRemovido1);
                        }

                        // Excluir as linhas no banco de dados usando os IDs armazenados na lista
                        foreach (int idParaRemover1 in idsParaRemover1)
                        {
                            sql = "DELETE FROM vendas WHERE id = @codigo";
                            cmd = new MySqlCommand(sql, con.con);
                            cmd.Parameters.AddWithValue("@codigo", idParaRemover1);
                            cmd.ExecuteNonQuery();
                        }

                        con.FecharConexao();

                    }
                    else
                    {
                        if (dataGridView2.Rows.Count > 0)
                        {
                            con.AbrirConexao();
                            for (int i = 0; i < novoindice; i++)
                            {

                                sql = "UPDATE detalhes_os SET quantidade = @quantidade, preco_unitario = @preco_unitario, preco_total = @preco_total WHERE cod_os = @cod_os AND codigo = @id";
                                cmd = new MySqlCommand(sql, con.con);
                                cmd.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["codigo"].Value);
                                cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                                cmd.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                                cmd.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                                cmd.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);

                                cmd.ExecuteNonQuery();

                            }
                            con.FecharConexao();

                       

                      
                            con.AbrirConexao();
                            for (int i = 0; i < novoindice; i++)
                            {

                                sql1 = "UPDATE vendas SET quantidade = @quantidade, valor_unitario = @preco_unitario, valor_total = @preco_total, forma_pagamento = @forma_pagamento, dinheiro = @dinheiro, pix = @pix, taxa = @taxa, descontos = @descontos WHERE cod_venda = @cod_os AND cod_produto = @id";
                                cmd1 = new MySqlCommand(sql1, con.con);
                                cmd1.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells["codigo"].Value);
                                cmd1.Parameters.AddWithValue("@cod_os", conta_venda);
                                cmd1.Parameters.AddWithValue("@quantidade", dataGridView2.Rows[i].Cells["quantidade"].Value);
                                cmd1.Parameters.AddWithValue("@preco_unitario", dataGridView2.Rows[i].Cells["valor_unitario"].Value);
                                cmd1.Parameters.AddWithValue("@preco_total", dataGridView2.Rows[i].Cells["valor_total"].Value);
                                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                                cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Trim().Replace("R$", ""));
                                cmd1.Parameters.AddWithValue("@descontos", txtdesconto.Text.Trim().Replace("R$", ""));

                                cmd1.ExecuteNonQuery();

                            }
                            con.FecharConexao();

                        }
                    }

                }



                con.AbrirConexao();
                sql1 = "INSERT INTO caixa (cod_venda, tipo, cliente, vendedor, desconto, forma_pagamento, valor_total, valor_pago, data, hora, dinheiro, pix, cartao, vencimento, taxa, cod_empresa, status) VALUES (@cod_venda, @tipo, @cliente, @vendedor, @desconto, @forma_pagamento, @valor_total, @valor_pago, @data, @hora, @dinheiro, @pix, @cartao, @vencimento, @taxa, @cod_empresa, @status)";
                cmd1 = new MySqlCommand(sql1, con.con);
                cmd1.Parameters.AddWithValue("@cod_venda", conta_venda);
                cmd1.Parameters.AddWithValue("@tipo", "ORDEM DE SERVIÇO");
                cmd1.Parameters.AddWithValue("@cliente", cbclientes.Text);
                cmd1.Parameters.AddWithValue("@vendedor", cbtecnico.Text);
                cmd1.Parameters.AddWithValue("@desconto", txtdesconto.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@forma_pagamento", cbformadepagamento.Text);
                cmd1.Parameters.AddWithValue("@valor_total", precototal.ToString().Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@valor_pago", Convert.ToString(precototal).Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@data", DateTime.Today);
                cmd1.Parameters.AddWithValue("@hora", DateTime.Now);
                cmd1.Parameters.AddWithValue("@dinheiro", txtdinheiro.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@pix", txtpix.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@cartao", txtcartao.Text.Replace("R$", "").Trim().Replace(",", "."));
                cmd1.Parameters.AddWithValue("@vencimento", DateTime.Now.Date);
                cmd1.Parameters.AddWithValue("@taxa", txttaxa.Text.Replace("%", "").Trim());
                cmd1.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                cmd1.Parameters.AddWithValue("@status", "À RECEBER");

                cmd1.ExecuteNonQuery();

                con.FecharConexao();                             



                AtualizarQuantidadeProdutosVendidos();

                MessageBox.Show("Pagamento gerado com sucesso!");

                cbclientes.Enabled = false;
                cbclientes.Text = "";
                cbtecnico.Enabled = false;
                cbtecnico.Text = "";
                cbstatus.Enabled = false;
                cbstatus.SelectedIndex = -1;
                dtinicial.Enabled = false;
                dtinicial.Value = DateTime.Now;
                dtfinal.Enabled = false;
                dtfinal.Value = DateTime.Now;
                txtgarantia.Enabled = false;
                txtgarantia.Clear();
                txttermo.Enabled = false;
                txttermo.Clear();
                txtdescricao.Enabled = false;
                txtdescricao.Clear();
                txtdefeito.Enabled = false;
                txtdefeito.Clear();
                txtobservacao.Enabled = false;
                txtobservacao.Clear();
                txtlaudo.Enabled = false;
                txtlaudo.Clear();
                cbservico.Enabled = false;
                cbservico.Text = "";
                cbproduto.Enabled = false;
                cbproduto.Text = "";
                txtquantidades.Enabled = false;
                txtquantidades.Clear();
                txtquantidadep.Enabled = false;
                txtquantidadep.Clear();
                btnadicionars.Enabled = false;
                btnadicionarp.Enabled = false;
                btnexcluirlista.Enabled = false;
                btnnovo.Enabled = true;
                btnadicionar.Enabled = false;
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
                btncancelar.Enabled = true;
                btngerarpagamento.Enabled = false;
                dataGridView2.Rows.Clear();
                panel1.Visible = false;
                btnnovo.Focus();


                DialogResult result = MessageBox.Show("Deseja imprimir os dados da ordem de serviço?", "Confirmação", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                {                    
                    frmrecibodetalhado frmrecibo = new frmrecibodetalhado();
                    funcoes.cod_venda = conta_venda + 1;
                    frmrecibo.ShowDialog();
                }
                
                listar();
                contarvendas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region DATAGRID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            conta_venda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            funcoes.cod_venda = conta_venda;

            

            if (e.RowIndex > -1)
            {
                

                cbclientes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbtecnico.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbstatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtinicial.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                dtfinal.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                txtgarantia.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txttermo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtdescricao.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtdefeito.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtobservacao.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtlaudo.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                lblnumeroos.Text = "Número da OS: " + conta_venda;
                lblcodigovenda.Text = "Código pagamento: " + conta_venda; 

                try
                {


                    con.AbrirConexao();
                    sql = "SELECT * FROM detalhes_os WHERE cod_empresa = @cod_empresa AND cod_os = @cod_os";
                    MySqlCommand cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@cod_os", conta_venda);
                    cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);                    
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);                 

                   

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.Rows.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dataGridView2.Rows.Add(                                
                                dt.Rows[i]["cod_os"],
                                dt.Rows[i]["codigo"],
                                dt.Rows[i]["descricao"],
                                dt.Rows[i]["quantidade"],
                                dt.Rows[i]["preco_unitario"],
                                dt.Rows[i]["preco_total"]
                             
                            );


                        }
                        lblnumeroos.Text = "Número da OS: " + conta_venda;
                    }
                    else
                    {
                        dataGridView2.Rows.Clear();                       
                    }

                    con.FecharConexao();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                


                cbclientes.Enabled = true;                
                cbtecnico.Enabled = true;               
                cbstatus.Enabled = true;                
                dtinicial.Enabled = true;                
                dtfinal.Enabled = true;               
                txtgarantia.Enabled = true;                
                txttermo.Enabled = true;                
                txtdescricao.Enabled = true;               
                txtdefeito.Enabled = true;                
                txtobservacao.Enabled = true;                
                txtlaudo.Enabled = true;               
                cbservico.Enabled = true;                
                cbproduto.Enabled = true;                
                txtquantidades.Enabled = true;                
                txtquantidadep.Enabled = true;                
                btnadicionars.Enabled = true;
                btnadicionarp.Enabled = true;
                btnexcluirlista.Enabled = true;
                btnnovo.Enabled = false;
                btnadicionar.Enabled = false;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
                btncancelar.Enabled = true;
                btngerarpagamento.Enabled = false;
                
                cbclientes.Focus();
                
            }
          

        }















        #endregion

      
    }
}
