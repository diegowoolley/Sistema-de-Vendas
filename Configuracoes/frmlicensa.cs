using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Configuracoes
{
    public partial class frmlicensa : Form
    {
        public frmlicensa()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;

        private void frmlicensa_Load(object sender, EventArgs e)
        {
            cbtipo.SelectedIndex = 0;
            txtidproduto.Text = ComputerInfo.GetComputerId();
        }
        
        private void btngerar_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtidproduto.Text);
            KeyValuesClass kv;
            String productKey = String.Empty;
            if (cbtipo.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (Byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };
                if (!km.GenerateKey(kv, ref productKey))

                    txtchaveproduto.Text = "ERRO";
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (Byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtdiasteste.Text))
                };
                if (!km.GenerateKey(kv, ref productKey))

                    txtchaveproduto.Text = "ERRO";
            }

            txtchaveproduto.Text = productKey;
            
        }
    }
}
