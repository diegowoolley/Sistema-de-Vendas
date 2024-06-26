﻿using FoxLearn.License;
using MySql.Data.MySqlClient;
using Sistema_de_Vendas.Cadastros;
using Sistema_de_Vendas.Configuracoes;
using Sistema_de_Vendas.Financeiro;
using Sistema_de_Vendas.Ordem_de_Serviço;
using Sistema_de_Vendas.Relatorios;
using Sistema_de_Vendas.Transacoes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        conn con = new conn();
        string sql;
        MySqlCommand cmd;
        string permissao;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_usuarios WHERE nome_usuarios = @user";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@user", funcoes.conectado);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);
                permissao = dt.Rows[0]["permissoes_Usuarios"].ToString();
                funcoes.permissao = permissao;
                con.FecharConexao();

                if(permissao == "Administrador")
                {
                    cadastrosToolStripMenuItem.Enabled = true;
                    vendasComprasToolStripMenuItem.Enabled = true;
                    financeiroToolStripMenuItem.Enabled = true;
                    manutençãoToolStripMenuItem.Enabled = true;
                    configuraçãoToolStripMenuItem.Enabled = false;

                }
                else if(permissao == "Usuário")
                {
                    cadastrosToolStripMenuItem.Enabled = false;
                    financeiroToolStripMenuItem.Enabled = false;
                    manutençãoToolStripMenuItem.Enabled = false;
                    configuraçãoToolStripMenuItem.Enabled = false;
                }
                else if(permissao == "Support")
                {
                    cadastrosToolStripMenuItem.Enabled = true;
                    vendasComprasToolStripMenuItem.Enabled = true;
                    financeiroToolStripMenuItem.Enabled = true;
                    manutençãoToolStripMenuItem.Enabled = true;
                    configuraçãoToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM cad_empresas WHERE cod = @cod ORDER BY nome asc";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);
                lblempresa.Text = "Empresa: " + dt.Rows[0]["nome"].ToString();
                con.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string conectado = funcoes.conectado;
            lblconectado.Text = ("Usuário Conectado: " + conectado);
            lbldata.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            string produto = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(produto);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        string expiracaoem = string.Format("Licença expira em {0} Dias", (kv.Expiration - DateTime.Now.Date).Days);
                        lbllicenca.Text = expiracaoem;
                    }
                    else
                    {
                        lbllicenca.Text = "Sistema Full";
                    }

                }


            }
        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcadUsuarios cadusuario = new frmcadUsuarios();
            cadusuario.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcadClientes cadclientes = new frmcadClientes();
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

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventario Inventario = new inventario();
            Inventario.ShowDialog();
        }

        private void historicoDeTransaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacoes Transacoes = new transacoes();
            Transacoes.ShowDialog();
        }

        private void configuraçõesDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconfbancodados frmconfbd = new frmconfbancodados();
            frmconfbd.ShowDialog();
        }

        private void inserirDadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadempresas empresas = new frmcadempresas();
            empresas.ShowDialog();
        }

        private void configuraçãoDeAtivaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlicencaprincipal frm = new frmlicencaprincipal();
            frm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsobre frm = new frmsobre();
            frm.ShowDialog();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsuporte frmsuporte = new frmsuporte();
            frmsuporte.ShowDialog();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDV frm = new frmPDV();
            frm.ShowDialog();
        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relprodutos frm = new relprodutos();
            frm.ShowDialog();
        }

        private void gerenciamentoFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgerfinanceiro frmgerfinanceiro = new frmgerfinanceiro();
            frmgerfinanceiro.ShowDialog();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontaspagar frmcontaspagar = new frmcontaspagar();
            frmcontaspagar.ShowDialog();
        }

        private void contasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontasreceber frmcontasreceber = new frmcontasreceber();
            frmcontasreceber.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void limparTabelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlimpartabelas frmlimpartabelas = new frmlimpartabelas();
            frmlimpartabelas.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistarOS frmlistar = new frmlistarOS();
            frmlistar.ShowDialog();
        }
    }
}
