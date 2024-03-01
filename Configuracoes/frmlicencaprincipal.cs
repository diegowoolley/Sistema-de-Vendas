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
    public partial class frmlicencaprincipal : Form
    {
        public frmlicencaprincipal()
        {
            InitializeComponent();
        }


        #region BOTÕES
        private void btngerar_Click(object sender, EventArgs e)
        {
            frmlicensa frm = new frmlicensa();
            frm.ShowDialog();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            frmregistro frmregistro = new frmregistro();
            frmregistro.ShowDialog();
        }

        private void btnsobre_Click(object sender, EventArgs e)
        {
            frmsobre frmsobre = new frmsobre();
            frmsobre.ShowDialog();
        }

        #endregion
    }
}
