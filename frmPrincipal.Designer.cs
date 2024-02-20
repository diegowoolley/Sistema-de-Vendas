namespace Sistema_de_Vendas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasComprasDetalhadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeTransaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasÀReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirDadosDaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDeAtivaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrastatus = new System.Windows.Forms.ToolStrip();
            this.lblconectado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbllicenca = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblnomedata = new System.Windows.Forms.ToolStripLabel();
            this.lbldata = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblnomehora = new System.Windows.Forms.ToolStripLabel();
            this.lblhora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblempresa = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gerenciamentoFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.barrastatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasComprasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(999, 24);
            this.mnPrincipal.TabIndex = 1;
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem,
            this.transportadorasToolStripMenuItem,
            this.veiculosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros:";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click_1);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click_1);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // transportadorasToolStripMenuItem
            // 
            this.transportadorasToolStripMenuItem.Name = "transportadorasToolStripMenuItem";
            this.transportadorasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.transportadorasToolStripMenuItem.Text = "Transportadoras";
            this.transportadorasToolStripMenuItem.Click += new System.EventHandler(this.transportadorasToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // vendasComprasToolStripMenuItem
            // 
            this.vendasComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasComprasDetalhadasToolStripMenuItem,
            this.inventárioToolStripMenuItem,
            this.historicoDeTransaçõesToolStripMenuItem,
            this.pDVToolStripMenuItem});
            this.vendasComprasToolStripMenuItem.Name = "vendasComprasToolStripMenuItem";
            this.vendasComprasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.vendasComprasToolStripMenuItem.Text = "Movimentações:";
            // 
            // vendasComprasDetalhadasToolStripMenuItem
            // 
            this.vendasComprasDetalhadasToolStripMenuItem.Name = "vendasComprasDetalhadasToolStripMenuItem";
            this.vendasComprasDetalhadasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.vendasComprasDetalhadasToolStripMenuItem.Text = "Vendas \\ Compras Detalhadas";
            this.vendasComprasDetalhadasToolStripMenuItem.Click += new System.EventHandler(this.vendasComprasDetalhadasToolStripMenuItem_Click);
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            this.inventárioToolStripMenuItem.Click += new System.EventHandler(this.inventárioToolStripMenuItem_Click);
            // 
            // historicoDeTransaçõesToolStripMenuItem
            // 
            this.historicoDeTransaçõesToolStripMenuItem.Name = "historicoDeTransaçõesToolStripMenuItem";
            this.historicoDeTransaçõesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.historicoDeTransaçõesToolStripMenuItem.Text = "Historico de transações";
            this.historicoDeTransaçõesToolStripMenuItem.Click += new System.EventHandler(this.historicoDeTransaçõesToolStripMenuItem_Click);
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.pDVToolStripMenuItem.Text = "PDV";
            this.pDVToolStripMenuItem.Click += new System.EventHandler(this.pDVToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoFinanceiroToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.contasÀReceberToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro:";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasToolStripMenuItem.Text = "Contas à Pagar";
            // 
            // contasÀReceberToolStripMenuItem
            // 
            this.contasÀReceberToolStripMenuItem.Name = "contasÀReceberToolStripMenuItem";
            this.contasÀReceberToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasÀReceberToolStripMenuItem.Text = "Contas à Receber";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeProdutosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios:";
            // 
            // relatórioDeProdutosToolStripMenuItem
            // 
            this.relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
            this.relatórioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.relatórioDeProdutosToolStripMenuItem.Text = "Relatório de produtos";
            this.relatórioDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeProdutosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDoBancoDeDadosToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.suporteToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção \\ Ferramentas:";
            // 
            // backupDoBancoDeDadosToolStripMenuItem
            // 
            this.backupDoBancoDeDadosToolStripMenuItem.Name = "backupDoBancoDeDadosToolStripMenuItem";
            this.backupDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.backupDoBancoDeDadosToolStripMenuItem.Text = "Backup do Banco de Dados";
            this.backupDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirDadosDaEmpresaToolStripMenuItem,
            this.configuraçõesDeAcessoToolStripMenuItem,
            this.configuraçõesDoBancoDeDadosToolStripMenuItem,
            this.configuraçãoDeAtivaçãoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração:";
            // 
            // inserirDadosDaEmpresaToolStripMenuItem
            // 
            this.inserirDadosDaEmpresaToolStripMenuItem.Name = "inserirDadosDaEmpresaToolStripMenuItem";
            this.inserirDadosDaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.inserirDadosDaEmpresaToolStripMenuItem.Text = "Cadastrar dados da empresa";
            this.inserirDadosDaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.inserirDadosDaEmpresaToolStripMenuItem_Click);
            // 
            // configuraçõesDeAcessoToolStripMenuItem
            // 
            this.configuraçõesDeAcessoToolStripMenuItem.Name = "configuraçõesDeAcessoToolStripMenuItem";
            this.configuraçõesDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.configuraçõesDeAcessoToolStripMenuItem.Text = "Configurações de acesso";
            // 
            // configuraçõesDoBancoDeDadosToolStripMenuItem
            // 
            this.configuraçõesDoBancoDeDadosToolStripMenuItem.Name = "configuraçõesDoBancoDeDadosToolStripMenuItem";
            this.configuraçõesDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.configuraçõesDoBancoDeDadosToolStripMenuItem.Text = "Configurações do banco de dados";
            this.configuraçõesDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // configuraçãoDeAtivaçãoToolStripMenuItem
            // 
            this.configuraçãoDeAtivaçãoToolStripMenuItem.Name = "configuraçãoDeAtivaçãoToolStripMenuItem";
            this.configuraçãoDeAtivaçãoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.configuraçãoDeAtivaçãoToolStripMenuItem.Text = "Configuração de ativação do sistema";
            this.configuraçãoDeAtivaçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDeAtivaçãoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // barrastatus
            // 
            this.barrastatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barrastatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barrastatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblconectado,
            this.toolStripSeparator1,
            this.lbllicenca,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.lblnomedata,
            this.lbldata,
            this.toolStripSeparator3,
            this.lblnomehora,
            this.lblhora,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripSeparator6,
            this.lblempresa});
            this.barrastatus.Location = new System.Drawing.Point(0, 554);
            this.barrastatus.Name = "barrastatus";
            this.barrastatus.Size = new System.Drawing.Size(999, 25);
            this.barrastatus.TabIndex = 2;
            this.barrastatus.Text = "toolStrip1";
            // 
            // lblconectado
            // 
            this.lblconectado.Name = "lblconectado";
            this.lblconectado.Size = new System.Drawing.Size(47, 22);
            this.lblconectado.Text = "Usuário";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbllicenca
            // 
            this.lbllicenca.Name = "lbllicenca";
            this.lbllicenca.Size = new System.Drawing.Size(62, 22);
            this.lbllicenca.Text = "Expira em:";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(433, 22);
            this.toolStripLabel1.Text = "Desenvolvido por DW Sistemas - Copyright ©2024 - Todos os direitos reservados ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblnomedata
            // 
            this.lblnomedata.Name = "lblnomedata";
            this.lblnomedata.Size = new System.Drawing.Size(34, 22);
            this.lblnomedata.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(95, 22);
            this.lbldata.Text = "Data: 00/00/0000";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblnomehora
            // 
            this.lblnomehora.Name = "lblnomehora";
            this.lblnomehora.Size = new System.Drawing.Size(36, 22);
            this.lblnomehora.Text = "Hora:";
            // 
            // lblhora
            // 
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(81, 22);
            this.lblhora.Text = "Hora: 00:00:00";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "Versão: 1.0a";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // lblempresa
            // 
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(55, 22);
            this.lblempresa.Text = "Empresa:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gerenciamentoFinanceiroToolStripMenuItem
            // 
            this.gerenciamentoFinanceiroToolStripMenuItem.Name = "gerenciamentoFinanceiroToolStripMenuItem";
            this.gerenciamentoFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.gerenciamentoFinanceiroToolStripMenuItem.Text = "Gerenciamento Financeiro";
            this.gerenciamentoFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoFinanceiroToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Vendas.Properties.Resources.Otimizacao_de_vendas_com_ERP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.barrastatus);
            this.Controls.Add(this.mnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.barrastatus.ResumeLayout(false);
            this.barrastatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasÀReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barrastatus;
        private System.Windows.Forms.ToolStripLabel lblconectado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbldata;
        private System.Windows.Forms.ToolStripLabel lblhora;
        private System.Windows.Forms.ToolStripLabel lblnomedata;
        private System.Windows.Forms.ToolStripLabel lblnomehora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasComprasDetalhadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeTransaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirDadosDaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDeAtivaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lbllicenca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem pDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblempresa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoFinanceiroToolStripMenuItem;
    }
}

