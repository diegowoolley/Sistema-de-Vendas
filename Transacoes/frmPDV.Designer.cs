﻿namespace Sistema_de_Vendas.Transacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.valorun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnvendaavista = new System.Windows.Forms.Button();
            this.btnvendaaprazo = new System.Windows.Forms.Button();
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 167);
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
            this.label5.Location = new System.Drawing.Point(45, 284);
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
            this.label6.Location = new System.Drawing.Point(441, 284);
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
            this.label7.Location = new System.Drawing.Point(251, 423);
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
            this.label8.Location = new System.Drawing.Point(61, 423);
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
            this.label9.Location = new System.Drawing.Point(589, 423);
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
            this.label10.Location = new System.Drawing.Point(391, 580);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produto,
            this.descricao,
            this.quantidade,
            this.valorun,
            this.valor_total});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(778, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(585, 451);
            this.dataGridView1.TabIndex = 25;
            // 
            // cod_produto
            // 
            this.cod_produto.HeaderText = "Código";
            this.cod_produto.Name = "cod_produto";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valorun
            // 
            this.valorun.HeaderText = "Valor unitário";
            this.valorun.Name = "valorun";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Subtotal";
            this.valor_total.Name = "valor_total";
            // 
            // btnvendaavista
            // 
            this.btnvendaavista.Location = new System.Drawing.Point(4, 593);
            this.btnvendaavista.Name = "btnvendaavista";
            this.btnvendaavista.Size = new System.Drawing.Size(108, 23);
            this.btnvendaavista.TabIndex = 4;
            this.btnvendaavista.Text = "Venda á vista";
            this.btnvendaavista.UseVisualStyleBackColor = true;
            // 
            // btnvendaaprazo
            // 
            this.btnvendaaprazo.Location = new System.Drawing.Point(129, 593);
            this.btnvendaaprazo.Name = "btnvendaaprazo";
            this.btnvendaaprazo.Size = new System.Drawing.Size(109, 23);
            this.btnvendaaprazo.TabIndex = 5;
            this.btnvendaaprazo.Text = "Venda á prazo";
            this.btnvendaaprazo.UseVisualStyleBackColor = true;
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
            this.txttotalpagar.Location = new System.Drawing.Point(497, 580);
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
            this.txtsubtotal.Location = new System.Drawing.Point(497, 452);
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
            this.txtvalorun.Location = new System.Drawing.Point(233, 452);
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
            this.txtquantidadeun.Location = new System.Drawing.Point(37, 452);
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
            this.txtdescricao.Location = new System.Drawing.Point(233, 313);
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
            this.txtitens.Location = new System.Drawing.Point(37, 313);
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
            // btncancelar
            // 
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(258, 593);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(118, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar venda";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigovenda.ForeColor = System.Drawing.Color.White;
            this.lblcodigovenda.Location = new System.Drawing.Point(0, 138);
            this.lblcodigovenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(154, 20);
            this.lblcodigovenda.TabIndex = 12;
            this.lblcodigovenda.Text = "Número da venda:";
            // 
            // frmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 633);
            this.Controls.Add(this.lblcodigovenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnvendaaprazo);
            this.Controls.Add(this.btnvendaavista);
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
            this.Load += new System.EventHandler(this.frmPDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnvendaavista;
        private System.Windows.Forms.Button btnvendaaprazo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtvalorun;
        private System.Windows.Forms.TextBox txtquantidadeun;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtitens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorun;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod_barras;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label lblcodigovenda;
    }
}