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

namespace Sistema_de_Vendas
{
    public partial class frmescolhaempresa : Form
    {
        public frmescolhaempresa()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;       
        MySqlCommand cmd;
        

        private void frmescolhaempresa_Load(object sender, EventArgs e)
        {
           
                try
                {
                    con.AbrirConexao();
                    sql = "SELECT * FROM cad_empresas ORDER BY nome asc";
                    cmd = new MySqlCommand(sql, con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                  
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "nome";
                    con.FecharConexao();
              

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na Conexão", ex.Message);
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_empresas WHERE nome = @nome ORDER BY nome asc";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", comboBox1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);
                funcoes.cod_empresa = int.Parse(dt.Rows[0]["cod"].ToString());
                con.FecharConexao();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão", ex.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmescolhaempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                button1.Focus(); 
        }
    }
}
