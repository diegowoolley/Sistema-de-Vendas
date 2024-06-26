﻿using MySql.Data.MySqlClient;
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
    public partial class frmcadUsuarios : Form
    {
       

        public frmcadUsuarios()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;

        #region BOTÕES
        private void btnNovo_Click(object sender, EventArgs e)
        {
         //habilitar botões e campos
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            cbPermissoes.Enabled = true;
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            cbPermissoes.Text = "Administrador";
            txtNome.Focus();
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o usuário!");
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma senha para o usuário!");
                txtSenha.Clear();
                txtSenha.Focus();
                return;

            }
            else
            {       //verifica se o usuário já exite no banco de dados
                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_usuarios WHERE nome_usuarios = @usuario", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@usuario", txtNome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Usuário já cadastrado!");
                        txtNome.Clear();
                        txtSenha.Clear();
                        txtNome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                     //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_usuarios(nome_usuarios, senha_Usuarios, permissoes_Usuarios) VALUES (@nome_usuarios, @senha_Usuarios, @permissoes_Usuarios)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@nome_usuarios", txtNome.Text);
                        cmd.Parameters.AddWithValue("@senha_Usuarios", txtSenha.Text);
                        cmd.Parameters.AddWithValue("@permissoes_Usuarios", cbPermissoes.Text);
                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                     //desabilitar botões e campos
                        txtNome.Enabled = false;
                        txtNome.Clear();
                        txtSenha.Enabled = false;
                        txtSenha.Clear();
                        cbPermissoes.Enabled = false;
                        btnAdicionar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnNovo.Enabled = true;
                        MessageBox.Show("Usuário cadastado com sucesso!");
                        return;
                    }                    
                    }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar!" + ex);
                }
            
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region KEYPRESS
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSenha.Focus();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbPermissoes.Focus();
        }

        private void cbPermissoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtNome.Focus();
        }

        #endregion
    }
}
