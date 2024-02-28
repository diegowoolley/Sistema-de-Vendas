namespace Sistema_de_Vendas.Configuracoes
{
    partial class frmlimpartabelas
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
            this.btnlimparvendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlimparvendas
            // 
            this.btnlimparvendas.Location = new System.Drawing.Point(120, 30);
            this.btnlimparvendas.Name = "btnlimparvendas";
            this.btnlimparvendas.Size = new System.Drawing.Size(138, 23);
            this.btnlimparvendas.TabIndex = 0;
            this.btnlimparvendas.Text = "Limpar Transações";
            this.btnlimparvendas.UseVisualStyleBackColor = true;
            this.btnlimparvendas.Click += new System.EventHandler(this.btnlimparvendas_Click);
            // 
            // frmlimpartabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 225);
            this.Controls.Add(this.btnlimparvendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlimpartabelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limpar tabelas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlimparvendas;
    }
}