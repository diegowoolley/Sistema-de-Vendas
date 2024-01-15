using Sistema_de_Vendas.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmcadProdutos : Form
    {
        public frmcadProdutos()
        {
            InitializeComponent();
        }

        private void lbladicionarcategorias_DoubleClick(object sender, EventArgs e)
        {
            frmcad_categorias frmcad_Categorias = new frmcad_categorias();
            frmcad_Categorias.ShowDialog();
        }
    }
}
