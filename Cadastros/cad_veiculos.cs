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
    public partial class cad_veiculos : Form
    {
        public cad_veiculos()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string id;

        private void cad_veiculos_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_veiculos ORDER BY placa ASC";
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
            dgCliente.Columns[1].HeaderText = "Marca";
            dgCliente.Columns[2].HeaderText = "Modelo";
            dgCliente.Columns[3].HeaderText = "Placa";
            dgCliente.Columns[4].HeaderText = "Km";
            dgCliente.Columns[0].Visible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtmarca.Enabled = true;
            txtmodelo.Enabled = true;
            txtplaca.Enabled = true;
            txtkm.Enabled = true;
            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtmarca.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma Placa!");
                txtplaca.Clear();
                txtplaca.Focus();
                return;
            }

            else
            {       //verifica se o usuário já exite no banco de dados

                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_veiculos WHERE placa = @placa", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@placa", txtplaca.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Placa já cadastrada!");
                        txtplaca.Clear();
                        txtplaca.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_veiculos(marca, modelo, placa, km) VALUES (@marca, @modelo, @placa, @km)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@marca", txtmarca.Text);
                        cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                        cmd.Parameters.AddWithValue("@placa", txtplaca.Text);
                        cmd.Parameters.AddWithValue("@km", txtkm.Text);



                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        //desabilitar botões e campos
                        txtmarca.Enabled = false;
                        txtmarca.Clear();
                        txtmodelo.Enabled = false;
                        txtmodelo.Clear();
                        txtplaca.Enabled = false;
                        txtplaca.Clear();
                        txtkm.Enabled = false;
                        txtkm.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = true;
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Veículo cadastado com sucesso!");
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
            if (txtplaca.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma placa!");
                txtplaca.Clear();
                txtplaca.Focus();
                return;
            }



            try
            {

                con.AbrirConexao();
                sql = "UPDATE cad_veiculos SET marca = @marca, modelo = @modelo, placa = @placa, km = @km WHERE cod_veiculo = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@marca", txtmarca.Text);
                cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                cmd.Parameters.AddWithValue("@placa", txtplaca.Text);
                cmd.Parameters.AddWithValue("@km", txtkm.Text);

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Alterado com Sucesso!!");
                txtmarca.Enabled = false;
                txtmarca.Clear();
                txtmodelo.Enabled = false;
                txtmodelo.Clear();
                txtplaca.Enabled = false;
                txtplaca.Clear();
                txtkm.Enabled = false;
                txtkm.Clear();
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
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_veiculos WHERE cod_veiculo = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();

                txtmarca.Enabled = false;
                txtmarca.Clear();
                txtmodelo.Enabled = false;  
                txtmodelo.Clear();
                txtplaca.Enabled=false;
                txtplaca.Clear();
                txtkm.Enabled=false;
                txtkm.Clear();
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


                txtmarca.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                txtmodelo.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
                txtplaca.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
                txtkm.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                txtmarca.Enabled = true;
                txtmodelo.Enabled = true;
                txtplaca.Enabled = true;
                txtkm.Enabled = true;
                txtmarca.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtmarca.Enabled = false;
            txtmarca.Clear();
            txtmodelo.Enabled = false;
            txtmodelo.Clear();
            txtplaca.Enabled = false;
            txtplaca.Clear();
            txtkm.Enabled = false;
            txtkm.Clear();
            btnNovo.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtmarca.Focus();
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtmodelo.Focus();
        }

        private void txtplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtkm.Focus();
        }

        private void txtmodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtplaca.Focus();
        }
    }
}
