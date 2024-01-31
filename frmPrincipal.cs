using MySql.Data.MySqlClient;
using Sistema_de_Vendas.Cadastros;
using Sistema_de_Vendas.Transacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadProdutos frmcadProdutos = new frmcadProdutos();
            frmcadProdutos.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadservicos frmservicos = new frmcadservicos();
            frmservicos.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_pagamentos cad_pagamento = new cad_pagamentos();    
            cad_pagamento.ShowDialog();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_veiculos cad_Veiculos = new cad_veiculos();
            cad_Veiculos.ShowDialog();
        }

        private void transportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_transportadoras cad_Transportadoras = new cad_transportadoras();
            cad_Transportadoras.ShowDialog();
        }

        private void vendasComprasDetalhadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvendas_compras frmvendas_Compras = new frmvendas_compras();
            frmvendas_Compras.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadProdutos frmcadprod = new frmcadProdutos();
            frmcadprod.Text = "Estoque";
            frmcadprod.ShowDialog();
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconfbancodados frmconfbd = new frmconfbancodados();
            frmconfbd.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmbackupBD bkpbd = new FrmbackupBD();
            bkpbd.ShowDialog();
        }
    }
}
