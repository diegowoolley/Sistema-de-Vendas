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

namespace Sistema_de_Vendas.Configuracoes
{
    public partial class frmlimpartabelas : Form
    {
        public frmlimpartabelas()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;

        private void btnlimparvendas_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todas as suas transações?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE vendas";
                    cmd = new MySqlCommand(sql, con.con);                    
                    cmd.ExecuteNonQuery();

                    sql = "TRUNCATE TABLE caixa";
                    cmd = new MySqlCommand(sql, con.con);                    
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE vendas AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE caixa AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transações excluidas com sucesso!");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
