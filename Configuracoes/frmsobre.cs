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
    public partial class frmsobre : Form
    {
        public frmsobre()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;


        private void btnok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmsobre_Load(object sender, EventArgs e)
        {
            lblidproduto.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblidproduto.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if(km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    lblnomeproduto.Text = "DW SISTEMAS";
                    lblchaveproduto.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                        lbltipolicenca.Text = string.Format("{0} Dias", (kv.Expiration - DateTime.Now.Date).Days);
                   
                    else
                        lbltipolicenca.Text = "Full";
                   
                }
               
            }
           
        }
    }
}
