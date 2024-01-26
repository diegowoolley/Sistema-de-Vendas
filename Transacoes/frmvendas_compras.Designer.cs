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
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
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
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldescontos = new System.Windows.Forms.Label();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.txtdescontos = new System.Windows.Forms.TextBox();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.lblvalorpago = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.cbformapagamento = new System.Windows.Forms.ComboBox();
            this.lblformapagamento = new System.Windows.Forms.Label();
            this.cbtransacao = new System.Windows.Forms.ComboBox();
            this.lbltransacao = new System.Windows.Forms.Label();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.cbproduto = new System.Windows.Forms.ComboBox();
            this.btnremoveritens = new System.Windows.Forms.Button();
            this.btnfecharvenda = new System.Windows.Forms.Button();
            this.pnservico = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.cbservico = new System.Windows.Forms.ComboBox();
            this.lblservico = new System.Windows.Forms.Label();
            this.lblquantidadeservico = new System.Windows.Forms.Label();
            this.txtquantidadeservico = new System.Windows.Forms.TextBox();
            this.lbladdservico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnservico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(386, 67);
            this.txtquantidade.MaxLength = 10;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(54, 20);
            this.txtquantidade.TabIndex = 6;
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
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
            this.cbvendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbvendedor_KeyPress);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(324, 40);
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
            this.Column12});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(615, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
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
            this.Column8.HeaderText = "QUANT. SERVIÇO";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 113;
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
            this.lbldescontos.Location = new System.Drawing.Point(145, 322);
            this.lbldescontos.Name = "lbldescontos";
            this.lbldescontos.Size = new System.Drawing.Size(61, 13);
            this.lbldescontos.TabIndex = 15;
            this.lbldescontos.Text = "Descontos:";
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.ForeColor = System.Drawing.Color.Red;
            this.lblvalortotal.Location = new System.Drawing.Point(463, 9);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(61, 13);
            this.lblvalortotal.TabIndex = 16;
            this.lblvalortotal.Text = "Valor Total:";
            // 
            // txtdescontos
            // 
            this.txtdescontos.Enabled = false;
            this.txtdescontos.Location = new System.Drawing.Point(203, 319);
            this.txtdescontos.MaxLength = 10;
            this.txtdescontos.Name = "txtdescontos";
            this.txtdescontos.Size = new System.Drawing.Size(73, 20);
            this.txtdescontos.TabIndex = 12;
            this.txtdescontos.Enter += new System.EventHandler(this.txtdescontos_Enter);
            this.txtdescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescontos_KeyPress);
            this.txtdescontos.Leave += new System.EventHandler(this.txtdescontos_Leave);
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.Enabled = false;
            this.txtvalorpago.Location = new System.Drawing.Point(65, 319);
            this.txtvalorpago.MaxLength = 10;
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(74, 20);
            this.txtvalorpago.TabIndex = 11;
            this.txtvalorpago.Enter += new System.EventHandler(this.txtvalorpago_Enter);
            this.txtvalorpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorpago_KeyPress);
            this.txtvalorpago.Leave += new System.EventHandler(this.txtvalorpago_Leave);
            // 
            // lblvalorpago
            // 
            this.lblvalorpago.AutoSize = true;
            this.lblvalorpago.Location = new System.Drawing.Point(7, 322);
            this.lblvalorpago.Name = "lblvalorpago";
            this.lblvalorpago.Size = new System.Drawing.Size(61, 13);
            this.lblvalorpago.TabIndex = 18;
            this.lblvalorpago.Text = "Valor pago:";
            // 
            // txttroco
            // 
            this.txttroco.Enabled = false;
            this.txttroco.Location = new System.Drawing.Point(320, 319);
            this.txttroco.MaxLength = 10;
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(78, 20);
            this.txttroco.TabIndex = 13;
            this.txttroco.TextChanged += new System.EventHandler(this.txttroco_TextChanged);
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Location = new System.Drawing.Point(282, 322);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(38, 13);
            this.lbltroco.TabIndex = 20;
            this.lbltroco.Text = "Troco:";
            // 
            // cbformapagamento
            // 
            this.cbformapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformapagamento.Enabled = false;
            this.cbformapagamento.FormattingEnabled = true;
            this.cbformapagamento.Location = new System.Drawing.Point(116, 292);
            this.cbformapagamento.Name = "cbformapagamento";
            this.cbformapagamento.Size = new System.Drawing.Size(121, 21);
            this.cbformapagamento.TabIndex = 10;
            this.cbformapagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbformapagamento_KeyPress);
            // 
            // lblformapagamento
            // 
            this.lblformapagamento.AutoSize = true;
            this.lblformapagamento.Location = new System.Drawing.Point(7, 295);
            this.lblformapagamento.Name = "lblformapagamento";
            this.lblformapagamento.Size = new System.Drawing.Size(111, 13);
            this.lblformapagamento.TabIndex = 22;
            this.lblformapagamento.Text = "Forma de Pagamento:";
            // 
            // cbtransacao
            // 
            this.cbtransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtransacao.FormattingEnabled = true;
            this.cbtransacao.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA",
            "ORÇAMENTO"});
            this.cbtransacao.Location = new System.Drawing.Point(99, 37);
            this.cbtransacao.Name = "cbtransacao";
            this.cbtransacao.Size = new System.Drawing.Size(121, 21);
            this.cbtransacao.TabIndex = 1;
            this.cbtransacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtransacao_KeyPress);
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
            this.btnconcluir.Enabled = false;
            this.btnconcluir.Location = new System.Drawing.Point(407, 316);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(129, 23);
            this.btnconcluir.TabIndex = 14;
            this.btnconcluir.Text = "Concluir Transação";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(542, 316);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(74, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(12, 105);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(134, 23);
            this.btnadicionar.TabIndex = 8;
            this.btnadicionar.Text = "Adicionar itens";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(453, 37);
            this.cbclientes.MaxDropDownItems = 10;
            this.cbclientes.MaxLength = 80;
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(167, 21);
            this.cbclientes.TabIndex = 2;
            this.cbclientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbclientes_KeyPress);
            this.cbclientes.Leave += new System.EventHandler(this.cbclientes_Leave);
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
            this.cbproduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbproduto_KeyPress);
            this.cbproduto.Leave += new System.EventHandler(this.cbproduto_Leave);
            // 
            // btnremoveritens
            // 
            this.btnremoveritens.Location = new System.Drawing.Point(152, 105);
            this.btnremoveritens.Name = "btnremoveritens";
            this.btnremoveritens.Size = new System.Drawing.Size(134, 23);
            this.btnremoveritens.TabIndex = 9;
            this.btnremoveritens.Text = "Remover itens";
            this.btnremoveritens.UseVisualStyleBackColor = true;
            this.btnremoveritens.Click += new System.EventHandler(this.btnremoveritens_Click);
            // 
            // btnfecharvenda
            // 
            this.btnfecharvenda.Enabled = false;
            this.btnfecharvenda.Location = new System.Drawing.Point(292, 105);
            this.btnfecharvenda.Name = "btnfecharvenda";
            this.btnfecharvenda.Size = new System.Drawing.Size(134, 23);
            this.btnfecharvenda.TabIndex = 32;
            this.btnfecharvenda.Text = "Fechar venda";
            this.btnfecharvenda.UseVisualStyleBackColor = true;
            this.btnfecharvenda.Click += new System.EventHandler(this.btnfecharvenda_Click);
            // 
            // pnservico
            // 
            this.pnservico.Controls.Add(this.btnfechar);
            this.pnservico.Controls.Add(this.cbservico);
            this.pnservico.Controls.Add(this.lblservico);
            this.pnservico.Controls.Add(this.lblquantidadeservico);
            this.pnservico.Controls.Add(this.txtquantidadeservico);
            this.pnservico.Location = new System.Drawing.Point(378, 163);
            this.pnservico.Name = "pnservico";
            this.pnservico.Size = new System.Drawing.Size(243, 100);
            this.pnservico.TabIndex = 30;
            this.pnservico.Visible = false;
            this.pnservico.Leave += new System.EventHandler(this.pnservico_Leave);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(94, 64);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(52, 23);
            this.btnfechar.TabIndex = 19;
            this.btnfechar.Text = "Agregar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // cbservico
            // 
            this.cbservico.FormattingEnabled = true;
            this.cbservico.Location = new System.Drawing.Point(6, 27);
            this.cbservico.Name = "cbservico";
            this.cbservico.Size = new System.Drawing.Size(167, 21);
            this.cbservico.TabIndex = 16;
            this.cbservico.Leave += new System.EventHandler(this.cbservico_Leave);
            // 
            // lblservico
            // 
            this.lblservico.AutoSize = true;
            this.lblservico.Location = new System.Drawing.Point(61, 11);
            this.lblservico.Name = "lblservico";
            this.lblservico.Size = new System.Drawing.Size(81, 13);
            this.lblservico.TabIndex = 27;
            this.lblservico.Text = "Agregar serviço";
            // 
            // lblquantidadeservico
            // 
            this.lblquantidadeservico.AutoSize = true;
            this.lblquantidadeservico.Location = new System.Drawing.Point(174, 11);
            this.lblquantidadeservico.Name = "lblquantidadeservico";
            this.lblquantidadeservico.Size = new System.Drawing.Size(62, 13);
            this.lblquantidadeservico.TabIndex = 29;
            this.lblquantidadeservico.Text = "Quantidade";
            // 
            // txtquantidadeservico
            // 
            this.txtquantidadeservico.Location = new System.Drawing.Point(179, 27);
            this.txtquantidadeservico.MaxLength = 10;
            this.txtquantidadeservico.Name = "txtquantidadeservico";
            this.txtquantidadeservico.Size = new System.Drawing.Size(54, 20);
            this.txtquantidadeservico.TabIndex = 17;
            // 
            // lbladdservico
            // 
            this.lbladdservico.AutoSize = true;
            this.lbladdservico.Location = new System.Drawing.Point(435, 115);
            this.lbladdservico.Name = "lbladdservico";
            this.lbladdservico.Size = new System.Drawing.Size(180, 13);
            this.lbladdservico.TabIndex = 31;
            this.lbladdservico.Text = "Dê dois clicks para adicionar serviço";
            this.lbladdservico.DoubleClick += new System.EventHandler(this.lbladdservico_DoubleClick);
            // 
            // frmvendas_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 346);
            this.Controls.Add(this.btnfecharvenda);
            this.Controls.Add(this.lbladdservico);
            this.Controls.Add(this.pnservico);
            this.Controls.Add(this.btnremoveritens);
            this.Controls.Add(this.cbproduto);
            this.Controls.Add(this.cbclientes);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.cbtransacao);
            this.Controls.Add(this.lbltransacao);
            this.Controls.Add(this.cbformapagamento);
            this.Controls.Add(this.lblformapagamento);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.txtvalorpago);
            this.Controls.Add(this.lblvalorpago);
            this.Controls.Add(this.txtdescontos);
            this.Controls.Add(this.lblvalortotal);
            this.Controls.Add(this.lbldescontos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.lblvendedor);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.lbltotalitens);
            this.Controls.Add(this.lblcodigovenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmvendas_compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas \\ Compras";
            this.Load += new System.EventHandler(this.frmvendas_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnservico.ResumeLayout(false);
            this.pnservico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.Label lbltotalitens;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.ComboBox cbvendedor;
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
        private System.Windows.Forms.Label lblformapagamento;
        private System.Windows.Forms.ComboBox cbtransacao;
        private System.Windows.Forms.Label lbltransacao;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button btncancelar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnfecharvenda;
        private System.Windows.Forms.Panel pnservico;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.ComboBox cbservico;
        private System.Windows.Forms.Label lblservico;
        private System.Windows.Forms.Label lblquantidadeservico;
        private System.Windows.Forms.TextBox txtquantidadeservico;
        private System.Windows.Forms.Label lbladdservico;
    }
}