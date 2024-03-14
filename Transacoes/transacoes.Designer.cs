namespace Sistema_de_Vendas.Transacoes
{
    partial class transacoes
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.lblpesquisar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbtransacao = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodigovenda = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelarmudanca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisa.Location = new System.Drawing.Point(342, 27);
            this.txtpesquisa.MaxLength = 80;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(284, 20);
            this.txtpesquisa.TabIndex = 2;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // lblpesquisar
            // 
            this.lblpesquisar.AutoSize = true;
            this.lblpesquisar.Location = new System.Drawing.Point(280, 30);
            this.lblpesquisar.Name = "lblpesquisar";
            this.lblpesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblpesquisar.TabIndex = 5;
            this.lblpesquisar.Text = "Pesquisar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(831, 379);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cbtransacao
            // 
            this.cbtransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtransacao.FormattingEnabled = true;
            this.cbtransacao.Items.AddRange(new object[] {
            "COMPRA",
            "VENDA",
            "ORÇAMENTO",
            "ORDEM DE SERVIÇO",
            "DESPESA FUNCIONÁRIOS",
            "DESPESA ESTOQUE",
            "DESPESA PATRIMONIAL",
            "TERCEIRIZAÇÃO",
            "IMPOSTOS",
            "DEVOLUÇÃO",
            "TROCA"});
            this.cbtransacao.Location = new System.Drawing.Point(109, 26);
            this.cbtransacao.Name = "cbtransacao";
            this.cbtransacao.Size = new System.Drawing.Size(165, 21);
            this.cbtransacao.TabIndex = 1;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(3, 30);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(100, 13);
            this.lbltipo.TabIndex = 7;
            this.lbltipo.Text = "Tipo da Transação:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(734, 27);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(98, 30);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite para pesquisar por código da transação ou nome do cliente ";
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
            this.btnconcluir.Location = new System.Drawing.Point(288, 158);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btncancelarmudanca);
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
            this.panel1.Location = new System.Drawing.Point(373, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 192);
            this.panel1.TabIndex = 44;
            this.panel1.Visible = false;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // btncancelarmudanca
            // 
            this.btncancelarmudanca.Location = new System.Drawing.Point(369, 158);
            this.btncancelarmudanca.Name = "btncancelarmudanca";
            this.btncancelarmudanca.Size = new System.Drawing.Size(75, 23);
            this.btncancelarmudanca.TabIndex = 50;
            this.btncancelarmudanca.Text = "Cancelar";
            this.btncancelarmudanca.UseVisualStyleBackColor = true;
            this.btncancelarmudanca.Click += new System.EventHandler(this.btncancelarmudanca_Click);
            // 
            // transacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.cbtransacao);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.lblpesquisar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "transacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transações";
            this.Load += new System.EventHandler(this.transacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label lblpesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbtransacao;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label lbltaxa;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Label lblvalor_total;
        private System.Windows.Forms.Label lblcartao;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label lblpix;
        private System.Windows.Forms.TextBox txtpix;
        private System.Windows.Forms.Label lbldinheiro;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label lblformadepagamento;
        private System.Windows.Forms.ComboBox cbformadepagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancelarmudanca;
    }
}