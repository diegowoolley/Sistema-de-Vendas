using FoxLearn.License;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Configuracoes
{
    public partial class frmregistro : Form
    {
        public frmregistro()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        private void frmregistro_Load(object sender, EventArgs e)
        {
            txtidproduto.Text = ComputerInfo.GetComputerId();
        }

        #region BOTÕES
        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtchaveproduto.Text))
            {
                MessageBox.Show("Digite uma chave de ativação!");
                txtchaveproduto.Clear();
                txtchaveproduto.Focus();
                return;
            }

            try
            {                
                
                    con.AbrirConexao();

                    // Verificar se a chave já foi utilizada
                    using (MySqlCommand cmdVerificar = new MySqlCommand("SELECT * FROM licenca WHERE id_produto = @id_produto and chave_produto = @chave_produto", con.con))
                    {
                        cmdVerificar.Parameters.AddWithValue("@id_produto", txtidproduto.Text);
                        cmdVerificar.Parameters.AddWithValue("@chave_produto", txtchaveproduto.Text);

                        using (MySqlDataReader reader = cmdVerificar.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Essa é uma chave já usada anteriomente, o uso de chave anteriores pode implicar no travamento do sistema e perda de dados");
                                txtchaveproduto.Clear();
                                txtchaveproduto.Focus();
                                return;
                            }
                        }
                    }

                    // Verificar e salvar a chave
                    if (VerificarESalvarChave())
                    {
                        MessageBox.Show("Sistema Registrado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão: " + ex.Message, "Erro");
            }

        }

        #endregion

        #region MÉTODOS
        private bool VerificarESalvarChave()
        {
            KeyManager km = new KeyManager(txtidproduto.Text);
            string productKey = txtchaveproduto.Text;

            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    
                        LicenseInfo lic = new LicenseInfo();
                        lic.ProductKey = productKey;
                        lic.FullName = "DW SISTEMAS";

                        if (kv.Type == LicenseType.TRIAL)
                        {
                            lic.Day = kv.Expiration.Day;
                            lic.Month = kv.Expiration.Month;
                            lic.Year = kv.Expiration.Year;
                        }

                        km.SaveSuretyFile(String.Format(@"{0}\Key.pfx", Application.StartupPath), lic);

                        con.AbrirConexao();
                        sql = "INSERT INTO licenca(id_produto, chave_produto) VALUES (@id_produto, @chave_produto)";
                        cmd = new MySqlCommand(sql, con.con);
                        cmd.Parameters.AddWithValue("@id_produto", txtidproduto.Text);
                        cmd.Parameters.AddWithValue("@chave_produto", txtchaveproduto.Text);
                        cmd.ExecuteNonQuery();
                        con.FecharConexao();

                        return true;
                  
                }
            }

            MessageBox.Show("Chave do Produto é Inválida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        #endregion

    }
}



 