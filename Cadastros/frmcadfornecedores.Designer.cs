namespace Sistema_de_Vendas
{
    partial class frmcadfornecedores
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnfoto = new System.Windows.Forms.Button();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.cbestados = new System.Windows.Forms.ComboBox();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.pnpesquisa = new System.Windows.Forms.Panel();
            this.btncancelarpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.lblnomepesquisa = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnpesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 9);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(106, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome/Razão Social:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(12, 58);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 1;
            this.lblendereco.Text = "Endereço:";
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Location = new System.Drawing.Point(325, 9);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(52, 13);
            this.lbldocumento.TabIndex = 2;
            this.lbldocumento.Text = "Cpf/Cnpj:";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(12, 112);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(52, 13);
            this.lbltelefone.TabIndex = 3;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(326, 112);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(42, 13);
            this.lblcelular.TabIndex = 4;
            this.lblcelular.Text = "Celular:";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(124, 6);
            this.txtnome.MaxLength = 80;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(195, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtendereco
            // 
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Enabled = false;
            this.txtendereco.Location = new System.Drawing.Point(124, 55);
            this.txtendereco.MaxLength = 80;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(195, 20);
            this.txtendereco.TabIndex = 4;
            // 
            // txttelefone
            // 
            this.txttelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttelefone.Enabled = false;
            this.txttelefone.Location = new System.Drawing.Point(124, 107);
            this.txttelefone.MaxLength = 11;
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(95, 20);
            this.txttelefone.TabIndex = 9;
            this.txttelefone.Enter += new System.EventHandler(this.txttelefone_Enter);
            this.txttelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefone_KeyPress);
            this.txttelefone.Leave += new System.EventHandler(this.txttelefone_Leave);
            // 
            // txtdocumento
            // 
            this.txtdocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdocumento.Enabled = false;
            this.txtdocumento.Location = new System.Drawing.Point(383, 6);
            this.txtdocumento.MaxLength = 14;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(195, 20);
            this.txtdocumento.TabIndex = 2;
            this.txtdocumento.Enter += new System.EventHandler(this.txtdocumento_Enter);
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            this.txtdocumento.Leave += new System.EventHandler(this.txtdocumento_Leave);
            // 
            // txtcelular
            // 
            this.txtcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcelular.Enabled = false;
            this.txtcelular.Location = new System.Drawing.Point(383, 107);
            this.txtcelular.MaxLength = 11;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(95, 20);
            this.txtcelular.TabIndex = 10;
            this.txtcelular.Enter += new System.EventHandler(this.txtcelular_Enter);
            this.txtcelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcelular_KeyPress);
            this.txtcelular.Leave += new System.EventHandler(this.txtcelular_Leave);
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCliente.Location = new System.Drawing.Point(15, 144);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCliente.Size = new System.Drawing.Size(763, 150);
            this.dgCliente.TabIndex = 19;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 312);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(111, 312);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(209, 312);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(302, 312);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(392, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Enabled = false;
            this.btnfoto.Location = new System.Drawing.Point(594, 37);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(75, 23);
            this.btnfoto.TabIndex = 16;
            this.btnfoto.Text = "foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(325, 58);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(37, 13);
            this.lblbairro.TabIndex = 34;
            this.lblbairro.Text = "Bairro:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(489, 58);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(47, 13);
            this.lblnumero.TabIndex = 15;
            this.lblnumero.Text = "Número:";
            // 
            // txtbairro
            // 
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(383, 53);
            this.txtbairro.MaxLength = 80;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 20);
            this.txtbairro.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(534, 55);
            this.txtnumero.MaxLength = 20;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(44, 20);
            this.txtnumero.TabIndex = 6;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(675, 6);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 84);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 6;
            this.pbFoto.TabStop = false;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(12, 84);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 35;
            this.lblcidade.Text = "Cidade:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(325, 84);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 36;
            this.lblestado.Text = "Estado:";
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Enabled = false;
            this.txtcidade.Location = new System.Drawing.Point(124, 81);
            this.txtcidade.MaxLength = 80;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 7;
            // 
            // cbestados
            // 
            this.cbestados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestados.Enabled = false;
            this.cbestados.FormattingEnabled = true;
            this.cbestados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbestados.Location = new System.Drawing.Point(384, 80);
            this.cbestados.Name = "cbestados";
            this.cbestados.Size = new System.Drawing.Size(44, 21);
            this.cbestados.TabIndex = 8;
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.Location = new System.Drawing.Point(518, 128);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(173, 13);
            this.lblpesquisa.TabIndex = 67;
            this.lblpesquisa.Text = "(Dê duplo click para abrir pesquisa)";
            this.lblpesquisa.DoubleClick += new System.EventHandler(this.lblpesquisa_DoubleClick);
            // 
            // pnpesquisa
            // 
            this.pnpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpesquisa.Controls.Add(this.btncancelarpesquisa);
            this.pnpesquisa.Controls.Add(this.txtpesquisa);
            this.pnpesquisa.Controls.Add(this.lblnomepesquisa);
            this.pnpesquisa.Location = new System.Drawing.Point(506, 147);
            this.pnpesquisa.Name = "pnpesquisa";
            this.pnpesquisa.Size = new System.Drawing.Size(206, 131);
            this.pnpesquisa.TabIndex = 66;
            this.pnpesquisa.Visible = false;
            this.pnpesquisa.Leave += new System.EventHandler(this.pnpesquisa_Leave);
            // 
            // btncancelarpesquisa
            // 
            this.btncancelarpesquisa.Enabled = false;
            this.btncancelarpesquisa.Location = new System.Drawing.Point(61, 101);
            this.btncancelarpesquisa.Name = "btncancelarpesquisa";
            this.btncancelarpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btncancelarpesquisa.TabIndex = 18;
            this.btncancelarpesquisa.Text = "fechar";
            this.btncancelarpesquisa.UseVisualStyleBackColor = true;
            this.btncancelarpesquisa.Click += new System.EventHandler(this.btncancelarpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisa.Enabled = false;
            this.txtpesquisa.Location = new System.Drawing.Point(3, 30);
            this.txtpesquisa.MaxLength = 80;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(195, 20);
            this.txtpesquisa.TabIndex = 17;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtnomepesquisa_TextChanged);
            // 
            // lblnomepesquisa
            // 
            this.lblnomepesquisa.AutoSize = true;
            this.lblnomepesquisa.Location = new System.Drawing.Point(23, 14);
            this.lblnomepesquisa.Name = "lblnomepesquisa";
            this.lblnomepesquisa.Size = new System.Drawing.Size(153, 13);
            this.lblnomepesquisa.TabIndex = 2;
            this.lblnomepesquisa.Text = "Pesquisar Nome / Documento:";
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(124, 31);
            this.txtemail.MaxLength = 80;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(195, 20);
            this.txtemail.TabIndex = 3;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(12, 34);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 68;
            this.lblemail.Text = "E-mail:";
            // 
            // frmcadfornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 347);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblpesquisa);
            this.Controls.Add(this.pnpesquisa);
            this.Controls.Add(this.cbestados);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lbldocumento);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcadfornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmcadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnpesquisa.ResumeLayout(false);
            this.pnpesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.ComboBox cbestados;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.Panel pnpesquisa;
        private System.Windows.Forms.Button btncancelarpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label lblnomepesquisa;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
    }
}