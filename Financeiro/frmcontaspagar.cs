﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Vendas.Financeiro
{
    public partial class frmcontaspagar : Form
    {
        public frmcontaspagar()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        int cod_venda;


        private void frmcontaspagar_Load(object sender, EventArgs e)
        {
            Listar();
            formatargridestoque();
        }

        private void frmcontaspagar_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        #region MÉTODOS
        private void Listar()
        {
            try
            {


                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND (tipo = 'COMPRA' or tipo = 'DESPESA FUNCIONÁRIOS' or tipo ='DESPESA PATRIMONIAL' or tipo = 'TERCEIRIZAÇÃO' or tipo = 'IMPOSTOS' or tipo = 'DESPESA ESTOQUE') AND DATE(data) = CURDATE() ORDER BY cod_venda ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string vencimentoStr = row.Cells["Vencimento"].Value.ToString();
                    string paga = row.Cells["Status"].Value.ToString();

                    if (row.Cells["Status"].Value.ToString() == "À PAGAR")
                    {
                        
                        row.Cells["Status"].Style.BackColor = Color.Yellow;
                    }
                    if (row.Cells["Status"].Value.ToString() == "PAGA")
                    {

                        row.Cells["Status"].Style.BackColor = Color.Green;
                    }            

                    if (DateTime.TryParse(vencimentoStr, out DateTime vencimento))
                    {
                        if (vencimento < DateTime.Now.Date && paga != "PAGA")
                        {
                            row.Cells["Vencimento"].Style.BackColor = Color.Red;
                            
                        }
                        
                    }

                    if (DateTime.TryParse(vencimentoStr, out DateTime vencimentoproximo))
                    {
                        
                        DateTime dataAtual = DateTime.Now.Date;

                        
                        DateTime dataLimite = dataAtual.AddDays(10);

                        if (vencimentoproximo >= dataAtual && vencimentoproximo <= dataLimite && paga != "PAGA")
                        {
                           
                            row.Cells["Vencimento"].Style.BackColor = Color.Yellow;
                        }
                    }

                }
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                formatargridestoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        private void Buscar()
        {
            try
            {
                string pesquisa = cbcliente.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM caixa WHERE cod_empresa = @cod_empresa AND tipo = @tipo AND (cliente LIKE @cliente or favorecido LIKE @cliente) AND data BETWEEN @datainicial AND @datafinal ORDER BY cod_venda ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cliente", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@tipo", cbtipo.Text);
                cmd.Parameters.AddWithValue("@datainicial", Convert.ToDateTime(dtinicial.Text));
                cmd.Parameters.AddWithValue("@datafinal", Convert.ToDateTime(dtfinal.Text));
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);                
                dataGridView1.DataSource = dt;
                con.FecharConexao();
                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Transação inexistente!");                   

                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string vencimentoStr = row.Cells["Vencimento"].Value.ToString();
                    string paga = row.Cells["Status"].Value.ToString();

                    if (row.Cells["Status"].Value.ToString() == "À PAGAR")
                    {
                        row.Cells["Status"].Style.BackColor = Color.Yellow;
                    }

                    if (row.Cells["Status"].Value.ToString() == "PAGA")
                    {
                        row.Cells["Status"].Style.BackColor = Color.Green;
                    }

                    if (DateTime.TryParse(vencimentoStr, out DateTime vencimento))
                    {
                        if (vencimento < DateTime.Now.Date && paga != "PAGA")
                        {
                            row.Cells["Vencimento"].Style.BackColor = Color.Red;
                        }
                    }

                    if (DateTime.TryParse(vencimentoStr, out DateTime vencimentoproximo))
                    {

                        DateTime dataAtual = DateTime.Now.Date;
                        DateTime dataLimite = dataAtual.AddDays(10);

                        if (vencimentoproximo >= dataAtual && vencimentoproximo <= dataLimite && paga != "PAGA")
                        {
                            row.Cells["Vencimento"].Style.BackColor = Color.Yellow;
                        }
                    }

                }
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            if(cbtipo.Text == "DESPESA ESTOQUE" || cbtipo.Text == "COMPRA")
            {                                
                formatargridestoque();
            }
            else
            {                              
                formatargrid();
               
            }

        }

        private void buscarcliente()
        {

            try
            {
                string pesquisa = cbcliente.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_clientes WHERE cod_empresa = @cod_empresa AND nome_clientes LIKE @nome";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");                
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbcliente.DataSource = dt;
                cbcliente.DisplayMember = "nome_clientes";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    con.FecharConexao();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void formatargridestoque()
        {

            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Número nota";
            dataGridView1.Columns[2].HeaderText = "Tipo";
            dataGridView1.Columns[3].HeaderText = "Cliente";
            dataGridView1.Columns[4].HeaderText = "Vendedor";
            dataGridView1.Columns[5].HeaderText = "Desconto";
            dataGridView1.Columns[6].HeaderText = "Total pago";
            dataGridView1.Columns[7].HeaderText = "Valor Total";
            dataGridView1.Columns[8].HeaderText = "Forma de pagamento";
            dataGridView1.Columns[9].HeaderText = "Data";
            dataGridView1.Columns[10].HeaderText = "Hora";
            dataGridView1.Columns[10].Visible = false;           
            dataGridView1.Columns[11].HeaderText = "Dinheiro";
            dataGridView1.Columns[12].HeaderText = "Pix";
            dataGridView1.Columns[13].HeaderText = "Cartão";       
            dataGridView1.Columns[14].HeaderText = "Vencimento";
            dataGridView1.Columns[15].HeaderText = "Taxa";
            dataGridView1.Columns[16].HeaderText = "Código da empresa";
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Status";
            dataGridView1.Columns[18].HeaderText = "Favorecido";
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].HeaderText = "Documento";
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].HeaderText = "Descrição";
            dataGridView1.Columns[20].Visible = false;




        }

        private void formatargrid()
        {

            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Número nota";
            dataGridView1.Columns[1].DisplayIndex = 0;
            dataGridView1.Columns[2].HeaderText = "Tipo";
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[3].HeaderText = "Cliente";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Vendedor";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Desconto";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Total pago";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Valor Total";
            dataGridView1.Columns[7].DisplayIndex = 5;
            dataGridView1.Columns[8].HeaderText = "Forma de pagamento";
            dataGridView1.Columns[8].DisplayIndex = 6;
            dataGridView1.Columns[9].HeaderText = "Data";
            dataGridView1.Columns[9].DisplayIndex = 9;
            dataGridView1.Columns[10].HeaderText = "Hora";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Dinheiro";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "Pix";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].HeaderText = "Cartão";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].HeaderText = "Vencimento";
            dataGridView1.Columns[14].DisplayIndex = 7;
            dataGridView1.Columns[15].HeaderText = "Taxa";
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].HeaderText = "Código da empresa";
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Status";
            dataGridView1.Columns[17].DisplayIndex = 8;
            dataGridView1.Columns[18].HeaderText = "Favorecido";
            dataGridView1.Columns[18].DisplayIndex = 4;
            dataGridView1.Columns[19].HeaderText = "Documento";
            dataGridView1.Columns[19].DisplayIndex = 2;
            dataGridView1.Columns[20].HeaderText = "Descrição";
            dataGridView1.Columns[20].DisplayIndex = 3;




        }


        #endregion

        #region BOTÕES

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (dtinicial.Value.Date > dtfinal.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final!");
                dtinicial.Focus();
                return;
            }
            dataGridView1.Columns.Clear();           
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            frmcaddespesas frmdespesas = new frmcaddespesas();
            frmdespesas.ShowDialog();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM caixa WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", cod_venda);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();
                cbtipo.SelectedIndex = -1;
                cbcliente.Text = "";
                dtinicial.Value = DateTime.Now;
                dtfinal.Value = DateTime.Now;
                cbtipo.Focus();
            }
            else
            {
                Listar();
            }

        }


        #endregion

        #region KEYPRESS \ LEAVE

        private void cbcliente_Leave(object sender, EventArgs e)
        {
            if (cbcliente.Text.Trim() == "")
            {
                dtinicial.Focus();
                return;
            }
            buscarcliente();
        }

        private void cbcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                dtinicial.Focus();
        }               

        private void cbtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
               cbcliente.Focus();
        }

       

        #endregion

        #region DATAGRID

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                cod_venda = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());               
              
            }
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod_venda = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (dataGridView1.CurrentRow.Cells["Status"].Value.ToString() != "PAGA")
            {
                DialogResult result = MessageBox.Show("Deseja informar pagamento de número:" + cod_venda + "?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "UPDATE caixa SET status = 'PAGA', valor_pago = valor_total WHERE cod_venda = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", cod_venda);


                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    Listar();

                    MessageBox.Show("Registro Alterado com Sucesso!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Este documento já foi pago!");
            }
        }


        #endregion

       
    }

}

