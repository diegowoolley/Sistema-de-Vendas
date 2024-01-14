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
               
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string conectado = funcoes.conectado;
            lblconectado.Text = ("Usuário Conectado: " + conectado);
            lbldata.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            
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

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcad_funcionarios cadfuncionarios = new frmcad_funcionarios();
            cadfuncionarios.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadfornecedores frmfornecedores = new frmcadfornecedores();
            frmfornecedores.ShowDialog();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
