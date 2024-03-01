namespace Sistema_de_Vendas.Financeiro
{
    partial class frmcontasreceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontasreceber));
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(697, 19);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(81, 20);
            this.dtfinal.TabIndex = 3;            
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(629, 22);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 16;
            this.lbldatafinal.Text = "Data final:";
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(544, 19);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(81, 20);
            this.dtinicial.TabIndex = 2;            
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(476, 22);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 15;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(62, 19);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(288, 21);
            this.cbcliente.TabIndex = 1;
            this.cbcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbcliente_KeyPress);
            this.cbcliente.Leave += new System.EventHandler(this.cbcliente_Leave);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(14, 22);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 14;
            this.lblcliente.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(831, 375);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.BackgroundImage")));
            this.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpesquisar.Location = new System.Drawing.Point(784, 12);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnpesquisar.TabIndex = 17;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(730, 45);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(93, 23);
            this.btnexcluir.TabIndex = 18;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // frmcontasreceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dtfinal);
            this.Controls.Add(this.lbldatafinal);
            this.Controls.Add(this.dtinicial);
            this.Controls.Add(this.lbldatainicial);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcontasreceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à receber";
            this.Load += new System.EventHandler(this.frmcontasreceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnexcluir;
    }
}