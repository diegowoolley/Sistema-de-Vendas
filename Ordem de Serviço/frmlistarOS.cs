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

namespace Sistema_de_Vendas.Ordem_de_Serviço
{
    public partial class frmlistarOS : Form
    {
        public frmlistarOS()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;


        private void frmlistarOS_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void frmlistarOS_Activated(object sender, EventArgs e)
        {
            listar();
        }

        #region MÉTODOS
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

        private void Pesquisar()
        {
            try
            {
                string pesquisa = cbclientes.Text;

                con.AbrirConexao();
                sql = "SELECT * FROM cad_os WHERE cod_empresa = @cod_empresa AND cliente LIKE @cliente AND status LIKE @status AND data_inicial BETWEEN @datainicial AND @datafinal ORDER BY cod_os ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cliente", "%" + pesquisa + "%");
                cmd.Parameters.AddWithValue("@status", cbstatus.Text);
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
                    MessageBox.Show("Ordem de serviço inexistente!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            formatargrid();
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

        #endregion

        #region BOTÕES


        private void btnpesquisar_Click(object sender, EventArgs e)
        {            
            Pesquisar();
        }

        private void btnadicionaros_Click(object sender, EventArgs e)
        {            
            frmOS FrmOS = new frmOS();
            FrmOS.ShowDialog();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            listar();
        }



        #endregion

        #region LEAVE

        private void cbclientes_Leave(object sender, EventArgs e)
        {
            if(cbclientes.Text.Trim() == "")
            {
                cbstatus.Focus();
                cbclientes.BackColor = Color.White;
                return;
            }
            Buscarclientes();
        }





        #endregion

       
    }
}
