namespace Sistema_de_Vendas.Configuracoes
{
    partial class frmsobre
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
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnomeproduto = new System.Windows.Forms.Label();
            this.lblidproduto = new System.Windows.Forms.Label();
            this.lblchaveproduto = new System.Windows.Forms.Label();
            this.lbltipolicenca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(148, 149);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chave do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Licença:";
            // 
            // lblnomeproduto
            // 
            this.lblnomeproduto.AutoSize = true;
            this.lblnomeproduto.Location = new System.Drawing.Point(123, 18);
            this.lblnomeproduto.Name = "lblnomeproduto";
            this.lblnomeproduto.Size = new System.Drawing.Size(13, 13);
            this.lblnomeproduto.TabIndex = 5;
            this.lblnomeproduto.Text = "?";
            // 
            // lblidproduto
            // 
            this.lblidproduto.AutoSize = true;
            this.lblidproduto.Location = new System.Drawing.Point(123, 46);
            this.lblidproduto.Name = "lblidproduto";
            this.lblidproduto.Size = new System.Drawing.Size(13, 13);
            this.lblidproduto.TabIndex = 6;
            this.lblidproduto.Text = "?";
            // 
            // lblchaveproduto
            // 
            this.lblchaveproduto.AutoSize = true;
            this.lblchaveproduto.Location = new System.Drawing.Point(123, 73);
            this.lblchaveproduto.Name = "lblchaveproduto";
            this.lblchaveproduto.Size = new System.Drawing.Size(13, 13);
            this.lblchaveproduto.TabIndex = 7;
            this.lblchaveproduto.Text = "?";
            // 
            // lbltipolicenca
            // 
            this.lbltipolicenca.AutoSize = true;
            this.lbltipolicenca.Location = new System.Drawing.Point(123, 103);
            this.lbltipolicenca.Name = "lbltipolicenca";
            this.lbltipolicenca.Size = new System.Drawing.Size(13, 13);
            this.lbltipolicenca.TabIndex = 8;
            this.lbltipolicenca.Text = "?";
            // 
            // frmsobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 184);
            this.Controls.Add(this.lbltipolicenca);
            this.Controls.Add(this.lblchaveproduto);
            this.Controls.Add(this.lblidproduto);
            this.Controls.Add(this.lblnomeproduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmsobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnomeproduto;
        private System.Windows.Forms.Label lblidproduto;
        private System.Windows.Forms.Label lblchaveproduto;
        private System.Windows.Forms.Label lbltipolicenca;
    }
}