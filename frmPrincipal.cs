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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadUsuarios frmusuarios = new frmcadUsuarios();
            frmusuarios.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadClientes frmClientes = new frmcadClientes();
            frmClientes.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string conectado = funcoes.conectado;
            lblconectado.Text = ("Usuário Conectado: " + conectado); 
            
        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcadUsuarios cadusuario= new frmcadUsuarios();
            cadusuario.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcadClientes cadclientes= new frmcadClientes();
            cadclientes.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
