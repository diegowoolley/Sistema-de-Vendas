namespace Sistema_de_Vendas.Configuracoes
{
    partial class frmregistro
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
            this.lblchaveproduto = new System.Windows.Forms.Label();
            this.txtidproduto = new System.Windows.Forms.TextBox();
            this.txtchaveproduto = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblidproduto
            // 
            this.lblidproduto.AutoSize = true;
            this.lblidproduto.Location = new System.Drawing.Point(12, 22);
            this.lblidproduto.Name = "lblidproduto";
            this.lblidproduto.Size = new System.Drawing.Size(60, 13);
            this.lblidproduto.TabIndex = 0;
            this.lblidproduto.Text = "ID produto:";
            // 
            // lblchaveproduto
            // 
            this.lblchaveproduto.AutoSize = true;
            this.lblchaveproduto.Location = new System.Drawing.Point(12, 54);
            this.lblchaveproduto.Name = "lblchaveproduto";
            this.lblchaveproduto.Size = new System.Drawing.Size(96, 13);
            this.lblchaveproduto.TabIndex = 1;
            this.lblchaveproduto.Text = "Chave do Produto:";
            // 
            // txtidproduto
            // 
            this.txtidproduto.Location = new System.Drawing.Point(113, 19);
            this.txtidproduto.Name = "txtidproduto";
            this.txtidproduto.ReadOnly = true;
            this.txtidproduto.Size = new System.Drawing.Size(283, 20);
            this.txtidproduto.TabIndex = 2;
            // 
            // txtchaveproduto
            // 
            this.txtchaveproduto.Location = new System.Drawing.Point(113, 51);
            this.txtchaveproduto.Name = "txtchaveproduto";
            this.txtchaveproduto.Size = new System.Drawing.Size(283, 20);
            this.txtchaveproduto.TabIndex = 3;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(321, 88);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 119);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtchaveproduto);
            this.Controls.Add(this.txtidproduto);
            this.Controls.Add(this.lblchaveproduto);
            this.Controls.Add(this.lblidproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmregistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Software";
            this.Load += new System.EventHandler(this.frmregistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidproduto;
        private System.Windows.Forms.Label lblchaveproduto;
        private System.Windows.Forms.TextBox txtidproduto;
        private System.Windows.Forms.TextBox txtchaveproduto;
        private System.Windows.Forms.Button btnok;
    }
}