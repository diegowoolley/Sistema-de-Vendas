namespace Sistema_de_Vendas.Financeiro
{
    partial class frmcontaspagar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblcliente = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(831, 379);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);            
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(14, 22);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 5;
            this.lblcliente.Text = "Cliente:";
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
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(476, 22);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 7;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(544, 19);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(81, 20);
            this.dtinicial.TabIndex = 2;
            this.dtinicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtinicial_KeyPress);
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(719, 19);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(81, 20);
            this.dtfinal.TabIndex = 3;
            this.dtfinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtfinal_KeyPress);
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(651, 22);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 9;
            this.lbldatafinal.Text = "Data final:";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(709, 45);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(101, 23);
            this.btnpesquisar.TabIndex = 10;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // frmcontaspagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
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
            this.Name = "frmcontaspagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à pagar";
            this.Load += new System.EventHandler(this.frmcontaspagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.Button btnpesquisar;
    }
}