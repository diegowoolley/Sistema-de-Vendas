namespace Sistema_de_Vendas
{
    partial class frmcadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncancelarpesquisa = new System.Windows.Forms.Button();
            this.lblnomepesquisa = new System.Windows.Forms.Label();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.pnpesquisa = new System.Windows.Forms.Panel();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.lbladicionarcategorias = new System.Windows.Forms.Label();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.lblfabricante = new System.Windows.Forms.Label();
            this.btnfoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtvalorcompra = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lblmargemlucro = new System.Windows.Forms.Label();
            this.lblvalorcompra = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.cbunidade = new System.Windows.Forms.ComboBox();
            this.lblunidadade = new System.Windows.Forms.Label();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.lblfornecedor = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.lblvalorvenda = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.txtmargemlucro = new System.Windows.Forms.TextBox();
            this.txtsituacaotributaria = new System.Windows.Forms.TextBox();
            this.lblsituacaotributaria = new System.Windows.Forms.Label();
            this.txtaliquota = new System.Windows.Forms.TextBox();
            this.lblaliquota = new System.Windows.Forms.Label();
            this.txtcodipi = new System.Windows.Forms.TextBox();
            this.lblcodipi = new System.Windows.Forms.Label();
            this.txtpesomedio = new System.Windows.Forms.TextBox();
            this.lblpesomedio = new System.Windows.Forms.Label();
            this.txtpesobruto = new System.Windows.Forms.TextBox();
            this.lblpesobruto = new System.Windows.Forms.Label();
            this.lbltributos = new System.Windows.Forms.Label();
            this.pntributos = new System.Windows.Forms.Panel();
            this.lblestoqueminimo = new System.Windows.Forms.Label();
            this.txtestoqueminimo = new System.Windows.Forms.TextBox();
            this.lblestoquemaximo = new System.Windows.Forms.Label();
            this.txtestoquemaximo = new System.Windows.Forms.TextBox();
            this.lbletiqueta = new System.Windows.Forms.Label();
            this.txtetiqueta = new System.Windows.Forms.TextBox();
            this.lblvalidade = new System.Windows.Forms.Label();
            this.txtvalidade = new System.Windows.Forms.TextBox();
            this.lblinformacao = new System.Windows.Forms.Label();
            this.pnpesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pntributos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelarpesquisa
            // 
            this.btncancelarpesquisa.Enabled = false;
            this.btncancelarpesquisa.Location = new System.Drawing.Point(66, 119);
            this.btncancelarpesquisa.Name = "btncancelarpesquisa";
            this.btncancelarpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btncancelarpesquisa.TabIndex = 22;
            this.btncancelarpesquisa.Text = "fechar";
            this.btncancelarpesquisa.UseVisualStyleBackColor = true;
            this.btncancelarpesquisa.Click += new System.EventHandler(this.btncancelarpesquisa_Click);
            // 
            // lblnomepesquisa
            // 
            this.lblnomepesquisa.AutoSize = true;
            this.lblnomepesquisa.Location = new System.Drawing.Point(59, 33);
            this.lblnomepesquisa.Name = "lblnomepesquisa";
            this.lblnomepesquisa.Size = new System.Drawing.Size(95, 13);
            this.lblnomepesquisa.TabIndex = 2;
            this.lblnomepesquisa.Text = "Pesquisar produto:";
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblpesquisa.Location = new System.Drawing.Point(583, 145);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(190, 13);
            this.lblpesquisa.TabIndex = 96;
            this.lblpesquisa.Text = "(Dê um duplo click para abrir pesquisa)";
            this.lblpesquisa.DoubleClick += new System.EventHandler(this.lblpesquisa_DoubleClick);
            // 
            // pnpesquisa
            // 
            this.pnpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpesquisa.Controls.Add(this.btncancelarpesquisa);
            this.pnpesquisa.Controls.Add(this.txtpesquisa);
            this.pnpesquisa.Controls.Add(this.lblnomepesquisa);
            this.pnpesquisa.Location = new System.Drawing.Point(571, 165);
            this.pnpesquisa.Name = "pnpesquisa";
            this.pnpesquisa.Size = new System.Drawing.Size(206, 159);
            this.pnpesquisa.TabIndex = 95;
            this.pnpesquisa.Visible = false;
            this.pnpesquisa.Leave += new System.EventHandler(this.pnpesquisa_Leave);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisa.Enabled = false;
            this.txtpesquisa.Location = new System.Drawing.Point(4, 49);
            this.txtpesquisa.MaxLength = 100;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(195, 20);
            this.txtpesquisa.TabIndex = 21;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // lbladicionarcategorias
            // 
            this.lbladicionarcategorias.AutoSize = true;
            this.lbladicionarcategorias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbladicionarcategorias.Location = new System.Drawing.Point(568, 127);
            this.lbladicionarcategorias.Name = "lbladicionarcategorias";
            this.lbladicionarcategorias.Size = new System.Drawing.Size(220, 13);
            this.lbladicionarcategorias.TabIndex = 83;
            this.lbladicionarcategorias.Text = "(Dê um duplo click para adicionar categorias)";
            this.lbladicionarcategorias.DoubleClick += new System.EventHandler(this.lbladicionarcategorias_DoubleClick);
            // 
            // txtfabricante
            // 
            this.txtfabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfabricante.Enabled = false;
            this.txtfabricante.Location = new System.Drawing.Point(394, 80);
            this.txtfabricante.MaxLength = 80;
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(195, 20);
            this.txtfabricante.TabIndex = 9;
            this.txtfabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfabricante_KeyPress);
            // 
            // lblfabricante
            // 
            this.lblfabricante.AutoSize = true;
            this.lblfabricante.Location = new System.Drawing.Point(328, 83);
            this.lblfabricante.Name = "lblfabricante";
            this.lblfabricante.Size = new System.Drawing.Size(60, 13);
            this.lblfabricante.TabIndex = 92;
            this.lblfabricante.Text = "Fabricante:";
            // 
            // btnfoto
            // 
            this.btnfoto.Enabled = false;
            this.btnfoto.Location = new System.Drawing.Point(596, 58);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(75, 23);
            this.btnfoto.TabIndex = 21;
            this.btnfoto.TabStop = false;
            this.btnfoto.Text = "foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(394, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(304, 333);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(211, 333);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(113, 333);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 333);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgCliente
            // 
            this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCliente.Location = new System.Drawing.Point(17, 165);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCliente.Size = new System.Drawing.Size(763, 162);
            this.dgCliente.TabIndex = 23;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(677, 27);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 84);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 89;
            this.pbFoto.TabStop = false;
            // 
            // txtvalorcompra
            // 
            this.txtvalorcompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalorcompra.Enabled = false;
            this.txtvalorcompra.Location = new System.Drawing.Point(126, 105);
            this.txtvalorcompra.MaxLength = 10;
            this.txtvalorcompra.Name = "txtvalorcompra";
            this.txtvalorcompra.Size = new System.Drawing.Size(95, 20);
            this.txtvalorcompra.TabIndex = 10;
            this.txtvalorcompra.Enter += new System.EventHandler(this.txtvalorcompra_Enter);
            this.txtvalorcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorcompra_KeyPress);
            this.txtvalorcompra.Leave += new System.EventHandler(this.txtvalorcompra_Leave);
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(126, 27);
            this.txtdescricao.MaxLength = 80;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(195, 20);
            this.txtdescricao.TabIndex = 2;
            this.txtdescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescricao_KeyPress);
            // 
            // lblmargemlucro
            // 
            this.lblmargemlucro.AutoSize = true;
            this.lblmargemlucro.Location = new System.Drawing.Point(223, 109);
            this.lblmargemlucro.Name = "lblmargemlucro";
            this.lblmargemlucro.Size = new System.Drawing.Size(62, 13);
            this.lblmargemlucro.TabIndex = 88;
            this.lblmargemlucro.Text = "M. lucro(%):";
            // 
            // lblvalorcompra
            // 
            this.lblvalorcompra.AutoSize = true;
            this.lblvalorcompra.Location = new System.Drawing.Point(14, 107);
            this.lblvalorcompra.Name = "lblvalorcompra";
            this.lblvalorcompra.Size = new System.Drawing.Size(87, 13);
            this.lblvalorcompra.TabIndex = 87;
            this.lblvalorcompra.Text = "Valor de compra:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(328, 30);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 86;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(14, 30);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(112, 13);
            this.lbldescricao.TabIndex = 84;
            this.lbldescricao.Text = "Descrição do produto:";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.Enabled = false;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(395, 24);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(195, 21);
            this.cbcategoria.TabIndex = 3;
            this.cbcategoria.Enter += new System.EventHandler(this.cbcategoria_Enter);
            this.cbcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbcategoria_KeyPress);
            // 
            // cbunidade
            // 
            this.cbunidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunidade.Enabled = false;
            this.cbunidade.FormattingEnabled = true;
            this.cbunidade.ItemHeight = 13;
            this.cbunidade.Items.AddRange(new object[] {
            "BD",
            "CM",
            "CX",
            "DZ",
            "FD",
            "GL",
            "GR",
            "KG",
            "MT",
            "M2",
            "M3",
            "MG",
            "ML",
            "MM",
            "PC",
            "UN"});
            this.cbunidade.Location = new System.Drawing.Point(126, 52);
            this.cbunidade.Name = "cbunidade";
            this.cbunidade.Size = new System.Drawing.Size(51, 21);
            this.cbunidade.TabIndex = 4;
            this.cbunidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbunidade_KeyPress);
            // 
            // lblunidadade
            // 
            this.lblunidadade.AutoSize = true;
            this.lblunidadade.Location = new System.Drawing.Point(14, 56);
            this.lblunidadade.Name = "lblunidadade";
            this.lblunidadade.Size = new System.Drawing.Size(102, 13);
            this.lblunidadade.TabIndex = 98;
            this.lblunidadade.Text = "Unidade de medida:";
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfornecedor.Enabled = false;
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(395, 53);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(195, 21);
            this.cbfornecedor.TabIndex = 6;
            this.cbfornecedor.Enter += new System.EventHandler(this.cbfornecedor_Enter);
            this.cbfornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbfornecedor_KeyPress);
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.Location = new System.Drawing.Point(328, 58);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblfornecedor.TabIndex = 100;
            this.lblfornecedor.Text = "Fornecedor:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtquantidade.Enabled = false;
            this.txtquantidade.Location = new System.Drawing.Point(249, 52);
            this.txtquantidade.MaxLength = 10;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(73, 20);
            this.txtquantidade.TabIndex = 5;
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalorvenda.Enabled = false;
            this.txtvalorvenda.Location = new System.Drawing.Point(396, 105);
            this.txtvalorvenda.MaxLength = 10;
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(95, 20);
            this.txtvalorvenda.TabIndex = 12;
            this.txtvalorvenda.Enter += new System.EventHandler(this.txtvalorvenda_Enter);
            this.txtvalorvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorvenda_KeyPress);
            this.txtvalorvenda.Leave += new System.EventHandler(this.txtvalorvenda_Leave);
            // 
            // lblvalorvenda
            // 
            this.lblvalorvenda.AutoSize = true;
            this.lblvalorvenda.Location = new System.Drawing.Point(328, 107);
            this.lblvalorvenda.Name = "lblvalorvenda";
            this.lblvalorvenda.Size = new System.Drawing.Size(67, 13);
            this.lblvalorvenda.TabIndex = 104;
            this.lblvalorvenda.Text = "Valor venda:";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(183, 56);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 105;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // txtmargemlucro
            // 
            this.txtmargemlucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmargemlucro.Enabled = false;
            this.txtmargemlucro.Location = new System.Drawing.Point(281, 104);
            this.txtmargemlucro.MaxLength = 3;
            this.txtmargemlucro.Name = "txtmargemlucro";
            this.txtmargemlucro.Size = new System.Drawing.Size(49, 20);
            this.txtmargemlucro.TabIndex = 11;
            this.txtmargemlucro.Enter += new System.EventHandler(this.txtmargemlucro_Enter);
            this.txtmargemlucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmargemlucro_KeyPress);
            this.txtmargemlucro.Leave += new System.EventHandler(this.txtmargemlucro_Leave);
            // 
            // txtsituacaotributaria
            // 
            this.txtsituacaotributaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsituacaotributaria.Enabled = false;
            this.txtsituacaotributaria.Location = new System.Drawing.Point(157, 44);
            this.txtsituacaotributaria.MaxLength = 3;
            this.txtsituacaotributaria.Name = "txtsituacaotributaria";
            this.txtsituacaotributaria.Size = new System.Drawing.Size(70, 20);
            this.txtsituacaotributaria.TabIndex = 23;
            this.txtsituacaotributaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsituacaotributaria_KeyPress);
            // 
            // lblsituacaotributaria
            // 
            this.lblsituacaotributaria.AutoSize = true;
            this.lblsituacaotributaria.Location = new System.Drawing.Point(30, 47);
            this.lblsituacaotributaria.Name = "lblsituacaotributaria";
            this.lblsituacaotributaria.Size = new System.Drawing.Size(114, 13);
            this.lblsituacaotributaria.TabIndex = 107;
            this.lblsituacaotributaria.Text = "Cód Situação tibutária:";
            // 
            // txtaliquota
            // 
            this.txtaliquota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtaliquota.Enabled = false;
            this.txtaliquota.Location = new System.Drawing.Point(157, 70);
            this.txtaliquota.MaxLength = 3;
            this.txtaliquota.Name = "txtaliquota";
            this.txtaliquota.Size = new System.Drawing.Size(134, 20);
            this.txtaliquota.TabIndex = 24;
            this.txtaliquota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaliquota_KeyPress);
            // 
            // lblaliquota
            // 
            this.lblaliquota.AutoSize = true;
            this.lblaliquota.Location = new System.Drawing.Point(52, 73);
            this.lblaliquota.Name = "lblaliquota";
            this.lblaliquota.Size = new System.Drawing.Size(78, 13);
            this.lblaliquota.TabIndex = 109;
            this.lblaliquota.Text = "Aliquota IPI(%):";
            // 
            // txtcodipi
            // 
            this.txtcodipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodipi.Enabled = false;
            this.txtcodipi.Location = new System.Drawing.Point(157, 96);
            this.txtcodipi.MaxLength = 10;
            this.txtcodipi.Name = "txtcodipi";
            this.txtcodipi.Size = new System.Drawing.Size(134, 20);
            this.txtcodipi.TabIndex = 25;
            this.txtcodipi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodipi_KeyPress);
            // 
            // lblcodipi
            // 
            this.lblcodipi.AutoSize = true;
            this.lblcodipi.Location = new System.Drawing.Point(3, 101);
            this.lblcodipi.Name = "lblcodipi";
            this.lblcodipi.Size = new System.Drawing.Size(157, 13);
            this.lblcodipi.TabIndex = 111;
            this.lblcodipi.Text = "Código IPI(Classificação Fiscal):";
            // 
            // txtpesomedio
            // 
            this.txtpesomedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesomedio.Enabled = false;
            this.txtpesomedio.Location = new System.Drawing.Point(126, 79);
            this.txtpesomedio.MaxLength = 10;
            this.txtpesomedio.Name = "txtpesomedio";
            this.txtpesomedio.Size = new System.Drawing.Size(51, 20);
            this.txtpesomedio.TabIndex = 7;
            this.txtpesomedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesomedio_KeyPress);
            // 
            // lblpesomedio
            // 
            this.lblpesomedio.AutoSize = true;
            this.lblpesomedio.Location = new System.Drawing.Point(14, 80);
            this.lblpesomedio.Name = "lblpesomedio";
            this.lblpesomedio.Size = new System.Drawing.Size(65, 13);
            this.lblpesomedio.TabIndex = 113;
            this.lblpesomedio.Text = "Peso médio:";
            // 
            // txtpesobruto
            // 
            this.txtpesobruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesobruto.Enabled = false;
            this.txtpesobruto.Location = new System.Drawing.Point(249, 79);
            this.txtpesobruto.MaxLength = 10;
            this.txtpesobruto.Name = "txtpesobruto";
            this.txtpesobruto.Size = new System.Drawing.Size(51, 20);
            this.txtpesobruto.TabIndex = 8;
            this.txtpesobruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesobruto_KeyPress);
            // 
            // lblpesobruto
            // 
            this.lblpesobruto.AutoSize = true;
            this.lblpesobruto.Location = new System.Drawing.Point(182, 80);
            this.lblpesobruto.Name = "lblpesobruto";
            this.lblpesobruto.Size = new System.Drawing.Size(61, 13);
            this.lblpesobruto.TabIndex = 115;
            this.lblpesobruto.Text = "Peso bruto:";
            // 
            // lbltributos
            // 
            this.lbltributos.AutoSize = true;
            this.lbltributos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltributos.Location = new System.Drawing.Point(368, 145);
            this.lbltributos.Name = "lbltributos";
            this.lbltributos.Size = new System.Drawing.Size(205, 13);
            this.lbltributos.TabIndex = 116;
            this.lbltributos.Text = "(Dê um duplo click para adicionar tributos)";
            this.lbltributos.DoubleClick += new System.EventHandler(this.lbltributos_DoubleClick);
            // 
            // pntributos
            // 
            this.pntributos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pntributos.Controls.Add(this.lblsituacaotributaria);
            this.pntributos.Controls.Add(this.txtsituacaotributaria);
            this.pntributos.Controls.Add(this.txtaliquota);
            this.pntributos.Controls.Add(this.lblaliquota);
            this.pntributos.Controls.Add(this.lblcodipi);
            this.pntributos.Controls.Add(this.txtcodipi);
            this.pntributos.Location = new System.Drawing.Point(270, 165);
            this.pntributos.Name = "pntributos";
            this.pntributos.Size = new System.Drawing.Size(301, 159);
            this.pntributos.TabIndex = 117;
            this.pntributos.Visible = false;
            this.pntributos.Leave += new System.EventHandler(this.pntributos_Leave);
            // 
            // lblestoqueminimo
            // 
            this.lblestoqueminimo.AutoSize = true;
            this.lblestoqueminimo.Location = new System.Drawing.Point(15, 134);
            this.lblestoqueminimo.Name = "lblestoqueminimo";
            this.lblestoqueminimo.Size = new System.Drawing.Size(86, 13);
            this.lblestoqueminimo.TabIndex = 119;
            this.lblestoqueminimo.Text = "Estoque mínimo:";
            // 
            // txtestoqueminimo
            // 
            this.txtestoqueminimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestoqueminimo.Enabled = false;
            this.txtestoqueminimo.Location = new System.Drawing.Point(126, 131);
            this.txtestoqueminimo.MaxLength = 10;
            this.txtestoqueminimo.Name = "txtestoqueminimo";
            this.txtestoqueminimo.Size = new System.Drawing.Size(73, 20);
            this.txtestoqueminimo.TabIndex = 13;
            this.txtestoqueminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestoqueminimo_KeyPress);
            // 
            // lblestoquemaximo
            // 
            this.lblestoquemaximo.AutoSize = true;
            this.lblestoquemaximo.Location = new System.Drawing.Point(202, 134);
            this.lblestoquemaximo.Name = "lblestoquemaximo";
            this.lblestoquemaximo.Size = new System.Drawing.Size(87, 13);
            this.lblestoquemaximo.TabIndex = 121;
            this.lblestoquemaximo.Text = "Estoque máximo:";
            // 
            // txtestoquemaximo
            // 
            this.txtestoquemaximo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestoquemaximo.Enabled = false;
            this.txtestoquemaximo.Location = new System.Drawing.Point(288, 131);
            this.txtestoquemaximo.MaxLength = 10;
            this.txtestoquemaximo.Name = "txtestoquemaximo";
            this.txtestoquemaximo.Size = new System.Drawing.Size(73, 20);
            this.txtestoquemaximo.TabIndex = 14;
            this.txtestoquemaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestoquemaximo_KeyPress);
            // 
            // lbletiqueta
            // 
            this.lbletiqueta.AutoSize = true;
            this.lbletiqueta.Location = new System.Drawing.Point(15, 6);
            this.lbletiqueta.Name = "lbletiqueta";
            this.lbletiqueta.Size = new System.Drawing.Size(96, 13);
            this.lbletiqueta.TabIndex = 123;
            this.lbletiqueta.Text = "EAN13 \\ GTIN13 :";
            // 
            // txtetiqueta
            // 
            this.txtetiqueta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtetiqueta.Enabled = false;
            this.txtetiqueta.Location = new System.Drawing.Point(126, 3);
            this.txtetiqueta.MaxLength = 13;
            this.txtetiqueta.Name = "txtetiqueta";
            this.txtetiqueta.Size = new System.Drawing.Size(195, 20);
            this.txtetiqueta.TabIndex = 1;
            this.txtetiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtetiqueta_KeyPress);
            this.txtetiqueta.Leave += new System.EventHandler(this.txtetiqueta_Leave);
            // 
            // lblvalidade
            // 
            this.lblvalidade.AutoSize = true;
            this.lblvalidade.Location = new System.Drawing.Point(636, 338);
            this.lblvalidade.Name = "lblvalidade";
            this.lblvalidade.Size = new System.Drawing.Size(51, 13);
            this.lblvalidade.TabIndex = 125;
            this.lblvalidade.Text = "Validade:";
            // 
            // txtvalidade
            // 
            this.txtvalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalidade.Enabled = false;
            this.txtvalidade.Location = new System.Drawing.Point(693, 333);
            this.txtvalidade.MaxLength = 10;
            this.txtvalidade.Name = "txtvalidade";
            this.txtvalidade.Size = new System.Drawing.Size(73, 20);
            this.txtvalidade.TabIndex = 15;
            this.txtvalidade.Enter += new System.EventHandler(this.txtvalidade_Enter);
            this.txtvalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalidade_KeyPress);
            this.txtvalidade.Leave += new System.EventHandler(this.txtvalidade_Leave);
            // 
            // lblinformacao
            // 
            this.lblinformacao.AutoSize = true;
            this.lblinformacao.ForeColor = System.Drawing.Color.Crimson;
            this.lblinformacao.Location = new System.Drawing.Point(320, 7);
            this.lblinformacao.Name = "lblinformacao";
            this.lblinformacao.Size = new System.Drawing.Size(298, 13);
            this.lblinformacao.TabIndex = 126;
            this.lblinformacao.Text = "Use o leitor de código de barras ou digite o código do produto";
            // 
            // frmcadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 363);
            this.Controls.Add(this.lblinformacao);
            this.Controls.Add(this.txtvalidade);
            this.Controls.Add(this.lblvalidade);
            this.Controls.Add(this.lbletiqueta);
            this.Controls.Add(this.txtetiqueta);
            this.Controls.Add(this.lblestoquemaximo);
            this.Controls.Add(this.txtestoquemaximo);
            this.Controls.Add(this.lblestoqueminimo);
            this.Controls.Add(this.txtestoqueminimo);
            this.Controls.Add(this.pntributos);
            this.Controls.Add(this.lbltributos);
            this.Controls.Add(this.txtpesobruto);
            this.Controls.Add(this.lblpesobruto);
            this.Controls.Add(this.txtpesomedio);
            this.Controls.Add(this.lblpesomedio);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtvalorvenda);
            this.Controls.Add(this.lblvalorvenda);
            this.Controls.Add(this.cbfornecedor);
            this.Controls.Add(this.lblfornecedor);
            this.Controls.Add(this.cbunidade);
            this.Controls.Add(this.lblunidadade);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.lblpesquisa);
            this.Controls.Add(this.pnpesquisa);
            this.Controls.Add(this.lbladicionarcategorias);
            this.Controls.Add(this.txtfabricante);
            this.Controls.Add(this.lblfabricante);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtmargemlucro);
            this.Controls.Add(this.txtvalorcompra);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lblmargemlucro);
            this.Controls.Add(this.lblvalorcompra);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmcadProdutos_Load);
            this.pnpesquisa.ResumeLayout(false);
            this.pnpesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pntributos.ResumeLayout(false);
            this.pntributos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelarpesquisa;
        private System.Windows.Forms.Label lblnomepesquisa;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.Panel pnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label lbladicionarcategorias;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.Label lblfabricante;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtvalorcompra;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lblmargemlucro;
        private System.Windows.Forms.Label lblvalorcompra;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.ComboBox cbunidade;
        private System.Windows.Forms.Label lblunidadade;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label lblfornecedor;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtvalorvenda;
        private System.Windows.Forms.Label lblvalorvenda;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox txtmargemlucro;
        private System.Windows.Forms.TextBox txtsituacaotributaria;
        private System.Windows.Forms.Label lblsituacaotributaria;
        private System.Windows.Forms.TextBox txtaliquota;
        private System.Windows.Forms.Label lblaliquota;
        private System.Windows.Forms.TextBox txtcodipi;
        private System.Windows.Forms.Label lblcodipi;
        private System.Windows.Forms.TextBox txtpesomedio;
        private System.Windows.Forms.Label lblpesomedio;
        private System.Windows.Forms.TextBox txtpesobruto;
        private System.Windows.Forms.Label lblpesobruto;
        private System.Windows.Forms.Label lbltributos;
        private System.Windows.Forms.Panel pntributos;
        private System.Windows.Forms.Label lblestoqueminimo;
        private System.Windows.Forms.TextBox txtestoqueminimo;
        private System.Windows.Forms.Label lblestoquemaximo;
        private System.Windows.Forms.TextBox txtestoquemaximo;
        private System.Windows.Forms.Label lbletiqueta;
        private System.Windows.Forms.TextBox txtetiqueta;
        private System.Windows.Forms.Label lblvalidade;
        private System.Windows.Forms.TextBox txtvalidade;
        private System.Windows.Forms.Label lblinformacao;
    }
}