using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Vendas
{
    public partial class frmcadfornecedores: Form
    {
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string foto;
        string id;
        string alterou_foto = "n";
        string documentoantigo;
        


        public frmcadfornecedores()
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

        private void Buscar()
        {
            string fornecedor = txtpesquisa.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_fornecedores WHERE nome_fornecedor LIKE @nome or documento_fornecedor LIKE @documento";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + fornecedor + "%");
            cmd.Parameters.AddWithValue("@documento", "%" + fornecedor + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCliente.DataSource = dt;
            con.FecharConexao();

            formatargrid();

        }
     
        private void Limparfoto()
        {
            pbFoto.Image = Properties.Resources.download;
            foto = "download.png";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

            btnfoto.Enabled = false;
            btnNovo.Enabled = true;
            Limparfoto();
            btnNovo.Focus();
            Listar();
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
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            btnfoto.Enabled = true;
            txtnome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o fornecedor!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
            if (txtdocumento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um documento para o fornecedor!");
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
                    cmdVerificar = new MySqlCommand("SELECT * FROM cad_fornecedores WHERE nome_fornecedor = @usuario", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@usuario", txtnome.Text);
                    reader = cmdVerificar.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Fornecedor já cadastrado!");
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
                        sql = "INSERT INTO cad_fornecedores(nome_fornecedor, documento_fornecedor, endereco_fornecedor, bairro_fornecedor, numero_fornecedor, cidade_fornecedor, estado_fornecedor, telefone_fornecedor, celular_fornecedor, foto_fornecedor) VALUES (@nome_clientes, @documento_clientes, @endereco_clientes, @bairro_clientes, @numero_clientes, @cidade_clientes, @estado_clientes, @telefone_clientes, @celular_clientes, @foto)";
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

                        btnfoto.Enabled = false;
                        btnNovo.Enabled = true;
                        Limparfoto();
                        btnNovo.Focus();
                        Listar();

                        MessageBox.Show("Fornecedor cadastado com sucesso!");
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
                alterou_foto = "s";

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
            sql = "SELECT * FROM cad_fornecedores ORDER BY nome_fornecedor ASC";
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
            dgCliente.Columns[2].HeaderText = "Documento";
            dgCliente.Columns[3].HeaderText = "Endereço";
            dgCliente.Columns[4].HeaderText = "Bairro";
            dgCliente.Columns[5].HeaderText = "Número";
            dgCliente.Columns[6].HeaderText = "Cidade";
            dgCliente.Columns[7].HeaderText = "Estado";
            dgCliente.Columns[8].HeaderText = "Telefone";
            dgCliente.Columns[9].HeaderText = "Celular";
            dgCliente.Columns[10].HeaderText = "Foto";


            dgCliente.Columns[0].Visible = false;

        }


        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
            string telefone = txttelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
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
                id = dgCliente.CurrentRow.Cells[0].Value.ToString();
                documentoantigo = dgCliente.CurrentRow.Cells[2].Value.ToString();

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
                btnAdicionar.Enabled = false;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o fornecedor!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
            if (txtdocumento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um documento para o fornecedor!");
                txtdocumento.Clear();
                txtdocumento.Focus();
                return;

            }
            else
            {


                if (alterou_foto == "s")
                {
                    con.AbrirConexao();
                    sql = "UPDATE cad_fornecedores SET nome_fornecedor = @nome, documento_fornecedor = @documento, endereco_fornecedor = @endereco, bairro_fornecedor = @bairro, numero_fornecedor = @numero, cidade_fornecedor = @cidade, estado_fornecedor = @estado, telefone_fornecedor = @telefone, celular_fornecedor = @celular, foto_fornecedor = @foto WHERE cod_fornecedor = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
                    cmd.Parameters.AddWithValue("@numero", txtnumero.Text);
                    cmd.Parameters.AddWithValue("@cidade", txtcidade.Text);
                    cmd.Parameters.AddWithValue("@estado", cbestados.Text);
                    cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    cmd.Parameters.AddWithValue("@celular", txtcelular.Text);
                    cmd.Parameters.AddWithValue("@foto", img());

                }
                else if (alterou_foto == "n")
                {
                    con.AbrirConexao();
                    sql = "UPDATE cad_fornecedores SET nome_fornecedor = @nome, documento_fornecedor = @documento, endereco_fornecedor = @endereco, bairro_fornecedor = @bairro, numero_fornecedor = @numero, cidade_fornecedor = @cidade, estado_fornecedor = @estado, telefone_fornecedor = @telefone, celular_fornecedor = @celular WHERE cod_fornecedor=@id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
                    cmd.Parameters.AddWithValue("@numero", txtnumero.Text);
                    cmd.Parameters.AddWithValue("@cidade", txtcidade.Text);
                    cmd.Parameters.AddWithValue("@estado", cbestados.Text);
                    cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    cmd.Parameters.AddWithValue("@celular", txtcelular.Text);

                }
                if (txtdocumento.Text != documentoantigo)
                {
                    MySqlCommand cmdverificar;
                    cmdverificar = new MySqlCommand("SELECT * FROM cad_fornecedores WHERE documento_fornecedor = @documento", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdverificar;
                    cmdverificar.Parameters.AddWithValue("@documento", txtdocumento.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Documento já Cadastrado!");
                        txtdocumento.Clear();
                        txtdocumento.Focus();
                        return;

                    }

                }
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();


                MessageBox.Show("Registro Alterado com Sucesso!!");
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

                btnfoto.Enabled = false;
                btnNovo.Enabled = true;
                Limparfoto();
                btnNovo.Focus();
                alterou_foto = "n";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_fornecedores WHERE cod_fornecedor = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Limparfoto();
                Listar();
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
                btnfoto.Enabled = false;
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
            else
            {
                Listar();
            }
        }      
       

        private void lblpesquisa_DoubleClick(object sender, EventArgs e)
        {
            pnpesquisa.Visible = true;
            txtpesquisa.Enabled = true;
            txtpesquisa.Clear();           
            btncancelarpesquisa.Enabled = true;
            txtpesquisa.Focus();
        }

        private void pnpesquisa_Leave(object sender, EventArgs e)
        {
            pnpesquisa.Visible = false;
        }

        private void txtnomepesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }                

       
        private void btncancelarpesquisa_Click(object sender, EventArgs e)
        {
            pnpesquisa.Visible = false;
        }              
    }
}
