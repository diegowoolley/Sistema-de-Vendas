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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontaspagar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblfavorecido = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(831, 379);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblfavorecido
            // 
            this.lblfavorecido.AutoSize = true;
            this.lblfavorecido.Location = new System.Drawing.Point(205, 22);
            this.lblfavorecido.Name = "lblfavorecido";
            this.lblfavorecido.Size = new System.Drawing.Size(63, 13);
            this.lblfavorecido.TabIndex = 5;
            this.lblfavorecido.Text = "Favorecido:";
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(268, 19);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(224, 21);
            this.cbcliente.TabIndex = 2;
            this.cbcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbcliente_KeyPress);
            this.cbcliente.Leave += new System.EventHandler(this.cbcliente_Leave);
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Location = new System.Drawing.Point(496, 22);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(62, 13);
            this.lbldatainicial.TabIndex = 7;
            this.lbldatainicial.Text = "Data inicial:";
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(560, 19);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(81, 20);
            this.dtinicial.TabIndex = 3;
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(699, 19);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(81, 20);
            this.dtfinal.TabIndex = 4;
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Location = new System.Drawing.Point(642, 22);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(55, 13);
            this.lbldatafinal.TabIndex = 9;
            this.lbldatafinal.Text = "Data final:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nova despesa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "COMPRA",
            "DESPESA FUNCIONÁRIOS",
            "DESPESA ESTOQUE",
            "DESPESA PATRIMONIAL",
            "TERCEIRIZAÇÃO",
            "IMPOSTOS"});
            this.cbtipo.Location = new System.Drawing.Point(42, 18);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(157, 21);
            this.cbtipo.TabIndex = 1;
            this.cbtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtipo_KeyPress);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(5, 22);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(31, 13);
            this.lbltipo.TabIndex = 13;
            this.lbltipo.Text = "Tipo:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(723, 45);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(93, 23);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.BackgroundImage")));
            this.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpesquisar.Location = new System.Drawing.Point(791, 12);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnpesquisar.TabIndex = 5;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // frmcontaspagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dtfinal);
            this.Controls.Add(this.lbldatafinal);
            this.Controls.Add(this.dtinicial);
            this.Controls.Add(this.lbldatainicial);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.lblfavorecido);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcontaspagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à pagar";
            this.Activated += new System.EventHandler(this.frmcontaspagar_Activated);
            this.Load += new System.EventHandler(this.frmcontaspagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblfavorecido;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Button btnexcluir;
    }
}