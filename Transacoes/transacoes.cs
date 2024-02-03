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
    public partial class transacoes : Form
    {
        public transacoes()
        {
            InitializeComponent();

        }


        conn con = new conn();
        string tipo = "";
        string sql;
        MySqlCommand cmd;


        private void Listar()
        {
            try
            {            
                con.AbrirConexao();
                sql = "SELECT * FROM caixa ORDER BY cod_venda ASC";                
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void Buscar()
        {
            string pesquisa = txtpesquisa.Text;          
                      
            con.AbrirConexao();
            sql = "SELECT * FROM caixa WHERE cliente LIKE @cliente or cod_venda LIKE @cod_venda AND tipo LIKE @tipo";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cliente", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_venda", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@tipo", "%" + cbtransacao.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.FecharConexao();
            if(dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Transação inexistente!");

            }




        }

        private void formatargrid()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Código venda";
            dataGridView1.Columns[2].HeaderText = "Tipo da Transação";
            dataGridView1.Columns[3].HeaderText = "Cliente";            
            dataGridView1.Columns[4].HeaderText = "Vendedor";       
            dataGridView1.Columns[5].HeaderText = "Descontos";
            dataGridView1.Columns[6].HeaderText = "Valor pago";
            dataGridView1.Columns[7].HeaderText = "Valor total";
            dataGridView1.Columns[8].HeaderText = "Forma de pagamento";                     
            dataGridView1.Columns[9].HeaderText = "Data";
            dataGridView1.Columns[10].HeaderText = "Hora";

            dataGridView1.Columns[0].Visible = false;
      

        }

        private void transacoes_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
            
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cbtransacao.SelectedIndex = -1;
            txtpesquisa.Clear();
            
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
