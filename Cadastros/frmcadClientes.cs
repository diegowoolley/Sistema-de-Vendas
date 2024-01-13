﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmcadClientes : Form
    {
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string foto;


        public frmcadClientes()
        {
            InitializeComponent();
        }
        
        private byte[] img()
        {
            byte[] image_byte = null;
            if (foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image_byte = br.ReadBytes((int)fs.Length);
            return image_byte;

        }
        private void Limparfoto()
        {
            pbFoto.Image = Properties.Resources.download;
            foto = "download.png";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //habilita campos e botões 
            txtnome.Enabled = true;
            txtdocumento.Enabled = true;
            txtendereco.Enabled = true;
            txtbairro.Enabled = true;
            txtnumero.Enabled = true;
            txtcidade.Enabled = true;
            cbestados.Enabled = true;
            txttelefone.Enabled = true;
            txtcelular.Enabled = true;
            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnfoto.Enabled = true;
            txtnome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o usuário!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
            if (txtdocumento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um documento para o usuário!");
                txtdocumento.Clear();
                txtdocumento.Focus();
                return;

            }
            else
            {       //verifica se o usuário já exite no banco de dados

                try
                {
                    con.AbrirConexao();
                    MySqlCommand cmdVerificar;
                    MySqlDataReader reader;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_clientes WHERE nome_clientes = @usuario", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@usuario", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cliente já cadastrado!");
                        txtnome.Clear();
                        txtdocumento.Clear();
                        txtendereco.Clear();
                        txtbairro.Clear();
                        txtnumero.Clear();
                        txttelefone.Clear();
                        txtcelular.Clear();

                        txtnome.Focus();
                        con.FecharConexao();
                        return;
                    }
                    else
                    {

                        //insere dados na tabela
                        con.AbrirConexao();
                        sql = "INSERT INTO cad_clientes(nome_clientes, documento_clientes, endereco_clientes, bairro_clientes, numero_clientes, cidade_clientes, estado_clientes, telefone_clientes, celular_clientes, foto_clientes) VALUES (@nome_clientes, @documento_clientes, @endereco_clientes, @bairro_clientes, @numero_clientes, @cidade_clientes, @estado_clientes, @telefone_clientes, @celular_clientes, @foto)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@nome_clientes", txtnome.Text);
                        cmd.Parameters.AddWithValue("@documento_clientes", txtdocumento.Text);
                        cmd.Parameters.AddWithValue("@endereco_clientes", txtendereco.Text);
                        cmd.Parameters.AddWithValue("@bairro_clientes", txtbairro.Text);
                        cmd.Parameters.AddWithValue("@numero_clientes", txtnumero.Text);
                        cmd.Parameters.AddWithValue("@cidade_clientes", txtcidade.Text);
                        cmd.Parameters.AddWithValue("@estado_clientes", cbestados.Text);
                        cmd.Parameters.AddWithValue("@telefone_clientes", txttelefone.Text);
                        cmd.Parameters.AddWithValue("@celular_clientes", txtcelular.Text);
                        cmd.Parameters.AddWithValue("@foto", img());

                        cmd.ExecuteNonQuery();
                        con.FecharConexao();
                        //desabilitar botões e campos
                        txtnome.Enabled = false;
                        txtnome.Clear();
                        txtdocumento.Enabled = false;
                        txtdocumento.Clear();
                        txtendereco.Enabled = false;
                        txtendereco.Clear();
                        txtbairro.Enabled = false;
                        txtbairro.Clear();
                        txtnumero.Enabled = false;
                        txtnumero.Clear();
                        txtcidade.Enabled = false;
                        txtcidade.Clear();
                        cbestados.Enabled = false;
                        txttelefone.Enabled = false;
                        txttelefone.Clear();
                        txtcelular.Enabled = false;
                        txtcelular.Clear();
                        btnAdicionar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnfoto.Enabled = false;
                        btnNovo.Enabled = true;
                        Limparfoto();
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Cliente cadastado com sucesso!");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar!" + ex);
                }

            }

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pbFoto.ImageLocation = foto;

            }
        }

        private void frmcadClientes_Load(object sender, EventArgs e)
        {
            Limparfoto();
            Listar();
            formatargrid();
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_clientes ORDER BY nome_clientes ASC";
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
            dgCliente.Columns[2].HeaderText = "Endereço";
            dgCliente.Columns[3].HeaderText = "Bairro";
            dgCliente.Columns[4].HeaderText = "Número";
            dgCliente.Columns[5].HeaderText = "Cidade";
            dgCliente.Columns[6].HeaderText = "Estado";
            dgCliente.Columns[7].HeaderText = "Telefone";
            dgCliente.Columns[8].HeaderText = "Celular";

           
            dgCliente.Columns[0].Visible = false;

        }


        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txttelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }
                               
        private void txtdocumento_Leave(object sender, EventArgs e)
        {
            string documento = txtdocumento.Text;
            if (txtdocumento.Text == "")
            {
                txtendereco.Focus();
            }
            else
            {
                if (documento.Length > 11)
                {
                    txtdocumento.Text = Convert.ToInt64(documento).ToString(@"00\.000\.000/0000-00");

                }
                else
                {
                    txtdocumento.Text = Convert.ToInt64(documento).ToString(@"000\.000\.000-00");
                }

            }
        }

        private void txtcelular_Leave(object sender, EventArgs e)
        {
            if (txtcelular.Text == "")
            {
                btnAdicionar.Focus();
            }
            else
            {

                string celular = txtcelular.Text;
                txtcelular.Text = Convert.ToUInt64(celular).ToString(@"\(00)00000-0000");
            }

        }

        private void txttelefone_Leave(object sender, EventArgs e)
        {
            if (txttelefone.Text == "")
            {
                txtcelular.Focus();
            }
            else
            {
                string telefone = txttelefone.Text;
                txttelefone.Text = Convert.ToUInt64(telefone).ToString(@"\(00)00000-0000");
            }
        }

        private void txtdocumento_Enter(object sender, EventArgs e)
        {
            var documento = txtdocumento.Text.Replace(".", "").Replace("/", "").Replace("-", "");
            txtdocumento.Text = documento;
            
        }

        private void txttelefone_Enter(object sender, EventArgs e)
        {
            var telefone = txtcelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            txttelefone.Text = telefone;

        }

        private void txtcelular_Enter(object sender, EventArgs e)
        {
            var celular = txtcelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            txtcelular.Text = celular;
            
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                txtnome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                txtdocumento.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
                txtendereco.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
                txtbairro.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
                txtnumero.Text = dgCliente.CurrentRow.Cells[5].Value.ToString();
                txtcidade.Text = dgCliente.CurrentRow.Cells[6].Value.ToString();
                cbestados.Text = dgCliente.CurrentRow.Cells[7].Value.ToString();
                txttelefone.Text = dgCliente.CurrentRow.Cells[8].Value.ToString();
                txtcelular.Text = dgCliente.CurrentRow.Cells[9].Value.ToString();

                btnNovo.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnfoto.Enabled = true;
                txtnome.Enabled = true;
                txtdocumento.Enabled = true;
                txtendereco.Enabled = true;
                txtbairro.Enabled = true;
                txtnumero.Enabled = true;
                txtcidade.Enabled = true;
                cbestados.Enabled = true;
                txttelefone.Enabled = true;
                txtcelular.Enabled = true;
                txtnome.Focus();


                if (dgCliente.CurrentRow.Cells[10].Value != DBNull.Value)
                {
                    byte[] image = (byte[])dgCliente.Rows[e.RowIndex].Cells[10].Value;
                    MemoryStream es = new MemoryStream(image);
                    pbFoto.Image = Image.FromStream(es);

                }
                else
                {
                    pbFoto.Image = Properties.Resources.download;
                }


                

                
            }
           

        }
    }
}
