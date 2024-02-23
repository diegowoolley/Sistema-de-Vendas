namespace Sistema_de_Vendas.Financeiro
{
    partial class frmcaddespesas
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
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lblfavorecido = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvencimento = new System.Windows.Forms.DateTimePicker();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.cbformapagamento = new System.Windows.Forms.ComboBox();
            this.lblformapagamento = new System.Windows.Forms.Label();
            this.cbfavorecido = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(12, 56);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(58, 13);
            this.lbldescricao.TabIndex = 2;
            this.lbldescricao.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Location = new System.Drawing.Point(72, 53);
            this.txtdescricao.MaxLength = 80;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(202, 20);
            this.txtdescricao.TabIndex = 3;
            // 
            // lblfavorecido
            // 
            this.lblfavorecido.AutoSize = true;
            this.lblfavorecido.Location = new System.Drawing.Point(280, 56);
            this.lblfavorecido.Name = "lblfavorecido";
            this.lblfavorecido.Size = new System.Drawing.Size(63, 13);
            this.lblfavorecido.TabIndex = 4;
            this.lblfavorecido.Text = "Favorecido:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdocumento.Location = new System.Drawing.Point(326, 18);
            this.txtdocumento.MaxLength = 80;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(238, 20);
            this.txtdocumento.TabIndex = 2;
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Location = new System.Drawing.Point(202, 21);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(118, 13);
            this.lbldocumento.TabIndex = 6;
            this.lbldocumento.Text = "Número do documento:";
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "DESPESA FUNCIONÁRIOS",
            "DESPESA ESTOQUE",
            "DESPESA PATRIMONIAL",
            "TERCEIRIZAÇÃO",
            "IMPOSTOS"});
            this.cbtipo.Location = new System.Drawing.Point(46, 18);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(150, 21);
            this.cbtipo.TabIndex = 1;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(12, 21);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(31, 13);
            this.lbltipo.TabIndex = 0;
            this.lbltipo.Text = "Tipo:";
            // 
            // txtvalor
            // 
            this.txtvalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalor.Location = new System.Drawing.Point(46, 89);
            this.txtvalor.MaxLength = 20;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(79, 20);
            this.txtvalor.TabIndex = 5;
            this.txtvalor.Text = "0";
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(12, 92);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 8;
            this.lblvalor.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vencimento:";
            // 
            // dtvencimento
            // 
            this.dtvencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtvencimento.Location = new System.Drawing.Point(466, 89);
            this.dtvencimento.Name = "dtvencimento";
            this.dtvencimento.Size = new System.Drawing.Size(99, 20);
            this.dtvencimento.TabIndex = 7;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(397, 116);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // cbformapagamento
            // 
            this.cbformapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformapagamento.FormattingEnabled = true;
            this.cbformapagamento.Items.AddRange(new object[] {
            "CONTA CORRENTE PJ",
            "CONTA CORRENTE PF",
            "CAIXA FISICO"});
            this.cbformapagamento.Location = new System.Drawing.Point(251, 89);
            this.cbformapagamento.Name = "cbformapagamento";
            this.cbformapagamento.Size = new System.Drawing.Size(124, 21);
            this.cbformapagamento.TabIndex = 6;
            // 
            // lblformapagamento
            // 
            this.lblformapagamento.AutoSize = true;
            this.lblformapagamento.Location = new System.Drawing.Point(143, 92);
            this.lblformapagamento.Name = "lblformapagamento";
            this.lblformapagamento.Size = new System.Drawing.Size(110, 13);
            this.lblformapagamento.TabIndex = 13;
            this.lblformapagamento.Text = "Forma de pagamento:";
            // 
            // cbfavorecido
            // 
            this.cbfavorecido.FormattingEnabled = true;
            this.cbfavorecido.Location = new System.Drawing.Point(340, 52);
            this.cbfavorecido.MaxLength = 80;
            this.cbfavorecido.Name = "cbfavorecido";
            this.cbfavorecido.Size = new System.Drawing.Size(223, 21);
            this.cbfavorecido.TabIndex = 4;
            this.cbfavorecido.Leave += new System.EventHandler(this.cbfavorecido_Leave);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(478, 116);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Location = new System.Drawing.Point(12, 129);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(43, 13);
            this.lblcodigovenda.TabIndex = 15;
            this.lblcodigovenda.Text = "Código:";
            // 
            // frmcaddespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 151);
            this.Controls.Add(this.lblcodigovenda);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.cbfavorecido);
            this.Controls.Add(this.cbformapagamento);
            this.Controls.Add(this.lblformapagamento);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dtvencimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.lbldocumento);
            this.Controls.Add(this.lblfavorecido);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.lbltipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcaddespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento despesas";
            this.Load += new System.EventHandler(this.frmcaddespesas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lblfavorecido;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtvencimento;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.ComboBox cbformapagamento;
        private System.Windows.Forms.Label lblformapagamento;
        private System.Windows.Forms.ComboBox cbfavorecido;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcodigovenda;
    }
}