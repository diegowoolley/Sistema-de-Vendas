﻿namespace Sistema_de_Vendas.Ordem_de_Serviço
{
    partial class frmlistarOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistarOS));
            this.btnadicionaros = new System.Windows.Forms.Button();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.lblclientes = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnlistar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadicionaros
            // 
            this.btnadicionaros.Location = new System.Drawing.Point(620, 48);
            this.btnadicionaros.Name = "btnadicionaros";
            this.btnadicionaros.Size = new System.Drawing.Size(119, 23);
            this.btnadicionaros.TabIndex = 6;
            this.btnadicionaros.Text = "Adicionar \\ Alterar OS";
            this.btnadicionaros.UseVisualStyleBackColor = true;
            this.btnadicionaros.Click += new System.EventHandler(this.btnadicionaros_Click);
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(58, 15);
            this.cbclientes.MaxLength = 80;
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(241, 21);
            this.cbclientes.TabIndex = 1;
            this.cbclientes.Leave += new System.EventHandler(this.cbclientes_Leave);
            // 
            // lblclientes
            // 
            this.lblclientes.AutoSize = true;
            this.lblclientes.Location = new System.Drawing.Point(12, 18);
            this.lblclientes.Name = "lblclientes";
            this.lblclientes.Size = new System.Drawing.Size(42, 13);
            this.lblclientes.TabIndex = 2;
            this.lblclientes.Text = "Cliente:";
            // 
            // cbstatus
            // 
            this.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "ABERTO",
            "EM ANDAMENTO",
            "ORÇAMENTO",
            "FINALIZADO",
            "CANCELADO",
            "AGUARDANDO PEÇAS",
            "APROVADO"});
            this.cbstatus.Location = new System.Drawing.Point(347, 17);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(169, 21);
            this.cbstatus.TabIndex = 2;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(305, 20);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "Status:";
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(584, 16);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(95, 20);
            this.dtinicial.TabIndex = 3;
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(522, 20);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 6;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(685, 20);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 8;
            this.lbldatafinal.Text = "Data final:";
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(740, 15);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(95, 20);
            this.dtfinal.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(868, 395);
            this.dataGridView1.TabIndex = 71;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.BackgroundImage")));
            this.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpesquisar.Location = new System.Drawing.Point(839, 10);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnpesquisar.TabIndex = 5;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(740, 48);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(107, 23);
            this.btnlistar.TabIndex = 72;
            this.btnlistar.Text = "Listar todas OS\'s";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // frmlistarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 474);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldatafinal);
            this.Controls.Add(this.dtfinal);
            this.Controls.Add(this.lbldatainicial);
            this.Controls.Add(this.dtinicial);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.lblclientes);
            this.Controls.Add(this.cbclientes);
            this.Controls.Add(this.btnadicionaros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlistarOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de serviço";
            this.Activated += new System.EventHandler(this.frmlistarOS_Activated);
            this.Load += new System.EventHandler(this.frmlistarOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadicionaros;
        private System.Windows.Forms.ComboBox cbclientes;
        private System.Windows.Forms.Label lblclientes;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnlistar;
    }
}