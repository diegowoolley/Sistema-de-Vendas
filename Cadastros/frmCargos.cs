﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Cadastros
{
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string id;

        private void frmCargos_Load(object sender, EventArgs e)
        {
            Listar();
            formatargrid();
        }

        #region MÉTODOS

        private void Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_cargos WHERE cod_empresa = @cod_empresa ORDER BY nome_cargo ASC";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgCliente.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
          
        }

        private void formatargrid()
        {
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[1].HeaderText = "Nome";
            dgCliente.Columns[0].Visible = false;
            dgCliente.Columns[2].HeaderText = "Código da empresa";
            dgCliente.Columns[2].Visible = false;

        }

        #endregion

        #region BOTÕES

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
                MessageBox.Show("Digite um Cargo!");
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
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_cargos WHERE cod_empresa = @cod_empresa AND nome_cargo = @cargo", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                    cmdVerificar.Parameters.AddWithValue("@cargo", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cargo já cadastrado!");
                        txtnome.Clear();
                        txtnome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_cargos(nome_cargo, cod_empresa) VALUES (@cargo, @cod_empresa)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@cargo", txtnome.Text);
                        cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);



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

                        MessageBox.Show("Cargo cadastado com sucesso!");
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
                MessageBox.Show("Digite um Cargo!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
                   
                       
                       
            try
            {
                    
                        con.AbrirConexao();
                        sql = "UPDATE cad_cargos SET nome_cargo = @nome WHERE cod_cargo = @id";
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
            catch (Exception)
            {
                    MessageBox.Show("Erro ao Cadastrar!");
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM cad_cargos WHERE cod_cargo = @id";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        #endregion

        #region DATAGRID

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

        #endregion
    }
}


