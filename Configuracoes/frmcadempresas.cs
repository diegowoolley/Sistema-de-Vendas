using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Configuracoes
{
    public partial class frmcadempresas : Form
    {
        public frmcadempresas()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string foto;
        string id;
        string alterou_foto = "n";
        string documentoantigo;

        private void frmcadempresas_Load(object sender, EventArgs e)
        {
            Limparfoto();
            Listar();
            formatargrid();
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
            try
            {
                string fornecedor = txtpesquisa.Text;
                con.AbrirConexao();
                sql = "SELECT * FROM cad_empresas WHERE nome LIKE @nome or documento LIKE @documento";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
     

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
            txtemail.Enabled = false;
            txtemail.Clear();
            txtinscricao.Enabled = false;
            txtinscricao.Clear();
            txtendereco.Enabled = false;
            txtendereco.Clear();
            txtbairro.Enabled = false;
            txtbairro.Clear();
            txtnumero.Enabled = false;
            txtnumero.Clear();
            txtcidade.Enabled = false;
            txtcidade.Clear();
            cbestados.Enabled = false;
            cbestados.SelectedIndex = -1;
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
            txtnome.Enabled = true;
            txtdocumento.Enabled = true;
            txtemail.Enabled = true;
            txtinscricao.Enabled = true;
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
                MessageBox.Show("Digite um nome para a Empresa!");
                txtnome.Clear();
                txtnome.Focus();
                return;
            }
            if (txtdocumento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um documento para a Empresa!");
                txtdocumento.Clear();
                txtdocumento.Focus();
                return;

            }




            if (txtemail.Text.Contains("@"))
            {
                txtemail.Focus();
            }
            else
            {
                MessageBox.Show("E-mail inválido!");
                txtemail.Clear();
                txtemail.Focus();
                return;
            }


            //verifica se o usuário já exite no banco de dados

            try
            {
                con.AbrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM cad_empresas WHERE documento = @documento", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@documento", txtdocumento.Text);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Documento já cadastrado!");

                    txtdocumento.Clear();
                    txtdocumento.Focus();
                    con.FecharConexao();
                    return;
                }
                else
                {

                    //insere dados na tabela
                    con.AbrirConexao();
                    sql = "INSERT INTO cad_empresas(nome, documento, endereco, bairro, numero, cidade, estado, telefone, celular, foto, email, inscricao) VALUES (@nome_clientes, @documento_clientes, @endereco_clientes, @bairro_clientes, @numero_clientes, @cidade_clientes, @estado_clientes, @telefone_clientes, @celular_clientes, @foto, @email, @inscricao)";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@nome_clientes", txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento_clientes", txtdocumento.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@inscricao", txtinscricao.Text);
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
                    txtemail.Enabled = false;
                    txtemail.Clear();
                    txtinscricao.Enabled = false;
                    txtinscricao.Clear();
                    txtendereco.Enabled = false;
                    txtendereco.Clear();
                    txtbairro.Enabled = false;
                    txtbairro.Clear();
                    txtnumero.Enabled = false;
                    txtnumero.Clear();
                    txtcidade.Enabled = false;
                    txtcidade.Clear();
                    cbestados.Enabled = false;
                    cbestados.SelectedIndex = -1;
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

                    MessageBox.Show("Empresa cadastada com sucesso!");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar!" + ex);
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

        private void Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_empresas ORDER BY nome ASC";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgCliente.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
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
            dgCliente.Columns[10].Visible = false;
            dgCliente.Columns[11].HeaderText = "E-mail";
            dgCliente.Columns[12].HeaderText = "Inscrição Estadual";


            dgCliente.Columns[0].Visible = false;

        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtemail.Focus();
        }

        private void txttelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtcelular.Focus();
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtnome.Focus();
        }

        private void txtdocumento_Leave(object sender, EventArgs e)
        {
            string documento = txtdocumento.Text;
            if (txtdocumento.Text == "")
            {
                txtemail.Focus();
            }
            else
            {

                txtdocumento.Text = Convert.ToInt64(documento).ToString(@"00\.000\.000/0000-00");


            }
        }

        private void txtcelular_Leave(object sender, EventArgs e)
        {
            if (txtcelular.Text == "")
            {
                txtnome.Focus();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Digite um nome para a Empresa!");
                    txtnome.Clear();
                    txtnome.Focus();
                    return;
                }
                if (txtdocumento.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Digite um documento para a Empresa!");
                    txtdocumento.Clear();
                    txtdocumento.Focus();
                    return;

                }



                if (txtemail.Text.Contains("@"))
                {
                    txtemail.Focus();
                }
                else
                {
                    MessageBox.Show("E-mail inválido!");
                    txtemail.Clear();
                    txtemail.Focus();
                    return;
                }

                if (alterou_foto == "s")
                {
                    con.AbrirConexao();
                    sql = "UPDATE cad_empresas SET nome = @nome, documento = @documento, endereco = @endereco, bairro = @bairro, numero = @numero, cidade = @cidade, estado = @estado, telefone = @telefone, celular = @celular, foto = @foto, email = @email, inscricao = @inscricao WHERE cod = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);
                    cmd.Parameters.AddWithValue("@inscricao", txtinscricao.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
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
                    sql = "UPDATE cad_empresas SET nome = @nome, documento = @documento, endereco = @endereco, bairro = @bairro, numero = @numero, cidade = @cidade, estado = @estado, telefone = @telefone, celular = @celular, email = @email, inscricao = @inscricao WHERE cod = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtdocumento.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@inscricao", txtinscricao.Text);
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
                    cmdverificar = new MySqlCommand("SELECT * FROM cad_empresas WHERE documento = @documento", con.con);
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
                txtemail.Enabled = false;
                txtemail.Clear();
                txtinscricao.Enabled = false;
                txtinscricao.Clear();
                txtendereco.Enabled = false;
                txtendereco.Clear();
                txtbairro.Enabled = false;
                txtbairro.Clear();
                txtnumero.Enabled = false;
                txtnumero.Clear();
                txtcidade.Enabled = false;
                txtcidade.Clear();
                cbestados.Enabled = false;
                cbestados.SelectedIndex = -1;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Transportadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM cad_empresas WHERE cod = @id";
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
                    txtemail.Enabled = false;
                    txtemail.Clear();
                    txtinscricao.Enabled = false;
                    txtinscricao.Clear();
                    txtendereco.Enabled = false;
                    txtendereco.Clear();
                    txtbairro.Enabled = false;
                    txtbairro.Clear();
                    txtnumero.Enabled = false;
                    txtnumero.Clear();
                    txtcidade.Enabled = false;
                    txtcidade.Clear();
                    cbestados.Enabled = false;
                    cbestados.SelectedIndex = -1;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btncancelarpesquisa_Click(object sender, EventArgs e)
        {
            pnpesquisa.Visible = false;
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
                txtemail.Text = dgCliente.CurrentRow.Cells[11].Value.ToString();
                txtinscricao.Text = dgCliente.CurrentRow.Cells[12].Value.ToString();

                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnfoto.Enabled = true;
                txtnome.Enabled = true;
                txtdocumento.Enabled = true;
                txtemail.Enabled = true;
                txtinscricao.Enabled = true;
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

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtdocumento.Focus();
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtinscricao.Focus();
        }

        private void txtendereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtbairro.Focus();
        }

        private void txtbairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtnumero.Focus();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtcidade.Focus();
        }

        private void txtcidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbestados.Focus();
        }

        private void cbestados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txttelefone.Focus();
        }

        private void txtinscricao_KeyPress(object sender, KeyPressEventArgs e)
        {           
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtendereco.Focus();
        }
    }
}

