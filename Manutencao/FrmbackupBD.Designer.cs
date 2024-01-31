namespace Sistema_de_Vendas
{
    partial class FrmbackupBD
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
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(1, 2);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(284, 99);
            this.btnbackup.TabIndex = 0;
            this.btnbackup.Text = "Backup Banco de dados";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Location = new System.Drawing.Point(1, 104);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(284, 108);
            this.btnrestaurar.TabIndex = 1;
            this.btnrestaurar.Text = "Restaurar banco de dados";
            this.btnrestaurar.UseVisualStyleBackColor = true;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // FrmbackupBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 217);
            this.Controls.Add(this.btnrestaurar);
            this.Controls.Add(this.btnbackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmbackupBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup \\ Restatauração BD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnrestaurar;
    }
}