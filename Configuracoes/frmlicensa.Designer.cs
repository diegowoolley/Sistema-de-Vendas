namespace Sistema_de_Vendas.Configuracoes
{
    partial class frmlicensa
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
            this.lblidproduto = new System.Windows.Forms.Label();
            this.lbltipolicenca = new System.Windows.Forms.Label();
            this.lbldiasteste = new System.Windows.Forms.Label();
            this.lblchaveproduto = new System.Windows.Forms.Label();
            this.btngerar = new System.Windows.Forms.Button();
            this.txtidproduto = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtdiasteste = new System.Windows.Forms.TextBox();
            this.txtchaveproduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblidproduto
            // 
            this.lblidproduto.AutoSize = true;
            this.lblidproduto.Location = new System.Drawing.Point(9, 30);
            this.lblidproduto.Name = "lblidproduto";
            this.lblidproduto.Size = new System.Drawing.Size(75, 13);
            this.lblidproduto.TabIndex = 0;
            this.lblidproduto.Text = "ID do produto:";
            // 
            // lbltipolicenca
            // 
            this.lbltipolicenca.AutoSize = true;
            this.lbltipolicenca.Location = new System.Drawing.Point(9, 57);
            this.lbltipolicenca.Name = "lbltipolicenca";
            this.lbltipolicenca.Size = new System.Drawing.Size(87, 13);
            this.lbltipolicenca.TabIndex = 1;
            this.lbltipolicenca.Text = "Tipo da Licença:";
            // 
            // lbldiasteste
            // 
            this.lbldiasteste.AutoSize = true;
            this.lbldiasteste.Location = new System.Drawing.Point(9, 84);
            this.lbldiasteste.Name = "lbldiasteste";
            this.lbldiasteste.Size = new System.Drawing.Size(85, 13);
            this.lbldiasteste.TabIndex = 2;
            this.lbldiasteste.Text = "Dias para Teste:";
            // 
            // lblchaveproduto
            // 
            this.lblchaveproduto.AutoSize = true;
            this.lblchaveproduto.Location = new System.Drawing.Point(9, 115);
            this.lblchaveproduto.Name = "lblchaveproduto";
            this.lblchaveproduto.Size = new System.Drawing.Size(95, 13);
            this.lblchaveproduto.TabIndex = 3;
            this.lblchaveproduto.Text = "Chave do produto:";
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(230, 138);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(66, 20);
            this.btngerar.TabIndex = 4;
            this.btngerar.Text = "Gerar";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // txtidproduto
            // 
            this.txtidproduto.Location = new System.Drawing.Point(105, 27);
            this.txtidproduto.Name = "txtidproduto";
            this.txtidproduto.Size = new System.Drawing.Size(375, 20);
            this.txtidproduto.TabIndex = 5;
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Full",
            "Trial"});
            this.cbtipo.Location = new System.Drawing.Point(105, 54);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 21);
            this.cbtipo.TabIndex = 6;
            // 
            // txtdiasteste
            // 
            this.txtdiasteste.Location = new System.Drawing.Point(105, 81);
            this.txtdiasteste.Name = "txtdiasteste";
            this.txtdiasteste.Size = new System.Drawing.Size(46, 20);
            this.txtdiasteste.TabIndex = 7;
            // 
            // txtchaveproduto
            // 
            this.txtchaveproduto.Location = new System.Drawing.Point(105, 112);
            this.txtchaveproduto.Name = "txtchaveproduto";
            this.txtchaveproduto.ReadOnly = true;
            this.txtchaveproduto.Size = new System.Drawing.Size(375, 20);
            this.txtchaveproduto.TabIndex = 8;
            // 
            // frmlicensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 170);
            this.Controls.Add(this.txtchaveproduto);
            this.Controls.Add(this.txtdiasteste);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.txtidproduto);
            this.Controls.Add(this.btngerar);
            this.Controls.Add(this.lblchaveproduto);
            this.Controls.Add(this.lbldiasteste);
            this.Controls.Add(this.lbltipolicenca);
            this.Controls.Add(this.lblidproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlicensa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Licença";
            this.Load += new System.EventHandler(this.frmlicensa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidproduto;
        private System.Windows.Forms.Label lbltipolicenca;
        private System.Windows.Forms.Label lbldiasteste;
        private System.Windows.Forms.Label lblchaveproduto;
        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.TextBox txtidproduto;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox txtdiasteste;
        private System.Windows.Forms.TextBox txtchaveproduto;
    }
}