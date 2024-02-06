namespace Sistema_de_Vendas
{
    partial class inventario
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
            this.lblpesquisar = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnestoqueminimo = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.btnlistarvalidade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(4, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblpesquisar
            // 
            this.lblpesquisar.AutoSize = true;
            this.lblpesquisar.Location = new System.Drawing.Point(1, 22);
            this.lblpesquisar.Name = "lblpesquisar";
            this.lblpesquisar.Size = new System.Drawing.Size(96, 13);
            this.lblpesquisar.TabIndex = 1;
            this.lblpesquisar.Text = "Pesquisar Produto:";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisa.Location = new System.Drawing.Point(98, 19);
            this.txtpesquisa.MaxLength = 80;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(331, 20);
            this.txtpesquisa.TabIndex = 1;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(434, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o código, nome ou use o leitor de código de barras para buscar o produto";
            // 
            // btnestoqueminimo
            // 
            this.btnestoqueminimo.Location = new System.Drawing.Point(4, 452);
            this.btnestoqueminimo.Name = "btnestoqueminimo";
            this.btnestoqueminimo.Size = new System.Drawing.Size(195, 23);
            this.btnestoqueminimo.TabIndex = 3;
            this.btnestoqueminimo.Text = "Listar produtos com estoque defazado";
            this.btnestoqueminimo.UseVisualStyleBackColor = true;
            this.btnestoqueminimo.Click += new System.EventHandler(this.btnestoqueminimo_Click);
            // 
            // btninventario
            // 
            this.btninventario.Location = new System.Drawing.Point(635, 452);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(195, 23);
            this.btninventario.TabIndex = 4;
            this.btninventario.Text = "Listar inventário completo";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // btnlistarvalidade
            // 
            this.btnlistarvalidade.Location = new System.Drawing.Point(656, 0);
            this.btnlistarvalidade.Name = "btnlistarvalidade";
            this.btnlistarvalidade.Size = new System.Drawing.Size(174, 23);
            this.btnlistarvalidade.TabIndex = 5;
            this.btnlistarvalidade.Text = "Listar produtos próximos a vencer";
            this.btnlistarvalidade.UseVisualStyleBackColor = true;
            this.btnlistarvalidade.Click += new System.EventHandler(this.btnlistarvalidade_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(435, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de produtos próximos a vencer:";
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlistarvalidade);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.btnestoqueminimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.lblpesquisar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnestoqueminimo;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btnlistarvalidade;
        private System.Windows.Forms.Label label2;
    }
}