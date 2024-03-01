namespace Sistema_de_Vendas.Ordem_de_Serviço
{
    partial class frmOS
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
            this.lblcliente = new System.Windows.Forms.Label();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.cbtecnico = new System.Windows.Forms.ComboBox();
            this.lbltecnico = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.txtgarantia = new System.Windows.Forms.TextBox();
            this.lblgarantia = new System.Windows.Forms.Label();
            this.lbltermo = new System.Windows.Forms.Label();
            this.txttermo = new System.Windows.Forms.TextBox();
            this.lbldescricaoprodserv = new System.Windows.Forms.Label();
            this.lbldefeito = new System.Windows.Forms.Label();
            this.lblobservacoes = new System.Windows.Forms.Label();
            this.lbllaudo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblnumeroos = new System.Windows.Forms.Label();
            this.btnadicionarp = new System.Windows.Forms.Button();
            this.btnadicionars = new System.Windows.Forms.Button();
            this.lblquantidadep = new System.Windows.Forms.Label();
            this.txtquantidadep = new System.Windows.Forms.TextBox();
            this.cbproduto = new System.Windows.Forms.ComboBox();
            this.lblproduto = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cod_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblquantidades = new System.Windows.Forms.Label();
            this.txtquantidades = new System.Windows.Forms.TextBox();
            this.cbservico = new System.Windows.Forms.ComboBox();
            this.lblservico = new System.Windows.Forms.Label();
            this.btngerarpagamento = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.RichTextBox();
            this.txtdefeito = new System.Windows.Forms.RichTextBox();
            this.txtobservacao = new System.Windows.Forms.RichTextBox();
            this.txtlaudo = new System.Windows.Forms.RichTextBox();
            this.btnexcluirlista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltroco = new System.Windows.Forms.Label();
            this.lbltaxa = new System.Windows.Forms.Label();
            this.txttaxa = new System.Windows.Forms.TextBox();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.lblvalor_total = new System.Windows.Forms.Label();
            this.lblcartao = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.lblpix = new System.Windows.Forms.Label();
            this.txtpix = new System.Windows.Forms.TextBox();
            this.lbldinheiro = new System.Windows.Forms.Label();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.lblformadepagamento = new System.Windows.Forms.Label();
            this.cbformadepagamento = new System.Windows.Forms.ComboBox();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(12, 9);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Cliente:";
            // 
            // cbclientes
            // 
            this.cbclientes.Enabled = false;
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(62, 6);
            this.cbclientes.MaxLength = 80;
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(241, 21);
            this.cbclientes.TabIndex = 1;
            this.cbclientes.Leave += new System.EventHandler(this.cbclientes_Leave);
            // 
            // cbtecnico
            // 
            this.cbtecnico.Enabled = false;
            this.cbtecnico.FormattingEnabled = true;
            this.cbtecnico.Location = new System.Drawing.Point(445, 6);
            this.cbtecnico.MaxLength = 80;
            this.cbtecnico.Name = "cbtecnico";
            this.cbtecnico.Size = new System.Drawing.Size(241, 21);
            this.cbtecnico.TabIndex = 2;
            this.cbtecnico.Leave += new System.EventHandler(this.cbtecnico_Leave);
            // 
            // lbltecnico
            // 
            this.lbltecnico.AutoSize = true;
            this.lbltecnico.Location = new System.Drawing.Point(317, 9);
            this.lbltecnico.Name = "lbltecnico";
            this.lbltecnico.Size = new System.Drawing.Size(122, 13);
            this.lbltecnico.TabIndex = 2;
            this.lbltecnico.Text = "Técnico \\ Responsável:";
            // 
            // cbstatus
            // 
            this.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatus.Enabled = false;
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "ABERTO",
            "EM ANDAMENTO",
            "ORÇAMENTO",
            "FINALIZADO",
            "CANCELADO",
            "AGUARDANDO PEÇAS",
            "APROVADO"});
            this.cbstatus.Location = new System.Drawing.Point(60, 45);
            this.cbstatus.MaxLength = 80;
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(172, 21);
            this.cbstatus.TabIndex = 3;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(12, 48);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "Status:";
            // 
            // dtinicial
            // 
            this.dtinicial.Enabled = false;
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(385, 45);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(98, 20);
            this.dtinicial.TabIndex = 4;
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(317, 48);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 7;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(520, 49);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 9;
            this.lbldatafinal.Text = "Data final:";
            // 
            // dtfinal
            // 
            this.dtfinal.Enabled = false;
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(588, 46);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(98, 20);
            this.dtfinal.TabIndex = 5;
            // 
            // txtgarantia
            // 
            this.txtgarantia.Enabled = false;
            this.txtgarantia.Location = new System.Drawing.Point(62, 84);
            this.txtgarantia.MaxLength = 11;
            this.txtgarantia.Name = "txtgarantia";
            this.txtgarantia.Size = new System.Drawing.Size(63, 20);
            this.txtgarantia.TabIndex = 6;
            this.txtgarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgarantia_KeyPress);
            // 
            // lblgarantia
            // 
            this.lblgarantia.AutoSize = true;
            this.lblgarantia.Location = new System.Drawing.Point(12, 87);
            this.lblgarantia.Name = "lblgarantia";
            this.lblgarantia.Size = new System.Drawing.Size(50, 13);
            this.lblgarantia.TabIndex = 11;
            this.lblgarantia.Text = "Garantia:";
            // 
            // lbltermo
            // 
            this.lbltermo.AutoSize = true;
            this.lbltermo.Location = new System.Drawing.Point(136, 91);
            this.lbltermo.Name = "lbltermo";
            this.lbltermo.Size = new System.Drawing.Size(96, 13);
            this.lbltermo.TabIndex = 13;
            this.lbltermo.Text = "Termo de garantia:";
            // 
            // txttermo
            // 
            this.txttermo.Enabled = false;
            this.txttermo.Location = new System.Drawing.Point(232, 88);
            this.txttermo.MaxLength = 255;
            this.txttermo.Name = "txttermo";
            this.txttermo.Size = new System.Drawing.Size(454, 20);
            this.txttermo.TabIndex = 7;
            // 
            // lbldescricaoprodserv
            // 
            this.lbldescricaoprodserv.AutoSize = true;
            this.lbldescricaoprodserv.Location = new System.Drawing.Point(59, 119);
            this.lbldescricaoprodserv.Name = "lbldescricaoprodserv";
            this.lbldescricaoprodserv.Size = new System.Drawing.Size(137, 13);
            this.lbldescricaoprodserv.TabIndex = 15;
            this.lbldescricaoprodserv.Text = "Descrição do equipamento:";
            // 
            // lbldefeito
            // 
            this.lbldefeito.AutoSize = true;
            this.lbldefeito.Location = new System.Drawing.Point(533, 119);
            this.lbldefeito.Name = "lbldefeito";
            this.lbldefeito.Size = new System.Drawing.Size(44, 13);
            this.lbldefeito.TabIndex = 17;
            this.lbldefeito.Text = "Defeito:";
            // 
            // lblobservacoes
            // 
            this.lblobservacoes.AutoSize = true;
            this.lblobservacoes.Location = new System.Drawing.Point(89, 324);
            this.lblobservacoes.Name = "lblobservacoes";
            this.lblobservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblobservacoes.TabIndex = 19;
            this.lblobservacoes.Text = "Observações:";
            // 
            // lbllaudo
            // 
            this.lbllaudo.AutoSize = true;
            this.lbllaudo.Location = new System.Drawing.Point(520, 324);
            this.lbllaudo.Name = "lbllaudo";
            this.lbllaudo.Size = new System.Drawing.Size(78, 13);
            this.lbllaudo.TabIndex = 21;
            this.lbllaudo.Text = "Láudo técnico:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(692, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(526, 494);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(746, 732);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 19;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Enabled = false;
            this.btnadicionar.Location = new System.Drawing.Point(836, 732);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 20;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Enabled = false;
            this.btnalterar.Location = new System.Drawing.Point(928, 732);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 21;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Enabled = false;
            this.btnexcluir.Location = new System.Drawing.Point(1021, 732);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 22;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(1112, 732);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblnumeroos
            // 
            this.lblnumeroos.AutoSize = true;
            this.lblnumeroos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroos.ForeColor = System.Drawing.Color.Red;
            this.lblnumeroos.Location = new System.Drawing.Point(1037, 11);
            this.lblnumeroos.Name = "lblnumeroos";
            this.lblnumeroos.Size = new System.Drawing.Size(112, 16);
            this.lblnumeroos.TabIndex = 22;
            this.lblnumeroos.Text = "Número da OS:";
            // 
            // btnadicionarp
            // 
            this.btnadicionarp.Enabled = false;
            this.btnadicionarp.Location = new System.Drawing.Point(458, 545);
            this.btnadicionarp.Name = "btnadicionarp";
            this.btnadicionarp.Size = new System.Drawing.Size(75, 23);
            this.btnadicionarp.TabIndex = 17;
            this.btnadicionarp.Text = "Adicionar";
            this.btnadicionarp.UseVisualStyleBackColor = true;
            this.btnadicionarp.Click += new System.EventHandler(this.btnadicionarp_Click);
            // 
            // btnadicionars
            // 
            this.btnadicionars.Enabled = false;
            this.btnadicionars.Location = new System.Drawing.Point(458, 505);
            this.btnadicionars.Name = "btnadicionars";
            this.btnadicionars.Size = new System.Drawing.Size(75, 23);
            this.btnadicionars.TabIndex = 14;
            this.btnadicionars.Text = "Adicionar";
            this.btnadicionars.UseVisualStyleBackColor = true;
            this.btnadicionars.Click += new System.EventHandler(this.btnadicionars_Click);
            // 
            // lblquantidadep
            // 
            this.lblquantidadep.AutoSize = true;
            this.lblquantidadep.Location = new System.Drawing.Point(314, 549);
            this.lblquantidadep.Name = "lblquantidadep";
            this.lblquantidadep.Size = new System.Drawing.Size(65, 13);
            this.lblquantidadep.TabIndex = 42;
            this.lblquantidadep.Text = "Quantidade:";
            // 
            // txtquantidadep
            // 
            this.txtquantidadep.Enabled = false;
            this.txtquantidadep.Location = new System.Drawing.Point(384, 547);
            this.txtquantidadep.MaxLength = 11;
            this.txtquantidadep.Name = "txtquantidadep";
            this.txtquantidadep.Size = new System.Drawing.Size(63, 20);
            this.txtquantidadep.TabIndex = 16;
            this.txtquantidadep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidadep_KeyPress);
            // 
            // cbproduto
            // 
            this.cbproduto.Enabled = false;
            this.cbproduto.FormattingEnabled = true;
            this.cbproduto.Location = new System.Drawing.Point(60, 546);
            this.cbproduto.MaxLength = 80;
            this.cbproduto.Name = "cbproduto";
            this.cbproduto.Size = new System.Drawing.Size(241, 21);
            this.cbproduto.TabIndex = 15;
            this.cbproduto.Leave += new System.EventHandler(this.cbproduto_Leave);
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(10, 549);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(47, 13);
            this.lblproduto.TabIndex = 39;
            this.lblproduto.Text = "Produto:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_os,
            this.codigo,
            this.descricao,
            this.quantidade,
            this.valor_unitario,
            this.valor_total});
            this.dataGridView2.Location = new System.Drawing.Point(12, 575);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(672, 183);
            this.dataGridView2.TabIndex = 38;
            // 
            // cod_os
            // 
            this.cod_os.HeaderText = "Código OS";
            this.cod_os.Name = "cod_os";
            this.cod_os.ReadOnly = true;
            this.cod_os.Width = 83;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 87;
            // 
            // valor_unitario
            // 
            this.valor_unitario.HeaderText = "Valor unitário";
            this.valor_unitario.Name = "valor_unitario";
            this.valor_unitario.ReadOnly = true;
            this.valor_unitario.Width = 93;
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            this.valor_total.Width = 79;
            // 
            // lblquantidades
            // 
            this.lblquantidades.AutoSize = true;
            this.lblquantidades.Location = new System.Drawing.Point(314, 509);
            this.lblquantidades.Name = "lblquantidades";
            this.lblquantidades.Size = new System.Drawing.Size(65, 13);
            this.lblquantidades.TabIndex = 37;
            this.lblquantidades.Text = "Quantidade:";
            // 
            // txtquantidades
            // 
            this.txtquantidades.Enabled = false;
            this.txtquantidades.Location = new System.Drawing.Point(384, 507);
            this.txtquantidades.MaxLength = 11;
            this.txtquantidades.Name = "txtquantidades";
            this.txtquantidades.Size = new System.Drawing.Size(63, 20);
            this.txtquantidades.TabIndex = 13;
            this.txtquantidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidades_KeyPress);
            // 
            // cbservico
            // 
            this.cbservico.Enabled = false;
            this.cbservico.FormattingEnabled = true;
            this.cbservico.Location = new System.Drawing.Point(60, 506);
            this.cbservico.MaxLength = 80;
            this.cbservico.Name = "cbservico";
            this.cbservico.Size = new System.Drawing.Size(241, 21);
            this.cbservico.TabIndex = 12;
            this.cbservico.Leave += new System.EventHandler(this.cbservico_Leave);
            // 
            // lblservico
            // 
            this.lblservico.AutoSize = true;
            this.lblservico.Location = new System.Drawing.Point(10, 509);
            this.lblservico.Name = "lblservico";
            this.lblservico.Size = new System.Drawing.Size(46, 13);
            this.lblservico.TabIndex = 34;
            this.lblservico.Text = "Serviço:";
            // 
            // btngerarpagamento
            // 
            this.btngerarpagamento.Enabled = false;
            this.btngerarpagamento.Location = new System.Drawing.Point(1108, 589);
            this.btngerarpagamento.Name = "btngerarpagamento";
            this.btngerarpagamento.Size = new System.Drawing.Size(110, 23);
            this.btngerarpagamento.TabIndex = 24;
            this.btngerarpagamento.Text = "Gerar pagamento";
            this.btngerarpagamento.UseVisualStyleBackColor = true;
            this.btngerarpagamento.Click += new System.EventHandler(this.btngerarpagamento_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(12, 135);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(241, 154);
            this.txtdescricao.TabIndex = 8;
            this.txtdescricao.Text = "";
            // 
            // txtdefeito
            // 
            this.txtdefeito.Enabled = false;
            this.txtdefeito.Location = new System.Drawing.Point(426, 135);
            this.txtdefeito.Name = "txtdefeito";
            this.txtdefeito.Size = new System.Drawing.Size(241, 154);
            this.txtdefeito.TabIndex = 9;
            this.txtdefeito.Text = "";
            // 
            // txtobservacao
            // 
            this.txtobservacao.Enabled = false;
            this.txtobservacao.Location = new System.Drawing.Point(12, 340);
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(241, 154);
            this.txtobservacao.TabIndex = 10;
            this.txtobservacao.Text = "";
            // 
            // txtlaudo
            // 
            this.txtlaudo.Enabled = false;
            this.txtlaudo.Location = new System.Drawing.Point(426, 340);
            this.txtlaudo.Name = "txtlaudo";
            this.txtlaudo.Size = new System.Drawing.Size(241, 154);
            this.txtlaudo.TabIndex = 11;
            this.txtlaudo.Text = "";
            // 
            // btnexcluirlista
            // 
            this.btnexcluirlista.Enabled = false;
            this.btnexcluirlista.Location = new System.Drawing.Point(588, 549);
            this.btnexcluirlista.Name = "btnexcluirlista";
            this.btnexcluirlista.Size = new System.Drawing.Size(96, 23);
            this.btnexcluirlista.TabIndex = 18;
            this.btnexcluirlista.Text = "Excluir da lista";
            this.btnexcluirlista.UseVisualStyleBackColor = true;
            this.btnexcluirlista.Click += new System.EventHandler(this.btnexcluirlista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblcodigovenda);
            this.panel1.Controls.Add(this.lbltroco);
            this.panel1.Controls.Add(this.lbltaxa);
            this.panel1.Controls.Add(this.txttaxa);
            this.panel1.Controls.Add(this.lbldesconto);
            this.panel1.Controls.Add(this.txtdesconto);
            this.panel1.Controls.Add(this.btnconcluir);
            this.panel1.Controls.Add(this.lblvalor_total);
            this.panel1.Controls.Add(this.lblcartao);
            this.panel1.Controls.Add(this.txtcartao);
            this.panel1.Controls.Add(this.lblpix);
            this.panel1.Controls.Add(this.txtpix);
            this.panel1.Controls.Add(this.lbldinheiro);
            this.panel1.Controls.Add(this.txtdinheiro);
            this.panel1.Controls.Add(this.lblformadepagamento);
            this.panel1.Controls.Add(this.cbformadepagamento);
            this.panel1.Location = new System.Drawing.Point(758, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 192);
            this.panel1.TabIndex = 43;
            this.panel1.Visible = false;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltroco.Location = new System.Drawing.Point(316, 101);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(52, 16);
            this.lbltroco.TabIndex = 48;
            this.lbltroco.Text = "Troco:";
            // 
            // lbltaxa
            // 
            this.lbltaxa.AutoSize = true;
            this.lbltaxa.Location = new System.Drawing.Point(136, 134);
            this.lbltaxa.Name = "lbltaxa";
            this.lbltaxa.Size = new System.Drawing.Size(45, 13);
            this.lbltaxa.TabIndex = 45;
            this.lbltaxa.Text = "Taxa %:";
            // 
            // txttaxa
            // 
            this.txttaxa.Enabled = false;
            this.txttaxa.Location = new System.Drawing.Point(209, 131);
            this.txttaxa.MaxLength = 11;
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(63, 20);
            this.txttaxa.TabIndex = 44;
            this.txttaxa.Text = "0,00";
            this.txttaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttaxa_KeyPress);
            this.txttaxa.Leave += new System.EventHandler(this.txttaxa_Leave);
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(136, 97);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(67, 13);
            this.lbldesconto.TabIndex = 47;
            this.lbldesconto.Text = "Desconto %:";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Enabled = false;
            this.txtdesconto.Location = new System.Drawing.Point(209, 94);
            this.txtdesconto.MaxLength = 11;
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(63, 20);
            this.txtdesconto.TabIndex = 46;
            this.txtdesconto.Text = "0,00";
            this.txtdesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesconto_KeyPress);
            this.txtdesconto.Leave += new System.EventHandler(this.txtdesconto_Leave);
            // 
            // btnconcluir
            // 
            this.btnconcluir.Location = new System.Drawing.Point(366, 158);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(75, 23);
            this.btnconcluir.TabIndex = 45;
            this.btnconcluir.Text = "Concluir";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // lblvalor_total
            // 
            this.lblvalor_total.AutoSize = true;
            this.lblvalor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor_total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvalor_total.Location = new System.Drawing.Point(316, 67);
            this.lblvalor_total.Name = "lblvalor_total";
            this.lblvalor_total.Size = new System.Drawing.Size(47, 16);
            this.lblvalor_total.TabIndex = 44;
            this.lblvalor_total.Text = "Total:";
            // 
            // lblcartao
            // 
            this.lblcartao.AutoSize = true;
            this.lblcartao.Location = new System.Drawing.Point(12, 130);
            this.lblcartao.Name = "lblcartao";
            this.lblcartao.Size = new System.Drawing.Size(41, 13);
            this.lblcartao.TabIndex = 43;
            this.lblcartao.Text = "Cartão:";
            // 
            // txtcartao
            // 
            this.txtcartao.Enabled = false;
            this.txtcartao.Location = new System.Drawing.Point(66, 127);
            this.txtcartao.MaxLength = 11;
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(63, 20);
            this.txtcartao.TabIndex = 42;
            this.txtcartao.Text = "0,00";
            this.txtcartao.Enter += new System.EventHandler(this.txtcartao_Enter);
            this.txtcartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcartao_KeyPress);
            this.txtcartao.Leave += new System.EventHandler(this.txtcartao_Leave);
            // 
            // lblpix
            // 
            this.lblpix.AutoSize = true;
            this.lblpix.Location = new System.Drawing.Point(12, 100);
            this.lblpix.Name = "lblpix";
            this.lblpix.Size = new System.Drawing.Size(24, 13);
            this.lblpix.TabIndex = 41;
            this.lblpix.Text = "Pix:";
            // 
            // txtpix
            // 
            this.txtpix.Enabled = false;
            this.txtpix.Location = new System.Drawing.Point(67, 97);
            this.txtpix.MaxLength = 11;
            this.txtpix.Name = "txtpix";
            this.txtpix.Size = new System.Drawing.Size(63, 20);
            this.txtpix.TabIndex = 40;
            this.txtpix.Text = "0,00";
            this.txtpix.Enter += new System.EventHandler(this.txtpix_Enter);
            this.txtpix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpix_KeyPress);
            this.txtpix.Leave += new System.EventHandler(this.txtpix_Leave);
            // 
            // lbldinheiro
            // 
            this.lbldinheiro.AutoSize = true;
            this.lbldinheiro.Location = new System.Drawing.Point(12, 66);
            this.lbldinheiro.Name = "lbldinheiro";
            this.lbldinheiro.Size = new System.Drawing.Size(49, 13);
            this.lbldinheiro.TabIndex = 39;
            this.lbldinheiro.Text = "Dinheiro:";
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Enabled = false;
            this.txtdinheiro.Location = new System.Drawing.Point(67, 63);
            this.txtdinheiro.MaxLength = 11;
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(63, 20);
            this.txtdinheiro.TabIndex = 38;
            this.txtdinheiro.Text = "0,00";
            this.txtdinheiro.Enter += new System.EventHandler(this.txtdinheiro_Enter);
            this.txtdinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinheiro_KeyPress);
            this.txtdinheiro.Leave += new System.EventHandler(this.txtdinheiro_Leave);
            // 
            // lblformadepagamento
            // 
            this.lblformadepagamento.AutoSize = true;
            this.lblformadepagamento.Location = new System.Drawing.Point(12, 19);
            this.lblformadepagamento.Name = "lblformadepagamento";
            this.lblformadepagamento.Size = new System.Drawing.Size(110, 13);
            this.lblformadepagamento.TabIndex = 1;
            this.lblformadepagamento.Text = "Forma de pagamento:";
            // 
            // cbformadepagamento
            // 
            this.cbformadepagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformadepagamento.FormattingEnabled = true;
            this.cbformadepagamento.Location = new System.Drawing.Point(128, 16);
            this.cbformadepagamento.Name = "cbformadepagamento";
            this.cbformadepagamento.Size = new System.Drawing.Size(167, 21);
            this.cbformadepagamento.TabIndex = 0;
            this.cbformadepagamento.SelectedIndexChanged += new System.EventHandler(this.cbformadepagamento_SelectedIndexChanged);
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigovenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcodigovenda.Location = new System.Drawing.Point(301, 19);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(116, 13);
            this.lblcodigovenda.TabIndex = 49;
            this.lblcodigovenda.Text = "Código pagamento:";
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnexcluirlista);
            this.Controls.Add(this.txtlaudo);
            this.Controls.Add(this.txtobservacao);
            this.Controls.Add(this.txtdefeito);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.btngerarpagamento);
            this.Controls.Add(this.btnadicionarp);
            this.Controls.Add(this.btnadicionars);
            this.Controls.Add(this.lblquantidadep);
            this.Controls.Add(this.txtquantidadep);
            this.Controls.Add(this.cbproduto);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblquantidades);
            this.Controls.Add(this.txtquantidades);
            this.Controls.Add(this.cbservico);
            this.Controls.Add(this.lblservico);
            this.Controls.Add(this.lblnumeroos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbllaudo);
            this.Controls.Add(this.lblobservacoes);
            this.Controls.Add(this.lbldefeito);
            this.Controls.Add(this.lbldescricaoprodserv);
            this.Controls.Add(this.lbltermo);
            this.Controls.Add(this.txttermo);
            this.Controls.Add(this.lblgarantia);
            this.Controls.Add(this.txtgarantia);
            this.Controls.Add(this.lbldatafinal);
            this.Controls.Add(this.dtfinal);
            this.Controls.Add(this.lbldatainicial);
            this.Controls.Add(this.dtinicial);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cbtecnico);
            this.Controls.Add(this.lbltecnico);
            this.Controls.Add(this.cbclientes);
            this.Controls.Add(this.lblcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de OS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.ComboBox cbclientes;
        private System.Windows.Forms.ComboBox cbtecnico;
        private System.Windows.Forms.Label lbltecnico;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.TextBox txtgarantia;
        private System.Windows.Forms.Label lblgarantia;
        private System.Windows.Forms.Label lbltermo;
        private System.Windows.Forms.TextBox txttermo;
        private System.Windows.Forms.Label lbldescricaoprodserv;
        private System.Windows.Forms.Label lbldefeito;
        private System.Windows.Forms.Label lblobservacoes;
        private System.Windows.Forms.Label lbllaudo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblnumeroos;
        private System.Windows.Forms.Button btnadicionarp;
        private System.Windows.Forms.Button btnadicionars;
        private System.Windows.Forms.Label lblquantidadep;
        private System.Windows.Forms.TextBox txtquantidadep;
        private System.Windows.Forms.ComboBox cbproduto;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblquantidades;
        private System.Windows.Forms.TextBox txtquantidades;
        private System.Windows.Forms.ComboBox cbservico;
        private System.Windows.Forms.Label lblservico;
        private System.Windows.Forms.Button btngerarpagamento;
        private System.Windows.Forms.RichTextBox txtdescricao;
        private System.Windows.Forms.RichTextBox txtdefeito;
        private System.Windows.Forms.RichTextBox txtobservacao;
        private System.Windows.Forms.RichTextBox txtlaudo;
        private System.Windows.Forms.Button btnexcluirlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpix;
        private System.Windows.Forms.TextBox txtpix;
        private System.Windows.Forms.Label lbldinheiro;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label lblformadepagamento;
        private System.Windows.Forms.ComboBox cbformadepagamento;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Label lblvalor_total;
        private System.Windows.Forms.Label lblcartao;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label lbltaxa;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label lblcodigovenda;
    }
}