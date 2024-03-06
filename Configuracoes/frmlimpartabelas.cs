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

        #region BOTÕES
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

        private void btnlimparos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todas as suas OS's?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_os";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "TRUNCATE TABLE detalhes_os";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_os AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE detalhes_os AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("OS's excluidas com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os clientes?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_clientes";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_clientes AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Clientes excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os produtos?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_produtos";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_produtos AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Produtos excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todas as categorias?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_categorias";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_categorias AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Categorias excluidas com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os fornecedores?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_fornecedores";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_fornecedores AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Fornecedores excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os funcionários?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_funcionarios";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_funcionarios AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Funcionários excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btntransportadoras_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todas as transportadoras?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_transportadoras";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_transportadoras AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Transportadoras excluidas com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnveiculos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os veículos?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_veiculos";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_veiculos AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Veículos excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnservicos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os serviços?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_servicos";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_servicos AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Serviços excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btncargos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os cargos?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_cargos";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_cargos AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Cargos excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir todos os Usuários?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "TRUNCATE TABLE cad_usuarios";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    sql = "ALTER TABLE cad_usuarios AUTO_INCREMENT = 0";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.ExecuteNonQuery();

                    con.FecharConexao();
                    MessageBox.Show("Usuários excluidos com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion


    }
}
