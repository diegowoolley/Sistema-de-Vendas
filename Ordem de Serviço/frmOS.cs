using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        MySqlCommand cmd;
        int cod_venda;
        int cod_os = 0;

        private void frmOS_Load(object sender, EventArgs e)
        {
            contarOS();
            listar();
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
                  
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
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
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contarOS()
        {
            cod_venda = 0;
            try
            {
                con.AbrirConexao();
                sql = "SELECT MAX(cod_os) FROM cad_os";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    if (val == "")
                    {
                        cod_venda = 1;
                        lblnumeroos.Text = "Número da OS: " + cod_venda;
                    }
                    else
                    {

                        cod_venda = int.Parse(dr[0].ToString());
                        cod_venda = cod_venda + 1;
                        lblnumeroos.Text = "Número da OS: " + cod_venda.ToString();
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
                sql = "SELECT * FROM cad_os WHERE cod_empresa = @cod_empresa ORDER BY id asc";
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

        private void formatargriddetalhes()
        {
            
            dataGridView2.Columns[0].HeaderText = "Id";
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Código";           
            dataGridView2.Columns[2].HeaderText = "Descrição";
            dataGridView2.Columns[3].HeaderText = "Quantidade";            
            dataGridView2.Columns[4].HeaderText = "Código empresa";
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].HeaderText = "Preço Unitário";
            dataGridView2.Columns[6].HeaderText = "Valor total";

        }

        private void retornargrid()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM detalhes_os WHERE cod_empresa = @cod_empresa AND cod_os = @cod_os ORDER BY cod_os ASC";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_os", cod_os);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.FecharConexao();
                dataGridView2.DataSource = dt;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            formatargriddetalhes();
        }
        #endregion

        #region KEYPRESS \ LEAVE
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
            btnnovo.Focus();
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
                cmd.Parameters.AddWithValue("@cod_os", cod_venda);
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

                cmd.ExecuteNonQuery();
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
                contarOS();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_os WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", cod_os);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
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

        private void btnadicionars_Click(object sender, EventArgs e)
        {
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

                    dataGridView2.Rows.Add(r["cod_servico"], r["descricao"], txtquantidades.Text, r["valor"], preco);
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
                            cbservico.Text = "";
                            txtquantidadep.Text = "";
                            cbservico.Focus();
                            return;
                        }
                    }
                    double preco = double.Parse(txtquantidadep.Text.ToString()) * double.Parse(r["valor_venda"].ToString());

                    dataGridView2.Rows.Add(r["cod_produto"], r["nome_produto"], txtquantidadep.Text, r["valor_venda"], preco);
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


        #endregion

        #region DATAGRID

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                cod_os = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

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
