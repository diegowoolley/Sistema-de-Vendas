namespace Sistema_de_Vendas.Transacoes
{
    partial class frmvendas_compras
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
            this.lblcodigovenda = new System.Windows.Forms.Label();
            this.lbltotalitens = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.btnbuscar_produto = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.btnbuscar_cliente = new System.Windows.Forms.Button();
            this.lblcliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldescontos = new System.Windows.Forms.Label();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.txtdescontos = new System.Windows.Forms.TextBox();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.lblvalorpago = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.cbformapagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtransacao = new System.Windows.Forms.ComboBox();
            this.lbltransacao = new System.Windows.Forms.Label();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnbuscarservico = new System.Windows.Forms.Button();
            this.lblservico = new System.Windows.Forms.Label();
            this.txtquantidadeservico = new System.Windows.Forms.TextBox();
            this.lblquantidadeservico = new System.Windows.Forms.Label();
            this.cbservico = new System.Windows.Forms.ComboBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.cbproduto = new System.Windows.Forms.ComboBox();
            this.btnremoveritens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.ForeColor = System.Drawing.Color.Red;
            this.lblcodigovenda.Location = new System.Drawing.Point(3, 9);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(91, 13);
            this.lblcodigovenda.TabIndex = 0;
            this.lblcodigovenda.Text = "Código da venda:";
            // 
            // lbltotalitens
            // 
            this.lbltotalitens.AutoSize = true;
            this.lbltotalitens.ForeColor = System.Drawing.Color.Red;
            this.lbltotalitens.Location = new System.Drawing.Point(264, 9);
            this.lbltotalitens.Name = "lbltotalitens";
            this.lbltotalitens.Size = new System.Drawing.Size(74, 13);
            this.lbltotalitens.TabIndex = 1;
            this.lbltotalitens.Text = "Total de itens:";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(3, 70);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(99, 13);
            this.lblproduto.TabIndex = 6;
            this.lblproduto.Text = "Selecionar produto:";
            // 
            // btnbuscar_produto
            // 
            this.btnbuscar_produto.Location = new System.Drawing.Point(267, 67);
            this.btnbuscar_produto.Name = "btnbuscar_produto";
            this.btnbuscar_produto.Size = new System.Drawing.Size(51, 23);
            this.btnbuscar_produto.TabIndex = 5;
            this.btnbuscar_produto.Text = "Buscar";
            this.btnbuscar_produto.UseVisualStyleBackColor = true;
            this.btnbuscar_produto.Click += new System.EventHandler(this.btnbuscar_produto_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(386, 67);
            this.txtquantidade.MaxLength = 10;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(54, 20);
            this.txtquantidade.TabIndex = 6;
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(324, 70);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 8;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // lblvendedor
            // 
            this.lblvendedor.AutoSize = true;
            this.lblvendedor.Location = new System.Drawing.Point(446, 70);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(56, 13);
            this.lblvendedor.TabIndex = 9;
            this.lblvendedor.Text = "Vendedor:";
            // 
            // cbvendedor
            // 
            this.cbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Location = new System.Drawing.Point(499, 67);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(121, 21);
            this.cbvendedor.TabIndex = 7;
            // 
            // btnbuscar_cliente
            // 
            this.btnbuscar_cliente.Location = new System.Drawing.Point(523, 37);
            this.btnbuscar_cliente.Name = "btnbuscar_cliente";
            this.btnbuscar_cliente.Size = new System.Drawing.Size(51, 23);
            this.btnbuscar_cliente.TabIndex = 3;
            this.btnbuscar_cliente.Text = "Buscar";
            this.btnbuscar_cliente.UseVisualStyleBackColor = true;
            this.btnbuscar_cliente.Click += new System.EventHandler(this.btnbuscar_cliente_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(259, 40);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(94, 13);
            this.lblcliente.TabIndex = 13;
            this.lblcliente.Text = "Selecionar cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column15,
            this.Column14,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column13,
            this.Column11,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(6, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(615, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CÓD VENDA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TIPO TRANSAÇÂO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CLIENTE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 77;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRODUTO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 86;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QUANTIDADE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 103;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "CATEGORIA";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 94;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "PREÇO";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 69;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "VENDEDOR";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 93;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SERVIÇO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 79;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "QUANT SERVIÇO";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 110;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "DESCONTOS";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 99;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "FORMA DE PAGAMENTO";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 145;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "TROCO";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "VALOR PAGO";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 93;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "VALOR TOTAL";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 97;
            // 
            // lbldescontos
            // 
            this.lbldescontos.AutoSize = true;
            this.lbldescontos.Location = new System.Drawing.Point(143, 350);
            this.lbldescontos.Name = "lbldescontos";
            this.lbldescontos.Size = new System.Drawing.Size(61, 13);
            this.lbldescontos.TabIndex = 15;
            this.lbldescontos.Text = "Descontos:";
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.ForeColor = System.Drawing.Color.Red;
            this.lblvalortotal.Location = new System.Drawing.Point(509, 9);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(57, 13);
            this.lblvalortotal.TabIndex = 16;
            this.lblvalortotal.Text = "Valor total:";
            // 
            // txtdescontos
            // 
            this.txtdescontos.Location = new System.Drawing.Point(201, 347);
            this.txtdescontos.MaxLength = 10;
            this.txtdescontos.Name = "txtdescontos";
            this.txtdescontos.Size = new System.Drawing.Size(73, 20);
            this.txtdescontos.TabIndex = 15;
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.Location = new System.Drawing.Point(63, 347);
            this.txtvalorpago.MaxLength = 10;
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(74, 20);
            this.txtvalorpago.TabIndex = 14;
            // 
            // lblvalorpago
            // 
            this.lblvalorpago.AutoSize = true;
            this.lblvalorpago.Location = new System.Drawing.Point(5, 350);
            this.lblvalorpago.Name = "lblvalorpago";
            this.lblvalorpago.Size = new System.Drawing.Size(61, 13);
            this.lblvalorpago.TabIndex = 18;
            this.lblvalorpago.Text = "Valor pago:";
            // 
            // txttroco
            // 
            this.txttroco.Enabled = false;
            this.txttroco.Location = new System.Drawing.Point(318, 347);
            this.txttroco.MaxLength = 10;
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(78, 20);
            this.txttroco.TabIndex = 16;
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Location = new System.Drawing.Point(280, 350);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(38, 13);
            this.lbltroco.TabIndex = 20;
            this.lbltroco.Text = "Troco:";
            // 
            // cbformapagamento
            // 
            this.cbformapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformapagamento.FormattingEnabled = true;
            this.cbformapagamento.Location = new System.Drawing.Point(114, 320);
            this.cbformapagamento.Name = "cbformapagamento";
            this.cbformapagamento.Size = new System.Drawing.Size(121, 21);
            this.cbformapagamento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // cbtransacao
            // 
            this.cbtransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtransacao.FormattingEnabled = true;
            this.cbtransacao.Items.AddRange(new object[] {
            "VENDA",
            "ORÇAMENTO"});
            this.cbtransacao.Location = new System.Drawing.Point(99, 37);
            this.cbtransacao.Name = "cbtransacao";
            this.cbtransacao.Size = new System.Drawing.Size(121, 21);
            this.cbtransacao.TabIndex = 1;
            // 
            // lbltransacao
            // 
            this.lbltransacao.AutoSize = true;
            this.lbltransacao.Location = new System.Drawing.Point(3, 41);
            this.lbltransacao.Name = "lbltransacao";
            this.lbltransacao.Size = new System.Drawing.Size(81, 13);
            this.lbltransacao.TabIndex = 24;
            this.lbltransacao.Text = "Tipo transação:";
            // 
            // btnconcluir
            // 
            this.btnconcluir.Location = new System.Drawing.Point(405, 344);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(129, 23);
            this.btnconcluir.TabIndex = 17;
            this.btnconcluir.Text = "Concluir Transação";
            this.btnconcluir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(540, 344);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(74, 23);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnbuscarservico
            // 
            this.btnbuscarservico.Location = new System.Drawing.Point(267, 93);
            this.btnbuscarservico.Name = "btnbuscarservico";
            this.btnbuscarservico.Size = new System.Drawing.Size(51, 23);
            this.btnbuscarservico.TabIndex = 9;
            this.btnbuscarservico.Text = "Buscar";
            this.btnbuscarservico.UseVisualStyleBackColor = true;
            this.btnbuscarservico.Click += new System.EventHandler(this.btnbuscarservico_Click);
            // 
            // lblservico
            // 
            this.lblservico.AutoSize = true;
            this.lblservico.Location = new System.Drawing.Point(3, 96);
            this.lblservico.Name = "lblservico";
            this.lblservico.Size = new System.Drawing.Size(84, 13);
            this.lblservico.TabIndex = 27;
            this.lblservico.Text = "Agregar serviço:";
            // 
            // txtquantidadeservico
            // 
            this.txtquantidadeservico.Location = new System.Drawing.Point(386, 97);
            this.txtquantidadeservico.MaxLength = 10;
            this.txtquantidadeservico.Name = "txtquantidadeservico";
            this.txtquantidadeservico.Size = new System.Drawing.Size(54, 20);
            this.txtquantidadeservico.TabIndex = 10;
            // 
            // lblquantidadeservico
            // 
            this.lblquantidadeservico.AutoSize = true;
            this.lblquantidadeservico.Location = new System.Drawing.Point(324, 100);
            this.lblquantidadeservico.Name = "lblquantidadeservico";
            this.lblquantidadeservico.Size = new System.Drawing.Size(65, 13);
            this.lblquantidadeservico.TabIndex = 29;
            this.lblquantidadeservico.Text = "Quantidade:";
            // 
            // cbservico
            // 
            this.cbservico.FormattingEnabled = true;
            this.cbservico.Location = new System.Drawing.Point(99, 95);
            this.cbservico.Name = "cbservico";
            this.cbservico.Size = new System.Drawing.Size(167, 21);
            this.cbservico.TabIndex = 8;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(153, 133);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(134, 23);
            this.btnadicionar.TabIndex = 11;
            this.btnadicionar.Text = "Adicionar itens";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(350, 37);
            this.cbclientes.MaxDropDownItems = 10;
            this.cbclientes.MaxLength = 80;
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(167, 21);
            this.cbclientes.TabIndex = 2;
            // 
            // cbproduto
            // 
            this.cbproduto.FormattingEnabled = true;
            this.cbproduto.Location = new System.Drawing.Point(99, 66);
            this.cbproduto.MaxDropDownItems = 10;
            this.cbproduto.MaxLength = 80;
            this.cbproduto.Name = "cbproduto";
            this.cbproduto.Size = new System.Drawing.Size(167, 21);
            this.cbproduto.TabIndex = 4;
            // 
            // btnremoveritens
            // 
            this.btnremoveritens.Location = new System.Drawing.Point(293, 133);
            this.btnremoveritens.Name = "btnremoveritens";
            this.btnremoveritens.Size = new System.Drawing.Size(134, 23);
            this.btnremoveritens.TabIndex = 12;
            this.btnremoveritens.Text = "Remover itens";
            this.btnremoveritens.UseVisualStyleBackColor = true;            
            // 
            // frmvendas_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.btnremoveritens);
            this.Controls.Add(this.cbproduto);
            this.Controls.Add(this.cbclientes);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.cbservico);
            this.Controls.Add(this.txtquantidadeservico);
            this.Controls.Add(this.lblquantidadeservico);
            this.Controls.Add(this.btnbuscarservico);
            this.Controls.Add(this.lblservico);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.cbtransacao);
            this.Controls.Add(this.lbltransacao);
            this.Controls.Add(this.cbformapagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.txtvalorpago);
            this.Controls.Add(this.lblvalorpago);
            this.Controls.Add(this.txtdescontos);
            this.Controls.Add(this.lblvalortotal);
            this.Controls.Add(this.lbldescontos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuscar_cliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.lblvendedor);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.btnbuscar_produto);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.lbltotalitens);
            this.Controls.Add(this.lblcodigovenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmvendas_compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmvendas_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.Label lbltotalitens;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Button btnbuscar_produto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.Button btnbuscar_cliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbldescontos;
        private System.Windows.Forms.Label lblvalortotal;
        private System.Windows.Forms.TextBox txtdescontos;
        private System.Windows.Forms.TextBox txtvalorpago;
        private System.Windows.Forms.Label lblvalorpago;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.ComboBox cbformapagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtransacao;
        private System.Windows.Forms.Label lbltransacao;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnbuscarservico;
        private System.Windows.Forms.Label lblservico;
        private System.Windows.Forms.TextBox txtquantidadeservico;
        private System.Windows.Forms.Label lblquantidadeservico;
        private System.Windows.Forms.ComboBox cbservico;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.ComboBox cbclientes;
        private System.Windows.Forms.ComboBox cbproduto;
        private System.Windows.Forms.Button btnremoveritens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}