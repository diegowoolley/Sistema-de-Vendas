﻿namespace Sistema_de_Vendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.txtmargemlucro = new System.Windows.Forms.TextBox();
            this.pnpesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelarpesquisa
            // 
            this.btncancelarpesquisa.Enabled = false;
            this.btncancelarpesquisa.Location = new System.Drawing.Point(77, 102);
            this.btncancelarpesquisa.Name = "btncancelarpesquisa";
            this.btncancelarpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btncancelarpesquisa.TabIndex = 22;
            this.btncancelarpesquisa.Text = "fechar";
            this.btncancelarpesquisa.UseVisualStyleBackColor = true;
            // 
            // lblnomepesquisa
            // 
            this.lblnomepesquisa.AutoSize = true;
            this.lblnomepesquisa.Location = new System.Drawing.Point(32, 15);
            this.lblnomepesquisa.Name = "lblnomepesquisa";
            this.lblnomepesquisa.Size = new System.Drawing.Size(150, 13);
            this.lblnomepesquisa.TabIndex = 2;
            this.lblnomepesquisa.Text = "Pesquisar Nome\\ Documento:";
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.Location = new System.Drawing.Point(583, 127);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(173, 13);
            this.lblpesquisa.TabIndex = 96;
            this.lblpesquisa.Text = "(Dê duplo click para abrir pesquisa)";
            // 
            // pnpesquisa
            // 
            this.pnpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpesquisa.Controls.Add(this.btncancelarpesquisa);
            this.pnpesquisa.Controls.Add(this.txtpesquisa);
            this.pnpesquisa.Controls.Add(this.lblnomepesquisa);
            this.pnpesquisa.Location = new System.Drawing.Point(571, 146);
            this.pnpesquisa.Name = "pnpesquisa";
            this.pnpesquisa.Size = new System.Drawing.Size(206, 131);
            this.pnpesquisa.TabIndex = 95;
            this.pnpesquisa.Visible = false;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisa.Enabled = false;
            this.txtpesquisa.Location = new System.Drawing.Point(13, 31);
            this.txtpesquisa.MaxLength = 100;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(195, 20);
            this.txtpesquisa.TabIndex = 3;
            // 
            // lbladicionarcategorias
            // 
            this.lbladicionarcategorias.AutoSize = true;
            this.lbladicionarcategorias.Location = new System.Drawing.Point(568, 109);
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
            this.txtfabricante.Location = new System.Drawing.Point(126, 63);
            this.txtfabricante.MaxLength = 80;
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(195, 20);
            this.txtfabricante.TabIndex = 71;
            // 
            // lblfabricante
            // 
            this.lblfabricante.AutoSize = true;
            this.lblfabricante.Location = new System.Drawing.Point(14, 66);
            this.lblfabricante.Name = "lblfabricante";
            this.lblfabricante.Size = new System.Drawing.Size(60, 13);
            this.lblfabricante.TabIndex = 92;
            this.lblfabricante.Text = "Fabricante:";
            // 
            // btnfoto
            // 
            this.btnfoto.Enabled = false;
            this.btnfoto.Location = new System.Drawing.Point(596, 40);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(75, 23);
            this.btnfoto.TabIndex = 81;
            this.btnfoto.Text = "foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(394, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(304, 315);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 79;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(211, 315);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 78;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(113, 315);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 77;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 315);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 76;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCliente.Location = new System.Drawing.Point(17, 147);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCliente.Size = new System.Drawing.Size(763, 150);
            this.dgCliente.TabIndex = 82;
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(677, 9);
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
            this.txtvalorcompra.Location = new System.Drawing.Point(126, 89);
            this.txtvalorcompra.MaxLength = 11;
            this.txtvalorcompra.Name = "txtvalorcompra";
            this.txtvalorcompra.Size = new System.Drawing.Size(95, 20);
            this.txtvalorcompra.TabIndex = 73;
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(126, 9);
            this.txtdescricao.MaxLength = 100;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(195, 20);
            this.txtdescricao.TabIndex = 66;
            // 
            // lblmargemlucro
            // 
            this.lblmargemlucro.AutoSize = true;
            this.lblmargemlucro.Location = new System.Drawing.Point(14, 118);
            this.lblmargemlucro.Name = "lblmargemlucro";
            this.lblmargemlucro.Size = new System.Drawing.Size(93, 13);
            this.lblmargemlucro.TabIndex = 88;
            this.lblmargemlucro.Text = "Margem de Lucro:";
            // 
            // lblvalorcompra
            // 
            this.lblvalorcompra.AutoSize = true;
            this.lblvalorcompra.Location = new System.Drawing.Point(14, 94);
            this.lblvalorcompra.Name = "lblvalorcompra";
            this.lblvalorcompra.Size = new System.Drawing.Size(88, 13);
            this.lblvalorcompra.TabIndex = 87;
            this.lblvalorcompra.Text = "Valor de Compra:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(328, 12);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 86;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(14, 12);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(113, 13);
            this.lbldescricao.TabIndex = 84;
            this.lbldescricao.Text = "Descrição do Produto:";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.Enabled = false;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(395, 6);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(195, 21);
            this.cbcategoria.TabIndex = 97;
            // 
            // cbunidade
            // 
            this.cbunidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunidade.Enabled = false;
            this.cbunidade.FormattingEnabled = true;
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
            this.cbunidade.Location = new System.Drawing.Point(126, 34);
            this.cbunidade.Name = "cbunidade";
            this.cbunidade.Size = new System.Drawing.Size(51, 21);
            this.cbunidade.TabIndex = 99;
            // 
            // lblunidadade
            // 
            this.lblunidadade.AutoSize = true;
            this.lblunidadade.Location = new System.Drawing.Point(14, 38);
            this.lblunidadade.Name = "lblunidadade";
            this.lblunidadade.Size = new System.Drawing.Size(103, 13);
            this.lblunidadade.TabIndex = 98;
            this.lblunidadade.Text = "Unidade de Medida:";
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfornecedor.Enabled = false;
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(395, 35);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(195, 21);
            this.cbfornecedor.TabIndex = 101;
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.Location = new System.Drawing.Point(328, 40);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblfornecedor.TabIndex = 100;
            this.lblfornecedor.Text = "Fornecedor:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtquantidade.Enabled = false;
            this.txtquantidade.Location = new System.Drawing.Point(249, 34);
            this.txtquantidade.MaxLength = 11;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(73, 20);
            this.txtquantidade.TabIndex = 103;
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalorvenda.Enabled = false;
            this.txtvalorvenda.Location = new System.Drawing.Point(288, 89);
            this.txtvalorvenda.MaxLength = 11;
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(95, 20);
            this.txtvalorvenda.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Valor Venda:";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(183, 38);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 105;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // txtmargemlucro
            // 
            this.txtmargemlucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmargemlucro.Enabled = false;
            this.txtmargemlucro.Location = new System.Drawing.Point(126, 115);
            this.txtmargemlucro.MaxLength = 11;
            this.txtmargemlucro.Name = "txtmargemlucro";
            this.txtmargemlucro.Size = new System.Drawing.Size(95, 20);
            this.txtmargemlucro.TabIndex = 74;
            // 
            // frmcadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 347);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtvalorvenda);
            this.Controls.Add(this.label1);
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
            this.pnpesquisa.ResumeLayout(false);
            this.pnpesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox txtmargemlucro;
    }
}