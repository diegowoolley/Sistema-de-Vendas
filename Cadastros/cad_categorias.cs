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
    public partial class frmcad_categorias : Form
    {
        public frmcad_categorias()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string id;

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_categorias ORDER BY nome_categoria ASC";
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
            dgCliente.Columns[1].HeaderText = "Nome";
            dgCliente.Columns[0].Visible = false;

        }

        private void frmcad_categorias_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = true;
            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtnome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma Categoria!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }

            else
            {       //verifica se o usuário já exite no banco de dados

                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_categorias WHERE nome_categoria = @categoria", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@categoria", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Categoria já cadastrada!");
                        txtnome.Clear();
                        txtnome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_categorias(nome_categoria) VALUES (@categoria)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@categoria", txtnome.Text);



                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        //desabilitar botões e campos
                        txtnome.Enabled = false;
                        txtnome.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Categoria cadastada com sucesso!");
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
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma categoria!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
            else
            {
                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_categorias WHERE nome_categoria = @categoria", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@categoria", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Categoria já cadastrada!");
                        txtnome.Clear();


                        txtnome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {
                        con.AbrirConexao();
                        sql = "UPDATE cad_categorias SET nome_categoria = @nome WHERE cod_categoria = @id";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nome", txtnome.Text);

                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        Listar();

                        MessageBox.Show("Registro Alterado com Sucesso!!");
                        txtnome.Enabled = false;
                        txtnome.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Cadastrar!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_categorias WHERE cod_categoria = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();

                txtnome.Enabled = false;
                txtnome.Clear();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = false;
            txtnome.Clear();
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;



            btnNovo.Enabled = true;

            btnNovo.Focus();
            Listar();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                id = dgCliente.CurrentRow.Cells[0].Value.ToString();


                txtnome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                txtnome.Enabled = true;
                txtnome.Focus();
            }
        }
    }
}
