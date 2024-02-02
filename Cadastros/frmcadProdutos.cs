using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Sistema_de_Vendas.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sistema_de_Vendas
{
    public partial class frmcadProdutos : Form
    {
        public frmcadProdutos()
        {
            InitializeComponent();
        }

        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string foto;
        string id;
        string alterou_foto = "n";

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

        private void Listarcategoria()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_categorias ORDER BY nome_categoria asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbcategoria.DataSource = dt;
            cbcategoria.DisplayMember = "nome_categoria";
            con.FecharConexao();
        }

        private void listarfornecedor()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_fornecedores ORDER BY nome_fornecedor asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbfornecedor.DataSource = dt;
            cbfornecedor.DisplayMember = "nome_fornecedor";
            con.FecharConexao();
        }

        private void Limparfoto()
        {
            pbFoto.Image = Properties.Resources.download;
            foto = "download.png";
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos ORDER BY nome_produto ASC";
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
            dgCliente.Columns[0].HeaderText = "Cód. Produto";
            dgCliente.Columns[1].HeaderText = "Descrição";
            dgCliente.Columns[2].HeaderText = "Categoria";
            dgCliente.Columns[3].HeaderText = "Unidade de Medida";
            dgCliente.Columns[4].HeaderText = "Quantidade";
            dgCliente.Columns[5].HeaderText = "Fornecedor";
            dgCliente.Columns[6].HeaderText = "Peso Médio";
            dgCliente.Columns[7].HeaderText = "Peso Bruto";
            dgCliente.Columns[8].HeaderText = "Fabricante";
            dgCliente.Columns[9].HeaderText = "Valor Compra";
            dgCliente.Columns[10].HeaderText = "Valor Venda";
            dgCliente.Columns[11].HeaderText = "Margem de Lucro";
            dgCliente.Columns[12].HeaderText = "Situação Tributária";
            dgCliente.Columns[13].HeaderText = "Aliquota IPI";
            dgCliente.Columns[14].HeaderText = "Código IPI";
            dgCliente.Columns[15].HeaderText = "Foto";
            dgCliente.Columns[16].HeaderText = "Estoque Mínimo";
            dgCliente.Columns[17].HeaderText = "Estoque Máximo";
            dgCliente.Columns[18].HeaderText = "Validade";
            dgCliente.Columns[19].HeaderText = "Etiqueta";
            dgCliente.Columns[20].HeaderText = "Adicionado por";
            dgCliente.Columns[21].HeaderText = "Data e hora da inclusão";



        }

        private void Buscar()
        {
            string pesquisa = txtpesquisa.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos WHERE nome_produto LIKE @nome or cod_produto LIKE @cod_produto or etiqueta LIKE @etiqueta";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@cod_produto", "%" + pesquisa + "%");
            cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCliente.DataSource = dt;
            con.FecharConexao();

            formatargrid();


        }


        private void lbladicionarcategorias_DoubleClick(object sender, EventArgs e)
        {
            frmcad_categorias frmcad_Categorias = new frmcad_categorias();
            frmcad_Categorias.ShowDialog();
        }

        private void frmcadProdutos_Load(object sender, EventArgs e)
        {
            Limparfoto();
            Listar();
            Listarcategoria();
            cbcategoria.SelectedIndex = -1;
            listarfornecedor();
            cbfornecedor.SelectedIndex = -1;
            formatargrid();
        }

        private void lblpesquisa_DoubleClick(object sender, EventArgs e)
        {
            pnpesquisa.Visible = true;
            txtpesquisa.Enabled = true;
            txtpesquisa.Clear();
            btncancelarpesquisa.Enabled = true;
            txtpesquisa.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtetiqueta.Enabled = false;
            txtetiqueta.Clear();
            txtdescricao.Enabled = false;
            txtdescricao.Clear();
            cbcategoria.Enabled = false;
            cbcategoria.SelectedIndex = -1;
            cbunidade.Enabled = false;
            cbunidade.SelectedIndex = -1;
            txtquantidade.Enabled = false;
            txtquantidade.Clear();
            cbfornecedor.Enabled = false;
            cbfornecedor.SelectedIndex = -1;
            txtpesomedio.Enabled = false;
            txtpesomedio.Clear();
            txtpesobruto.Enabled = false;
            txtpesobruto.Clear();
            txtfabricante.Enabled = false;
            txtfabricante.Clear();
            txtvalorcompra.Enabled = false;
            txtvalorcompra.Clear();
            txtvalorvenda.Enabled = false;
            txtvalorvenda.Clear();
            txtmargemlucro.Enabled = false;
            txtmargemlucro.Clear();
            txtestoqueminimo.Enabled = false;
            txtestoqueminimo.Clear();
            txtestoquemaximo.Enabled = false;
            txtestoquemaximo.Clear();
            txtvalidade.Enabled = false;
            txtvalidade.Clear();


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
            txtetiqueta.Enabled = true;
            txtdescricao.Enabled = true;
            cbcategoria.Enabled = true;
            cbunidade.Enabled = true;
            txtquantidade.Enabled = true;
            cbfornecedor.Enabled = true;
            txtpesomedio.Enabled = true;
            txtpesobruto.Enabled = true;
            txtfabricante.Enabled = true;
            txtvalorcompra.Enabled = true;
            txtvalorvenda.Enabled = true;
            txtmargemlucro.Enabled = true;
            txtestoqueminimo.Enabled = true;
            txtestoquemaximo.Enabled = true;
            txtvalidade.Enabled = true;


            btnNovo.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnfoto.Enabled = true;
            txtetiqueta.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {



            if (txtdescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o Produto!");
                txtdescricao.Clear();
                txtdescricao.Focus();
                return;
            }


            if (cbcategoria.Text == "")
            {
                MessageBox.Show("Digite uma categoria para o Produto!");
                cbcategoria.SelectedIndex = -1;
                cbcategoria.Focus();
                return;
            }

            if (cbunidade.Text == "")
            {
                MessageBox.Show("Digite uma unidade para o Produto!");
                cbunidade.SelectedIndex = -1;
                cbunidade.Focus();
                return;
            }


            if (txtquantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma quantidade para o Produto!");
                txtquantidade.Clear();
                txtquantidade.Focus();
                return;
            }

            if (txtvalorcompra.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um valor de compra para o Produto!");
                txtvalorcompra.Clear();
                txtvalorcompra.Focus();
                return;
            }

            if (txtvalorvenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um valor de venda para o Produto!");
                txtvalorvenda.Clear();
                txtvalorvenda.Focus();
                return;
            }






            //verifica se o usuário já exite no banco de dados

            try
            {
                con.AbrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM cad_produtos WHERE nome_produto = @nome", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@nome", txtdescricao.Text);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Produto já cadastrado!");
                    txtetiqueta.Clear();
                    txtdescricao.Clear();
                    cbcategoria.SelectedIndex = -1;
                    cbunidade.SelectedIndex = -1;
                    txtquantidade.Clear();
                    cbfornecedor.SelectedIndex = -1;
                    txtpesomedio.Clear();
                    txtpesobruto.Clear();
                    txtfabricante.Clear();
                    txtvalorcompra.Clear();
                    txtvalorvenda.Clear();
                    txtmargemlucro.Clear();
                    txtestoqueminimo.Clear();
                    txtestoquemaximo.Clear();
                    txtvalidade.Clear();

                    txtdescricao.Focus();
                    con.FecharConexao();
                    return;
                }
                else
                {

                    //insere dados na tabela
                    con.AbrirConexao();
                    sql = "INSERT INTO cad_produtos(nome_produto, categoria_produto, unidade_medida, quantidade, fornecedor, peso_medio, peso_bruto, fabricante, valor_compra, valor_venda, margem_lucro, situacao_tributaria, aliquota_ipi, cod_ipi, foto, estoque_minimo, estoque_maximo, validade, etiqueta, usuario, datahora) VALUES (@nome, @categoria, @unidade_medida, @quantidade, @fornecedor,  @peso_medio, @peso_bruto, @fabricante, @valor_compra, @valor_venda, @margem_lucro, @situacao_tributaria, @aliquota_ipi, @cod_ipi, @foto, @estoque_minimo, @estoque_maximo, @validade, @etiqueta, @usuario, @datahora)";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@nome", txtdescricao.Text);
                    cmd.Parameters.AddWithValue("@categoria", cbcategoria.Text);
                    cmd.Parameters.AddWithValue("@unidade_medida", cbunidade.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", cbfornecedor.Text);
                    cmd.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                    cmd.Parameters.AddWithValue("@peso_medio", txtpesomedio.Text);
                    cmd.Parameters.AddWithValue("@peso_bruto", txtpesobruto.Text);
                    cmd.Parameters.AddWithValue("@fabricante", txtfabricante.Text);
                    cmd.Parameters.AddWithValue("@valor_compra", txtvalorcompra.Text.Replace("R$", "").Trim());
                    cmd.Parameters.AddWithValue("@valor_venda", txtvalorvenda.Text.Replace("R$", "").Trim());
                    cmd.Parameters.AddWithValue("@margem_lucro", txtmargemlucro.Text.Replace("%", ""));
                    cmd.Parameters.AddWithValue("@situacao_tributaria", txtsituacaotributaria.Text);
                    cmd.Parameters.AddWithValue("@aliquota_ipi", txtaliquota.Text);
                    cmd.Parameters.AddWithValue("@cod_ipi", txtcodipi.Text);
                    cmd.Parameters.AddWithValue("@foto", img());
                    cmd.Parameters.AddWithValue("@estoque_minimo", txtestoqueminimo.Text);
                    cmd.Parameters.AddWithValue("@estoque_maximo", txtestoquemaximo.Text);
                    cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                    cmd.Parameters.AddWithValue("@etiqueta", txtetiqueta.Text);
                    cmd.Parameters.AddWithValue("@usuario", funcoes.conectado);
                    cmd.Parameters.AddWithValue("@datahora", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    //desabilitar botões e campos
                    txtetiqueta.Enabled = false;
                    txtetiqueta.Clear();
                    txtdescricao.Enabled = false;
                    txtdescricao.Clear();
                    cbcategoria.Enabled = false;
                    cbcategoria.SelectedIndex = -1;
                    cbunidade.Enabled = false;
                    cbunidade.SelectedIndex = -1;
                    txtquantidade.Enabled = false;
                    txtquantidade.Clear();
                    cbfornecedor.Enabled = false;
                    cbfornecedor.SelectedIndex = -1;
                    txtpesomedio.Enabled = false;
                    txtpesomedio.Clear();
                    txtpesobruto.Enabled = false;
                    txtpesobruto.Clear();
                    txtfabricante.Enabled = false;
                    txtfabricante.Clear();
                    txtvalorcompra.Enabled = false;
                    txtvalorcompra.Clear();
                    txtvalorvenda.Enabled = false;
                    txtvalorvenda.Clear();
                    txtmargemlucro.Enabled = false;
                    txtmargemlucro.Clear();
                    txtestoqueminimo.Enabled = false;
                    txtestoqueminimo.Clear();
                    txtestoquemaximo.Enabled = false;
                    txtestoquemaximo.Clear();
                    txtvalidade.Enabled = false;
                    txtvalidade.Clear();

                    btnAdicionar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnfoto.Enabled = false;
                    btnNovo.Enabled = true;
                    Limparfoto();
                    btnNovo.Focus();
                    Listar();

                    MessageBox.Show("Produto cadastado com sucesso!");
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

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                cbfornecedor.Focus();
        }

        private void txtpesomedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtpesobruto.Focus();
        }

        private void txtpesobruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtfabricante.Focus();
        }

        private void txtvalorcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtvalorvenda.Focus();
        }

        private void txtvalorvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtmargemlucro.Focus();
        }

        private void txtmargemlucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtestoqueminimo.Focus();
        }

        private void txtsituacaotributaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtaliquota.Focus();
        }

        private void txtcodipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtetiqueta.Focus();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtdescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um nome para o produto!");
                txtdescricao.Clear();
                txtdescricao.Focus();
                return;
            }

            if (cbcategoria.Text == "")
            {
                MessageBox.Show("Digite uma categoria para o Produto!");
                cbcategoria.SelectedIndex = -1;
                cbcategoria.Focus();
                return;
            }

            if (cbunidade.Text == "")
            {
                MessageBox.Show("Digite uma unidade para o Produto!");
                cbunidade.SelectedIndex = -1;
                cbunidade.Focus();
                return;
            }

            if (txtquantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite uma quantidade para o Produto!");
                txtquantidade.Clear();
                txtquantidade.Focus();
                return;
            }

            if (txtvalorcompra.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um valor de compra para o Produto!");
                txtvalorcompra.Clear();
                txtvalorcompra.Focus();
                return;
            }

            if (txtvalorvenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um valor de venda para o Produto!");
                txtvalorvenda.Clear();
                txtvalorvenda.Focus();
                return;
            }





            if (alterou_foto == "s")
            {

                con.AbrirConexao();
                sql = "UPDATE cad_produtos SET nome_produto = @nome, categoria_produto = @categoria, unidade_medida = @unidade_medida, quantidade = @quantidade, fornecedor = @fornecedor, peso_medio = @peso_medio, peso_bruto = @peso_bruto, fabricante = @fabricante, valor_compra = @valor_compra, valor_venda = @valor_venda, margem_lucro = @margem_lucro, situacao_tributaria = @situacao_tributaria, aliquota_ipi = @aliquota_ipi, cod_ipi = @cod_ipi, foto = @foto, estoque_minimo = @estoque_minimo, estoque_maximo = @estoque_maximo, validade = @validade, etiqueta = @etiqueta, usuario = @usuario, datahora = @datahora WHERE cod_produto = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@categoria", cbcategoria.Text);
                cmd.Parameters.AddWithValue("@unidade_medida", cbunidade.Text);
                cmd.Parameters.AddWithValue("quantidade", txtquantidade.Text);
                cmd.Parameters.AddWithValue("@fornecedor", cbfornecedor.Text);
                cmd.Parameters.AddWithValue("@peso_medio", txtpesomedio.Text);
                cmd.Parameters.AddWithValue("@peso_bruto", txtpesobruto.Text);
                cmd.Parameters.AddWithValue("@fabricante", txtfabricante.Text);
                cmd.Parameters.AddWithValue("@valor_compra", txtvalorcompra.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@valor_venda", txtvalorvenda.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@margem_lucro", txtmargemlucro.Text);
                cmd.Parameters.AddWithValue("@situacao_tributaria", txtsituacaotributaria.Text);
                cmd.Parameters.AddWithValue("@aliquota_ipi", txtaliquota.Text);
                cmd.Parameters.AddWithValue("@cod_ipi", txtcodipi.Text);
                cmd.Parameters.AddWithValue("@foto", img());
                cmd.Parameters.AddWithValue("@estoque_minimo", txtestoqueminimo.Text);
                cmd.Parameters.AddWithValue("@estoque_maximo", txtestoquemaximo.Text);
                cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                cmd.Parameters.AddWithValue("@etiqueta", txtetiqueta.Text);
                cmd.Parameters.AddWithValue("@usuario", funcoes.conectado);
                cmd.Parameters.AddWithValue("@datahora", DateTime.Now);

            }
            else if (alterou_foto == "n")
            {
                con.AbrirConexao();
                sql = "UPDATE cad_produtos SET nome_produto = @nome, categoria_produto = @categoria, unidade_medida = @unidade_medida, quantidade = @quantidade, fornecedor = @fornecedor, peso_medio = @peso_medio, peso_bruto = @peso_bruto, fabricante = @fabricante, valor_compra = @valor_compra, valor_venda = @valor_venda, margem_lucro = @margem_lucro, situacao_tributaria = @situacao_tributaria, aliquota_ipi = @aliquota_ipi, cod_ipi = @cod_ipi, estoque_minimo = @estoque_minimo, estoque_maximo = @estoque_maximo, validade = @validade, etiqueta = @etiqueta, usuario = @usuario, datahora = @datahora WHERE cod_produto = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@categoria", cbcategoria.Text);
                cmd.Parameters.AddWithValue("@unidade_medida", cbunidade.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                cmd.Parameters.AddWithValue("@fornecedor", cbfornecedor.Text);
                cmd.Parameters.AddWithValue("@peso_medio", txtpesomedio.Text);
                cmd.Parameters.AddWithValue("@peso_bruto", txtpesobruto.Text);
                cmd.Parameters.AddWithValue("@fabricante", txtfabricante.Text);
                cmd.Parameters.AddWithValue("@valor_compra", txtvalorcompra.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@valor_venda", txtvalorvenda.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@margem_lucro", txtmargemlucro.Text);
                cmd.Parameters.AddWithValue("@situacao_tributaria", txtsituacaotributaria.Text);
                cmd.Parameters.AddWithValue("@aliquota_ipi", txtaliquota.Text);
                cmd.Parameters.AddWithValue("@cod_ipi", txtcodipi.Text);
                cmd.Parameters.AddWithValue("@estoque_minimo", txtestoqueminimo.Text);
                cmd.Parameters.AddWithValue("@estoque_maximo", txtestoquemaximo.Text);
                cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                cmd.Parameters.AddWithValue("@etiqueta", txtetiqueta.Text);
                cmd.Parameters.AddWithValue("@usuario", funcoes.conectado);
                cmd.Parameters.AddWithValue("@datahora", DateTime.Now);


            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();


            MessageBox.Show("Registro Alterado com Sucesso!!");
            txtetiqueta.Enabled = false;
            txtetiqueta.Clear();
            txtdescricao.Enabled = false;
            txtdescricao.Clear();
            cbcategoria.Enabled = false;
            cbcategoria.SelectedIndex = -1;
            cbunidade.Enabled = false;
            cbunidade.SelectedIndex = -1;
            txtquantidade.Enabled = false;
            txtquantidade.Clear();
            cbfornecedor.Enabled = false;
            cbfornecedor.SelectedIndex = -1;
            txtpesomedio.Enabled = false;
            txtpesomedio.Clear();
            txtpesobruto.Enabled = false;
            txtpesobruto.Clear();
            txtfabricante.Enabled = false;
            txtfabricante.Clear();
            txtvalorcompra.Enabled = false;
            txtvalorcompra.Clear();
            txtvalorvenda.Enabled = false;
            txtvalorvenda.Clear();
            txtmargemlucro.Enabled = false;
            txtmargemlucro.Clear();
            txtestoqueminimo.Enabled = false;
            txtestoqueminimo.Clear();
            txtestoquemaximo.Enabled = false;
            txtestoquemaximo.Clear();
            txtvalidade.Enabled = false;
            txtvalidade.Clear();

            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            btnfoto.Enabled = false;
            btnNovo.Enabled = true;
            Limparfoto();
            btnNovo.Focus();
            Listar();
            alterou_foto = "n";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir esse registro?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cad_produtos WHERE cod_produto = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                txtetiqueta.Enabled = false;
                txtetiqueta.Clear();
                txtdescricao.Enabled = false;
                txtdescricao.Clear();
                cbcategoria.Enabled = false;
                cbcategoria.SelectedIndex = -1;
                cbunidade.Enabled = false;
                cbunidade.SelectedIndex = -1;
                txtquantidade.Enabled = false;
                txtquantidade.Clear();
                cbfornecedor.Enabled = false;
                cbfornecedor.SelectedIndex = -1;
                txtpesomedio.Enabled = false;
                txtpesomedio.Clear();
                txtpesobruto.Enabled = false;
                txtpesobruto.Clear();
                txtfabricante.Enabled = false;
                txtfabricante.Clear();
                txtvalorcompra.Enabled = false;
                txtvalorcompra.Clear();
                txtvalorvenda.Enabled = false;
                txtvalorvenda.Clear();
                txtmargemlucro.Enabled = false;
                txtmargemlucro.Clear();
                txtestoqueminimo.Enabled = false;
                txtestoqueminimo.Clear();
                txtestoquemaximo.Enabled = false;
                txtestoquemaximo.Clear();
                txtvalidade.Enabled = false;
                txtvalidade.Clear();

                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                btnfoto.Enabled = false;
                btnNovo.Enabled = true;
                Limparfoto();
                btnNovo.Focus();
                Listar();

            }
            else
            {
                Listar();
            }
        }

        private void btncancelarpesquisa_Click(object sender, EventArgs e)
        {
            pnpesquisa.Visible = false;
        }

        private void pnpesquisa_Leave(object sender, EventArgs e)
        {
            pnpesquisa.Visible = false;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtaliquota_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtcodipi.Focus();
        }

        private void cbcategoria_Enter(object sender, EventArgs e)
        {
            Listarcategoria();
        }

        private void cbfornecedor_Enter(object sender, EventArgs e)
        {
            listarfornecedor();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                id = dgCliente.CurrentRow.Cells[0].Value.ToString();

                txtdescricao.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
                cbcategoria.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
                cbunidade.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
                txtquantidade.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
                cbfornecedor.Text = dgCliente.CurrentRow.Cells[5].Value.ToString();
                txtpesomedio.Text = dgCliente.CurrentRow.Cells[6].Value.ToString();
                txtpesobruto.Text = dgCliente.CurrentRow.Cells[7].Value.ToString();
                txtfabricante.Text = dgCliente.CurrentRow.Cells[8].Value.ToString();
                txtvalorcompra.Text = "R$ " + dgCliente.CurrentRow.Cells[9].Value.ToString();
                txtvalorvenda.Text = "R$ " + dgCliente.CurrentRow.Cells[10].Value.ToString();
                txtmargemlucro.Text = dgCliente.CurrentRow.Cells[11].Value.ToString() + "%";
                txtsituacaotributaria.Text = dgCliente.CurrentRow.Cells[12].Value.ToString();
                txtaliquota.Text = dgCliente.CurrentRow.Cells[13].Value.ToString();
                txtcodipi.Text = dgCliente.CurrentRow.Cells[14].Value.ToString();
                txtestoqueminimo.Text = dgCliente.CurrentRow.Cells[16].Value.ToString();
                txtestoquemaximo.Text = dgCliente.CurrentRow.Cells[17].Value.ToString();
                txtvalidade.Text = dgCliente.CurrentRow.Cells[18].Value.ToString();
                txtetiqueta.Text = dgCliente.CurrentRow.Cells[19].Value.ToString();

                btnNovo.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnfoto.Enabled = true;
                txtetiqueta.Enabled = true;
                txtdescricao.Enabled = true;
                cbcategoria.Enabled = true;
                cbunidade.Enabled = true;
                txtquantidade.Enabled = true;
                cbfornecedor.Enabled = true;
                txtpesomedio.Enabled = true;
                txtpesobruto.Enabled = true;
                txtfabricante.Enabled = true;
                txtvalorcompra.Enabled = true;
                txtvalorvenda.Enabled = true;
                txtmargemlucro.Enabled = true;
                txtestoqueminimo.Enabled = true;
                txtestoquemaximo.Enabled = true;
                txtvalidade.Enabled = true;




                if (dgCliente.CurrentRow.Cells[15].Value != DBNull.Value)
                {
                    byte[] image = (byte[])dgCliente.Rows[e.RowIndex].Cells[15].Value;
                    MemoryStream es = new MemoryStream(image);
                    pbFoto.Image = Image.FromStream(es);

                }
                else
                {
                    pbFoto.Image = Properties.Resources.download;
                }





            }

        }

        private void txtdescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbcategoria.Focus();
        }

        private void cbcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbunidade.Focus();
        }

        private void cbunidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtquantidade.Focus();
        }

        private void cbfornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtpesomedio.Focus();
        }

        private void txtfabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtvalorcompra.Focus();
        }

        private void txtvalorcompra_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtvalorcompra.Text, out decimal valor))
            {

                txtvalorcompra.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }

        }

        private void txtvalorvenda_Leave(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtvalorvenda.Text, out decimal valor))
            {

                txtvalorvenda.Text = valor.ToString("C", CultureInfo.CurrentCulture);
            }

        }

        private void txtmargemlucro_Leave(object sender, EventArgs e)
        {
            if (txtmargemlucro.Text == "")
            {
                txtmargemlucro.Text = "0";
            }

            decimal valorPorcentagem = (decimal)float.Parse(txtmargemlucro.Text);

            txtmargemlucro.Text = (valorPorcentagem).ToString() + "%";
            CalcularValorVenda();

        }

        private void txtestoqueminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtestoquemaximo.Focus();
        }

        private void txtestoquemaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtvalidade.Focus();
        }

        private void lbltributos_DoubleClick(object sender, EventArgs e)
        {
            pntributos.Visible = true;
            txtsituacaotributaria.Enabled = true;
            txtsituacaotributaria.Clear();
            txtaliquota.Enabled = true;
            txtaliquota.Clear();
            txtcodipi.Enabled = true;
            txtcodipi.Clear();
            txtsituacaotributaria.Focus();
        }

        private void pntributos_Leave(object sender, EventArgs e)
        {
            pntributos.Visible = false;
        }

        private void txtvalidade_Leave(object sender, EventArgs e)
        {
            if (txtvalidade.Text == "")
            {
                txtetiqueta.Focus();
            }
            else
            {
                string validade = txtvalidade.Text;
                txtvalidade.Text = Convert.ToInt64(validade).ToString("00/00/0000");
            }
        }

        private void txtvalidade_Enter(object sender, EventArgs e)
        {
            string validade = txtvalidade.Text.Replace("/", "");
            txtvalidade.Text = validade;
        }

        private void txtvalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtetiqueta.Focus();
        }

        private void txtvalorvenda_Enter(object sender, EventArgs e)
        {
            string valor = txtvalorvenda.Text.Replace("R$ ", "");
            txtvalorvenda.Text = valor;
        }

        private void txtvalorcompra_Enter(object sender, EventArgs e)
        {
            string valor = txtvalorcompra.Text.Replace("R$ ", "");
            txtvalorcompra.Text = valor;
        }

        private void txtmargemlucro_Enter(object sender, EventArgs e)
        {
            string percentual = txtmargemlucro.Text.Replace("%", "");
            txtmargemlucro.Text = percentual;
        }

        private void txtetiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.DecNumber(sender, e);
            if (e.KeyChar == 13)
                txtdescricao.Focus();
        }

        private void CalcularValorVenda()
        {
            if (decimal.TryParse(txtvalorcompra.Text.Trim().Replace("R$ ", ""), out decimal valorCompra) &&
                decimal.TryParse(txtmargemlucro.Text.Replace("%", ""), out decimal margemLucro))
            {
                decimal valorVenda = valorCompra * (1 + (margemLucro / 100));

               
                txtvalorvenda.Text = valorVenda.ToString("N2");
            }
            else
            {
               
                MessageBox.Show("Por favor, insira valores válidos para a compra e a margem de lucro.");
            }

        }

        private void txtetiqueta_Leave(object sender, EventArgs e)
        {
            string pesquisa = txtetiqueta.Text;
            con.AbrirConexao();
            sql = "SELECT * FROM cad_produtos WHERE etiqueta LIKE @etiqueta";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@etiqueta", "%" + pesquisa + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCliente.DataSource = dt;
            con.FecharConexao();

            formatargrid();
        }
    }

      
}
