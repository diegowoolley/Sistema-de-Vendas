namespace Sistema_de_Vendas.Transacoes
{
    partial class frmPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremover = new System.Windows.Forms.Button();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtvalorun = new System.Windows.Forms.TextBox();
            this.txtquantidadeun = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtitens = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod_barras = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            this.cbformapagamento = new System.Windows.Forms.ComboBox();
            this.pnfracionado = new System.Windows.Forms.Panel();
            this.txttaxa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpix = new System.Windows.Forms.TextBox();
            this.pnvendaprazo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblClienteBloqueado = new System.Windows.Forms.Label();
            this.lblValoremAberto = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.lbloperador = new System.Windows.Forms.Label();
            this.lbltroco = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcaixalivre = new System.Windows.Forms.Label();
            this.btnfecharvenda = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnfracionado.SuspendLayout();
            this.pnvendaprazo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(292, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lançamentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quant. Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(425, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor unitário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(577, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Subtotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(375, 535);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produto,
            this.descricao,
            this.quantidade,
            this.valor_unitario,
            this.sub_total});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(778, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(585, 451);
            this.dataGridView1.TabIndex = 25;
            // 
            // cod_produto
            // 
            this.cod_produto.HeaderText = "Código";
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor_unitario
            // 
            this.valor_unitario.HeaderText = "Valor unitário";
            this.valor_unitario.Name = "valor_unitario";
            this.valor_unitario.ReadOnly = true;
            // 
            // sub_total
            // 
            this.sub_total.HeaderText = "Subtotal";
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(1258, 138);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(105, 23);
            this.btnremover.TabIndex = 7;
            this.btnremover.Text = "Remover itens";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttotalpagar.Enabled = false;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(481, 535);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalpagar.MaxLength = 20;
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(263, 38);
            this.txttotalpagar.TabIndex = 120;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(481, 407);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.MaxLength = 20;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(263, 38);
            this.txtsubtotal.TabIndex = 110;
            // 
            // txtvalorun
            // 
            this.txtvalorun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalorun.Enabled = false;
            this.txtvalorun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorun.Location = new System.Drawing.Point(217, 407);
            this.txtvalorun.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalorun.MaxLength = 20;
            this.txtvalorun.Name = "txtvalorun";
            this.txtvalorun.Size = new System.Drawing.Size(155, 38);
            this.txtvalorun.TabIndex = 100;
            // 
            // txtquantidadeun
            // 
            this.txtquantidadeun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtquantidadeun.Enabled = false;
            this.txtquantidadeun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidadeun.Location = new System.Drawing.Point(21, 407);
            this.txtquantidadeun.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantidadeun.MaxLength = 20;
            this.txtquantidadeun.Name = "txtquantidadeun";
            this.txtquantidadeun.Size = new System.Drawing.Size(155, 38);
            this.txtquantidadeun.TabIndex = 90;
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(217, 268);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescricao.MaxLength = 100;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(527, 38);
            this.txtdescricao.TabIndex = 80;
            // 
            // txtitens
            // 
            this.txtitens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtitens.Enabled = false;
            this.txtitens.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitens.Location = new System.Drawing.Point(21, 268);
            this.txtitens.Margin = new System.Windows.Forms.Padding(4);
            this.txtitens.MaxLength = 20;
            this.txtitens.Name = "txtitens";
            this.txtitens.Size = new System.Drawing.Size(155, 38);
            this.txtitens.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtproduto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcod_barras);
            this.panel1.Controls.Add(this.txtquantidade);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 131);
            this.panel1.TabIndex = 0;
            // 
            // txtproduto
            // 
            this.txtproduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduto.Location = new System.Drawing.Point(472, 59);
            this.txtproduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproduto.MaxLength = 80;
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(692, 38);
            this.txtproduto.TabIndex = 2;
            this.txtproduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproduto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1235, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(769, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código de barras";
            // 
            // txtcod_barras
            // 
            this.txtcod_barras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_barras.Location = new System.Drawing.Point(42, 59);
            this.txtcod_barras.Margin = new System.Windows.Forms.Padding(4);
            this.txtcod_barras.MaxLength = 13;
            this.txtcod_barras.Name = "txtcod_barras";
            this.txtcod_barras.Size = new System.Drawing.Size(400, 38);
            this.txtcod_barras.TabIndex = 1;
            this.txtcod_barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_barras_KeyPress);
            this.txtcod_barras.Leave += new System.EventHandler(this.txtcod_barras_Leave);
            // 
            // txtquantidade
            // 
            this.txtquantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(1190, 59);
            this.txtquantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantidade.MaxLength = 20;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(183, 38);
            this.txtquantidade.TabIndex = 3;
            this.txtquantidade.Text = "1";
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
            this.txtquantidade.Leave += new System.EventHandler(this.txtquantidade_Leave);
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigovenda.ForeColor = System.Drawing.Color.White;
            this.lblcodigovenda.Location = new System.Drawing.Point(17, 138);
            this.lblcodigovenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(154, 20);
            this.lblcodigovenda.TabIndex = 12;
            this.lblcodigovenda.Text = "Número da venda:";
            // 
            // cbformapagamento
            // 
            this.cbformapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformapagamento.Enabled = false;
            this.cbformapagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbformapagamento.FormattingEnabled = true;
            this.cbformapagamento.Location = new System.Drawing.Point(21, 533);
            this.cbformapagamento.Name = "cbformapagamento";
            this.cbformapagamento.Size = new System.Drawing.Size(351, 39);
            this.cbformapagamento.TabIndex = 4;
            this.cbformapagamento.SelectedIndexChanged += new System.EventHandler(this.cbformapagamento_SelectedIndexChanged);
            // 
            // pnfracionado
            // 
            this.pnfracionado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnfracionado.Controls.Add(this.txttaxa);
            this.pnfracionado.Controls.Add(this.label17);
            this.pnfracionado.Controls.Add(this.txtdesconto);
            this.pnfracionado.Controls.Add(this.label12);
            this.pnfracionado.Controls.Add(this.label18);
            this.pnfracionado.Controls.Add(this.label15);
            this.pnfracionado.Controls.Add(this.txtdinheiro);
            this.pnfracionado.Controls.Add(this.label42);
            this.pnfracionado.Controls.Add(this.txtcartao);
            this.pnfracionado.Controls.Add(this.label11);
            this.pnfracionado.Controls.Add(this.txtpix);
            this.pnfracionado.Enabled = false;
            this.pnfracionado.Location = new System.Drawing.Point(12, 599);
            this.pnfracionado.Name = "pnfracionado";
            this.pnfracionado.Size = new System.Drawing.Size(413, 171);
            this.pnfracionado.TabIndex = 3099;
            // 
            // txttaxa
            // 
            this.txttaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaxa.Location = new System.Drawing.Point(280, 124);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(90, 22);
            this.txttaxa.TabIndex = 3108;
            this.txttaxa.Text = "0";
            this.txttaxa.Enter += new System.EventHandler(this.txttaxa_Enter);
            this.txttaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttaxa_KeyPress);
            this.txttaxa.Leave += new System.EventHandler(this.txttaxa_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(219, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 20);
            this.label17.TabIndex = 3109;
            this.label17.Text = "Taxa";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(115, 124);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(90, 22);
            this.txtdesconto.TabIndex = 3106;
            this.txtdesconto.Text = "0";
            this.txtdesconto.Enter += new System.EventHandler(this.txtdesconto_Enter);
            this.txtdesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesconto_KeyPress);
            this.txtdesconto.Leave += new System.EventHandler(this.txtdesconto_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 3107;
            this.label12.Text = "Desconto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(13, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 31);
            this.label18.TabIndex = 3099;
            this.label18.Text = "ENTRADA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(201, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 3101;
            this.label15.Text = "Dinheiro";
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinheiro.Location = new System.Drawing.Point(280, 39);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(90, 22);
            this.txtdinheiro.TabIndex = 3100;
            this.txtdinheiro.Text = "0";
            this.txtdinheiro.Enter += new System.EventHandler(this.txtdinheiro_Enter);
            this.txtdinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinheiro_KeyPress);
            this.txtdinheiro.Leave += new System.EventHandler(this.txtDinheiro_Leave);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(230, 67);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(35, 20);
            this.label42.TabIndex = 3105;
            this.label42.Text = "PIX";
            // 
            // txtcartao
            // 
            this.txtcartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.Location = new System.Drawing.Point(280, 96);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(90, 22);
            this.txtcartao.TabIndex = 3103;
            this.txtcartao.Text = "0";
            this.txtcartao.Enter += new System.EventHandler(this.txtcartao_Enter);
            this.txtcartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcartao_KeyPress);
            this.txtcartao.Leave += new System.EventHandler(this.txtcartao_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(212, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 3104;
            this.label11.Text = "Cartão";
            // 
            // txtpix
            // 
            this.txtpix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpix.Location = new System.Drawing.Point(280, 67);
            this.txtpix.Name = "txtpix";
            this.txtpix.Size = new System.Drawing.Size(90, 22);
            this.txtpix.TabIndex = 3102;
            this.txtpix.Text = "0";
            this.txtpix.Enter += new System.EventHandler(this.txtpix_Enter);
            this.txtpix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpix_KeyPress);
            this.txtpix.Leave += new System.EventHandler(this.txtpix_Leave);
            // 
            // pnvendaprazo
            // 
            this.pnvendaprazo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnvendaprazo.Controls.Add(this.label19);
            this.pnvendaprazo.Controls.Add(this.label13);
            this.pnvendaprazo.Controls.Add(this.dtVencimento);
            this.pnvendaprazo.Controls.Add(this.txtClientes);
            this.pnvendaprazo.Controls.Add(this.lblCliente);
            this.pnvendaprazo.Controls.Add(this.lblVencimento);
            this.pnvendaprazo.Controls.Add(this.label16);
            this.pnvendaprazo.Controls.Add(this.lblClienteBloqueado);
            this.pnvendaprazo.Controls.Add(this.lblValoremAberto);
            this.pnvendaprazo.Controls.Add(this.label21);
            this.pnvendaprazo.Location = new System.Drawing.Point(442, 644);
            this.pnvendaprazo.Name = "pnvendaprazo";
            this.pnvendaprazo.Size = new System.Drawing.Size(636, 126);
            this.pnvendaprazo.TabIndex = 3100;
            this.pnvendaprazo.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(9, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 16);
            this.label19.TabIndex = 3103;
            this.label19.Text = "Nome:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(480, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 3105;
            this.label13.Text = "Valor aberto:";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(492, 18);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(121, 22);
            this.dtVencimento.TabIndex = 3102;
            // 
            // txtClientes
            // 
            this.txtClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes.Location = new System.Drawing.Point(57, 19);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(332, 22);
            this.txtClientes.TabIndex = 3102;
            this.txtClientes.Leave += new System.EventHandler(this.txtClientes_Leave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(104, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(16, 16);
            this.lblCliente.TabIndex = 3104;
            this.lblCliente.Text = "...";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.ForeColor = System.Drawing.Color.White;
            this.lblVencimento.Location = new System.Drawing.Point(408, 22);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(78, 16);
            this.lblVencimento.TabIndex = 3101;
            this.lblVencimento.Text = "Vencimento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(9, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 3101;
            this.label16.Text = "Cliente:";
            // 
            // lblClienteBloqueado
            // 
            this.lblClienteBloqueado.AutoSize = true;
            this.lblClienteBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBloqueado.ForeColor = System.Drawing.Color.White;
            this.lblClienteBloqueado.Location = new System.Drawing.Point(104, 97);
            this.lblClienteBloqueado.Name = "lblClienteBloqueado";
            this.lblClienteBloqueado.Size = new System.Drawing.Size(16, 16);
            this.lblClienteBloqueado.TabIndex = 3101;
            this.lblClienteBloqueado.Text = "...";
            // 
            // lblValoremAberto
            // 
            this.lblValoremAberto.AutoSize = true;
            this.lblValoremAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoremAberto.ForeColor = System.Drawing.Color.White;
            this.lblValoremAberto.Location = new System.Drawing.Point(562, 96);
            this.lblValoremAberto.Name = "lblValoremAberto";
            this.lblValoremAberto.Size = new System.Drawing.Size(31, 16);
            this.lblValoremAberto.TabIndex = 3102;
            this.lblValoremAberto.Text = "0,00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(8, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 16);
            this.label21.TabIndex = 3106;
            this.label21.Text = "Bloqueado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(103, 497);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 20);
            this.label14.TabIndex = 3105;
            this.label14.Text = "Forma de pagamento";
            // 
            // btnconcluir
            // 
            this.btnconcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnconcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconcluir.Location = new System.Drawing.Point(866, 138);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(128, 23);
            this.btnconcluir.TabIndex = 3106;
            this.btnconcluir.Text = "Concluir";
            this.btnconcluir.UseVisualStyleBackColor = false;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // lbloperador
            // 
            this.lbloperador.AutoSize = true;
            this.lbloperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperador.ForeColor = System.Drawing.Color.White;
            this.lbloperador.Location = new System.Drawing.Point(18, 167);
            this.lbloperador.Name = "lbloperador";
            this.lbloperador.Size = new System.Drawing.Size(89, 20);
            this.lbloperador.TabIndex = 3107;
            this.lbloperador.Text = "Operador:";
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.Color.White;
            this.lbltroco.Location = new System.Drawing.Point(1126, 727);
            this.lbltroco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(109, 37);
            this.lbltroco.TabIndex = 3108;
            this.lbltroco.Text = "Troco:";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(644, 138);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 92);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 3109;
            this.pbFoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblcaixalivre);
            this.panel2.Location = new System.Drawing.Point(363, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 278);
            this.panel2.TabIndex = 3111;
            // 
            // lblcaixalivre
            // 
            this.lblcaixalivre.AutoSize = true;
            this.lblcaixalivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaixalivre.Location = new System.Drawing.Point(178, 113);
            this.lblcaixalivre.Name = "lblcaixalivre";
            this.lblcaixalivre.Size = new System.Drawing.Size(331, 55);
            this.lblcaixalivre.TabIndex = 0;
            this.lblcaixalivre.Text = "CAIXA LIVRE";
            // 
            // btnfecharvenda
            // 
            this.btnfecharvenda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfecharvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfecharvenda.Location = new System.Drawing.Point(1000, 138);
            this.btnfecharvenda.Name = "btnfecharvenda";
            this.btnfecharvenda.Size = new System.Drawing.Size(128, 23);
            this.btnfecharvenda.TabIndex = 3113;
            this.btnfecharvenda.Text = "Fechar venda";
            this.btnfecharvenda.UseVisualStyleBackColor = false;
            this.btnfecharvenda.Click += new System.EventHandler(this.btnfecharvenda_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(1134, 138);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(118, 23);
            this.btncancelar.TabIndex = 3115;
            this.btncancelar.Text = "Cancelar venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 782);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnfecharvenda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.lbloperador);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnvendaprazo);
            this.Controls.Add(this.pnfracionado);
            this.Controls.Add(this.cbformapagamento);
            this.Controls.Add(this.lblcodigovenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtvalorun);
            this.Controls.Add(this.txtquantidadeun);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtitens);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPDV_FormClosing);
            this.Load += new System.EventHandler(this.frmPDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnfracionado.ResumeLayout(false);
            this.pnfracionado.PerformLayout();
            this.pnvendaprazo.ResumeLayout(false);
            this.pnvendaprazo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtvalorun;
        private System.Windows.Forms.TextBox txtquantidadeun;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtitens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod_barras;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.ComboBox cbformapagamento;
        private System.Windows.Forms.Panel pnfracionado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpix;
        private System.Windows.Forms.Panel pnvendaprazo;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteBloqueado;
        private System.Windows.Forms.Label lblValoremAberto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Label lbloperador;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcaixalivre;        
        private System.Windows.Forms.Button btnfecharvenda;
        private System.Windows.Forms.Button btncancelar;
    }
}