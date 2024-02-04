using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void frmregistro_Load(object sender, EventArgs e)
        {
            txtidproduto.Text = ComputerInfo.GetComputerId();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtidproduto.Text);
            string productKey = txtchaveproduto.Text;

            if(km.ValidKey(ref productKey))
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
                    km.SaveSuretyFile(String.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("Sistema Registrado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            else
                MessageBox.Show("Chave do Produto é Inválida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
