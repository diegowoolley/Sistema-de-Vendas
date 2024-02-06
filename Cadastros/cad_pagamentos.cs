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

namespace Sistema_de_Vendas.Cadastros
{
    public partial class cad_pagamentos : Form
    {
        public cad_pagamentos()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string id;

        private void cad_pagamentos_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_pagamentos ORDER BY forma_pagamento ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCliente.DataSource = dt;
            con.FecharConexao();
        }


        private void formatargrid()
        {
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[1].HeaderText = "Forma de Pagamento";
            dgCliente.Columns[0].Visible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtpagamento.Enabled = true;
            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtpagamento.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtpagamento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma Forma de Pagamento!");
                txtpagamento.Clear();
                txtpagamento.Focus();
                return;
            }

            else
            {       //verifica se o usuário já exite no banco de dados

                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_pagamentos WHERE forma_pagamento = @pagamento", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@pagamento", txtpagamento.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Forma de pagamento já cadastrado!");
                        txtpagamento.Clear();
                        txtpagamento.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_pagamentos(forma_pagamento) VALUES (@pagamento)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@pagamento", txtpagamento.Text);



                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        //desabilitar botões e campos
                        txtpagamento.Enabled = false;
                        txtpagamento.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Forma de Pagamento cadastada com sucesso!");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar!" + ex);
                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            if (txtpagamento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma forma de pagamento!");
                txtpagamento.Clear();
                txtpagamento.Focus();
                return;
            }


            
            try
            {

                con.AbrirConexao();
                sql = "UPDATE cad_pagamentos SET forma_pagamento = @pagamento WHERE cod_pagamento = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pagamento", txtpagamento.Text);

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Alterado com Sucesso!!");
                txtpagamento.Enabled = false;
                txtpagamento.Clear();
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnNovo.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar!");

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                      
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Forma de Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_pagamentos WHERE cod_pagamento = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();

                txtpagamento.Enabled = false;
                txtpagamento.Clear();
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
            else
            {
                Listar();
            }
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                              

                id = dgCliente.CurrentRow.Cells[0].Value.ToString();


                txtpagamento.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                txtpagamento.Enabled = true;
                txtpagamento.Focus();
                if (txtpagamento.Text.Trim() == "DINHEIRO" || txtpagamento.Text.Trim() == "PIX" || txtpagamento.Text.Trim() == "CARTÃO DE CRÉDITO" || txtpagamento.Text.Trim() == "CARTÃO DE DÉBITO" || txtpagamento.Text.Trim() == "FRACIONADO")
                {

                    txtpagamento.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled=false;


                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtpagamento.Enabled = false;
            txtpagamento.Clear();
            btnNovo.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
