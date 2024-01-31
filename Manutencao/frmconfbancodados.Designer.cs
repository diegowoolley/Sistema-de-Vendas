namespace Sistema_de_Vendas
{
    partial class frmconfbancodados
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
            this.lblservidor = new System.Windows.Forms.Label();
            this.lblbancodados = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblporta = new System.Windows.Forms.Label();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.txtbancodados = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtporta = new System.Windows.Forms.TextBox();
            this.btnteste = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(12, 19);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(49, 13);
            this.lblservidor.TabIndex = 0;
            this.lblservidor.Text = "Servidor:";
            // 
            // lblbancodados
            // 
            this.lblbancodados.AutoSize = true;
            this.lblbancodados.Location = new System.Drawing.Point(12, 47);
            this.lblbancodados.Name = "lblbancodados";
            this.lblbancodados.Size = new System.Drawing.Size(88, 13);
            this.lblbancodados.TabIndex = 1;
            this.lblbancodados.Text = "Banco de dados:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(12, 76);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuário:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(12, 102);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Senha:";
            // 
            // lblporta
            // 
            this.lblporta.AutoSize = true;
            this.lblporta.Location = new System.Drawing.Point(12, 132);
            this.lblporta.Name = "lblporta";
            this.lblporta.Size = new System.Drawing.Size(35, 13);
            this.lblporta.TabIndex = 4;
            this.lblporta.Text = "Porta:";
            // 
            // txtservidor
            // 
            this.txtservidor.Location = new System.Drawing.Point(113, 12);
            this.txtservidor.MaxLength = 255;
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(182, 20);
            this.txtservidor.TabIndex = 1;
            // 
            // txtbancodados
            // 
            this.txtbancodados.Location = new System.Drawing.Point(113, 40);
            this.txtbancodados.MaxLength = 255;
            this.txtbancodados.Name = "txtbancodados";
            this.txtbancodados.Size = new System.Drawing.Size(182, 20);
            this.txtbancodados.TabIndex = 2;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(113, 69);
            this.txtusuario.MaxLength = 255;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(182, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(113, 99);
            this.txtsenha.MaxLength = 255;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(182, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // txtporta
            // 
            this.txtporta.Location = new System.Drawing.Point(113, 125);
            this.txtporta.MaxLength = 255;
            this.txtporta.Name = "txtporta";
            this.txtporta.Size = new System.Drawing.Size(182, 20);
            this.txtporta.TabIndex = 5;
            // 
            // btnteste
            // 
            this.btnteste.Location = new System.Drawing.Point(93, 162);
            this.btnteste.Name = "btnteste";
            this.btnteste.Size = new System.Drawing.Size(116, 23);
            this.btnteste.TabIndex = 6;
            this.btnteste.Text = "Testar Conexão";
            this.btnteste.UseVisualStyleBackColor = true;
            this.btnteste.Click += new System.EventHandler(this.btnteste_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(244, 198);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(51, 24);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // frmconfbancodados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 234);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnteste);
            this.Controls.Add(this.txtporta);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtbancodados);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.lblporta);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblbancodados);
            this.Controls.Add(this.lblservidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmconfbancodados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do banco de dados";
            this.Load += new System.EventHandler(this.frmconfbancodados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Label lblbancodados;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblporta;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.TextBox txtbancodados;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtporta;
        private System.Windows.Forms.Button btnteste;
        private System.Windows.Forms.Button btnsalvar;
    }
}