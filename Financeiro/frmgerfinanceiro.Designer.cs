namespace Sistema_de_Vendas.Financeiro
{
    partial class frmgerfinanceiro
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
            this.lblentradas = new System.Windows.Forms.Label();
            this.lblsaidas = new System.Windows.Forms.Label();
            this.lbldinheiro = new System.Windows.Forms.Label();
            this.lblpix = new System.Windows.Forms.Label();
            this.lblcartao = new System.Windows.Forms.Label();
            this.lbldescontos = new System.Windows.Forms.Label();
            this.txtentradas = new System.Windows.Forms.TextBox();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.txtpix = new System.Windows.Forms.TextBox();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.txtsaidas = new System.Windows.Forms.TextBox();
            this.txtdescontos = new System.Windows.Forms.TextBox();
            this.pnpesquisa = new System.Windows.Forms.Panel();
            this.txtcliente = new System.Windows.Forms.ComboBox();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.cbtransacao = new System.Windows.Forms.ComboBox();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtnumeronota = new System.Windows.Forms.TextBox();
            this.lblnumeronota = new System.Windows.Forms.Label();
            this.pnmovimentacoes = new System.Windows.Forms.Panel();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblempresa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnpesquisa.SuspendLayout();
            this.pnmovimentacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblentradas
            // 
            this.lblentradas.AutoSize = true;
            this.lblentradas.Location = new System.Drawing.Point(20, 4);
            this.lblentradas.Name = "lblentradas";
            this.lblentradas.Size = new System.Drawing.Size(49, 13);
            this.lblentradas.TabIndex = 10;
            this.lblentradas.Text = "Entradas";
            // 
            // lblsaidas
            // 
            this.lblsaidas.AutoSize = true;
            this.lblsaidas.Location = new System.Drawing.Point(23, 55);
            this.lblsaidas.Name = "lblsaidas";
            this.lblsaidas.Size = new System.Drawing.Size(39, 13);
            this.lblsaidas.TabIndex = 11;
            this.lblsaidas.Text = "Saidas";
            // 
            // lbldinheiro
            // 
            this.lbldinheiro.AutoSize = true;
            this.lbldinheiro.Location = new System.Drawing.Point(110, 4);
            this.lbldinheiro.Name = "lbldinheiro";
            this.lbldinheiro.Size = new System.Drawing.Size(46, 13);
            this.lbldinheiro.TabIndex = 12;
            this.lbldinheiro.Text = "Dinheiro";
            // 
            // lblpix
            // 
            this.lblpix.AutoSize = true;
            this.lblpix.Location = new System.Drawing.Point(210, 4);
            this.lblpix.Name = "lblpix";
            this.lblpix.Size = new System.Drawing.Size(21, 13);
            this.lblpix.TabIndex = 13;
            this.lblpix.Text = "Pix";
            // 
            // lblcartao
            // 
            this.lblcartao.AutoSize = true;
            this.lblcartao.Location = new System.Drawing.Point(290, 4);
            this.lblcartao.Name = "lblcartao";
            this.lblcartao.Size = new System.Drawing.Size(38, 13);
            this.lblcartao.TabIndex = 14;
            this.lblcartao.Text = "Cartão";
            // 
            // lbldescontos
            // 
            this.lbldescontos.AutoSize = true;
            this.lbldescontos.Location = new System.Drawing.Point(104, 55);
            this.lbldescontos.Name = "lbldescontos";
            this.lbldescontos.Size = new System.Drawing.Size(58, 13);
            this.lbldescontos.TabIndex = 15;
            this.lbldescontos.Text = "Descontos";
            // 
            // txtentradas
            // 
            this.txtentradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentradas.ForeColor = System.Drawing.Color.Green;
            this.txtentradas.Location = new System.Drawing.Point(7, 22);
            this.txtentradas.MaxLength = 20;
            this.txtentradas.Name = "txtentradas";
            this.txtentradas.Size = new System.Drawing.Size(77, 20);
            this.txtentradas.TabIndex = 16;
            this.txtentradas.TabStop = false;
            this.txtentradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtentradas_KeyPress);
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinheiro.ForeColor = System.Drawing.Color.Green;
            this.txtdinheiro.Location = new System.Drawing.Point(94, 22);
            this.txtdinheiro.MaxLength = 20;
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(77, 20);
            this.txtdinheiro.TabIndex = 17;
            this.txtdinheiro.TabStop = false;
            this.txtdinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinheiro_KeyPress);
            // 
            // txtpix
            // 
            this.txtpix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpix.ForeColor = System.Drawing.Color.Green;
            this.txtpix.Location = new System.Drawing.Point(181, 22);
            this.txtpix.MaxLength = 20;
            this.txtpix.Name = "txtpix";
            this.txtpix.Size = new System.Drawing.Size(77, 20);
            this.txtpix.TabIndex = 18;
            this.txtpix.TabStop = false;
            this.txtpix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpix_KeyPress);
            // 
            // txtcartao
            // 
            this.txtcartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.ForeColor = System.Drawing.Color.Green;
            this.txtcartao.Location = new System.Drawing.Point(269, 22);
            this.txtcartao.MaxLength = 20;
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(77, 20);
            this.txtcartao.TabIndex = 19;
            this.txtcartao.TabStop = false;
            this.txtcartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcartao_KeyPress);
            // 
            // txtsaidas
            // 
            this.txtsaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaidas.ForeColor = System.Drawing.Color.Red;
            this.txtsaidas.Location = new System.Drawing.Point(7, 71);
            this.txtsaidas.MaxLength = 20;
            this.txtsaidas.Name = "txtsaidas";
            this.txtsaidas.Size = new System.Drawing.Size(77, 20);
            this.txtsaidas.TabIndex = 20;
            this.txtsaidas.TabStop = false;
            this.txtsaidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsaidas_KeyPress);
            // 
            // txtdescontos
            // 
            this.txtdescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescontos.ForeColor = System.Drawing.Color.Red;
            this.txtdescontos.Location = new System.Drawing.Point(94, 71);
            this.txtdescontos.MaxLength = 20;
            this.txtdescontos.Name = "txtdescontos";
            this.txtdescontos.Size = new System.Drawing.Size(77, 20);
            this.txtdescontos.TabIndex = 21;
            this.txtdescontos.TabStop = false;
            this.txtdescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescontos_KeyPress);
            // 
            // pnpesquisa
            // 
            this.pnpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpesquisa.Controls.Add(this.txtcliente);
            this.pnpesquisa.Controls.Add(this.dtfinal);
            this.pnpesquisa.Controls.Add(this.dtinicial);
            this.pnpesquisa.Controls.Add(this.cbtransacao);
            this.pnpesquisa.Controls.Add(this.lbldatafinal);
            this.pnpesquisa.Controls.Add(this.lbldatainicial);
            this.pnpesquisa.Controls.Add(this.lblcliente);
            this.pnpesquisa.Controls.Add(this.lbltipo);
            this.pnpesquisa.Controls.Add(this.txtnumeronota);
            this.pnpesquisa.Controls.Add(this.lblnumeronota);
            this.pnpesquisa.Location = new System.Drawing.Point(3, 0);
            this.pnpesquisa.Name = "pnpesquisa";
            this.pnpesquisa.Size = new System.Drawing.Size(921, 42);
            this.pnpesquisa.TabIndex = 22;
            // 
            // txtcliente
            // 
            this.txtcliente.FormattingEnabled = true;
            this.txtcliente.Location = new System.Drawing.Point(418, 6);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(178, 21);
            this.txtcliente.TabIndex = 3;
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcliente_KeyPress);
            this.txtcliente.Leave += new System.EventHandler(this.txtcliente_Leave);
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(822, 8);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(79, 20);
            this.dtfinal.TabIndex = 5;
            this.dtfinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtfinal_KeyPress);
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(661, 7);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(79, 20);
            this.dtinicial.TabIndex = 4;
            this.dtinicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtinicial_KeyPress);
            // 
            // cbtransacao
            // 
            this.cbtransacao.AutoCompleteCustomSource.AddRange(new string[] {
            "VENDA",
            "COMPRA",
            "TROCA",
            "DEVOLUÇÃO"});
            this.cbtransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtransacao.FormattingEnabled = true;
            this.cbtransacao.Items.AddRange(new object[] {
            "VENDA",
            "VENDA PDV",
            "COMPRA",
            "TROCA",
            "DEVOLUÇÃO"});
            this.cbtransacao.Location = new System.Drawing.Point(263, 7);
            this.cbtransacao.Name = "cbtransacao";
            this.cbtransacao.Size = new System.Drawing.Size(106, 21);
            this.cbtransacao.TabIndex = 2;
            this.cbtransacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtransacao_KeyPress);
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(761, 10);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 19;
            this.lbldatafinal.Text = "Data final:";
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(602, 10);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 16;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(370, 10);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 14;
            this.lblcliente.Text = "Cliente:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(170, 10);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(96, 13);
            this.lbltipo.TabIndex = 12;
            this.lbltipo.Text = "Tipo da transação:";
            // 
            // txtnumeronota
            // 
            this.txtnumeronota.Location = new System.Drawing.Point(90, 7);
            this.txtnumeronota.MaxLength = 20;
            this.txtnumeronota.Name = "txtnumeronota";
            this.txtnumeronota.Size = new System.Drawing.Size(77, 20);
            this.txtnumeronota.TabIndex = 1;
            this.txtnumeronota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeronota_KeyPress);
            // 
            // lblnumeronota
            // 
            this.lblnumeronota.AutoSize = true;
            this.lblnumeronota.Location = new System.Drawing.Point(6, 10);
            this.lblnumeronota.Name = "lblnumeronota";
            this.lblnumeronota.Size = new System.Drawing.Size(86, 13);
            this.lblnumeronota.TabIndex = 10;
            this.lblnumeronota.Text = "Número da nota:";
            // 
            // pnmovimentacoes
            // 
            this.pnmovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnmovimentacoes.Controls.Add(this.txtsaldo);
            this.pnmovimentacoes.Controls.Add(this.lblsaldo);
            this.pnmovimentacoes.Controls.Add(this.txtdinheiro);
            this.pnmovimentacoes.Controls.Add(this.lblentradas);
            this.pnmovimentacoes.Controls.Add(this.txtdescontos);
            this.pnmovimentacoes.Controls.Add(this.lblsaidas);
            this.pnmovimentacoes.Controls.Add(this.txtsaidas);
            this.pnmovimentacoes.Controls.Add(this.lbldinheiro);
            this.pnmovimentacoes.Controls.Add(this.txtcartao);
            this.pnmovimentacoes.Controls.Add(this.lblpix);
            this.pnmovimentacoes.Controls.Add(this.txtpix);
            this.pnmovimentacoes.Controls.Add(this.lblcartao);
            this.pnmovimentacoes.Controls.Add(this.lbldescontos);
            this.pnmovimentacoes.Controls.Add(this.txtentradas);
            this.pnmovimentacoes.Location = new System.Drawing.Point(3, 48);
            this.pnmovimentacoes.Name = "pnmovimentacoes";
            this.pnmovimentacoes.Size = new System.Drawing.Size(568, 100);
            this.pnmovimentacoes.TabIndex = 23;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtsaldo.Location = new System.Drawing.Point(435, 42);
            this.txtsaldo.MaxLength = 20;
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(122, 20);
            this.txtsaldo.TabIndex = 23;
            this.txtsaldo.TabStop = false;
            this.txtsaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsaldo_KeyPress);
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(374, 40);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(55, 20);
            this.lblsaldo.TabIndex = 22;
            this.lblsaldo.Text = "Saldo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(921, 296);
            this.dataGridView1.TabIndex = 70;
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.Location = new System.Drawing.Point(701, 138);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(59, 13);
            this.lblempresa.TabIndex = 24;
            this.lblempresa.Text = "EMPRESA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmgerfinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnmovimentacoes);
            this.Controls.Add(this.pnpesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgerfinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento financeiro";
            this.Load += new System.EventHandler(this.frmgerfinanceiro_Load);
            this.pnpesquisa.ResumeLayout(false);
            this.pnpesquisa.PerformLayout();
            this.pnmovimentacoes.ResumeLayout(false);
            this.pnmovimentacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblentradas;
        private System.Windows.Forms.Label lblsaidas;
        private System.Windows.Forms.Label lbldinheiro;
        private System.Windows.Forms.Label lblpix;
        private System.Windows.Forms.Label lblcartao;
        private System.Windows.Forms.Label lbldescontos;
        private System.Windows.Forms.TextBox txtentradas;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.TextBox txtpix;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.TextBox txtsaidas;
        private System.Windows.Forms.TextBox txtdescontos;
        private System.Windows.Forms.Panel pnpesquisa;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txtnumeronota;
        private System.Windows.Forms.Label lblnumeronota;
        private System.Windows.Forms.Panel pnmovimentacoes;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.ComboBox cbtransacao;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtcliente;
    }
}