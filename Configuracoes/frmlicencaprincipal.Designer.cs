namespace Sistema_de_Vendas.Configuracoes
{
    partial class frmlicencaprincipal
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
            this.btngerar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(12, 44);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(75, 23);
            this.btngerar.TabIndex = 0;
            this.btngerar.Text = "Gerar";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(117, 44);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnsobre
            // 
            this.btnsobre.Location = new System.Drawing.Point(226, 44);
            this.btnsobre.Name = "btnsobre";
            this.btnsobre.Size = new System.Drawing.Size(75, 23);
            this.btnsobre.TabIndex = 2;
            this.btnsobre.Text = "Sobre";
            this.btnsobre.UseVisualStyleBackColor = true;
            this.btnsobre.Click += new System.EventHandler(this.btnsobre_Click);
            // 
            // frmlicencaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 99);
            this.Controls.Add(this.btnsobre);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btngerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlicencaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Licença";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsobre;
    }
}