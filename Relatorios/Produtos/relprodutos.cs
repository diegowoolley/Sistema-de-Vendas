using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Relatorios
{
    public partial class relprodutos : Form
    {
        public relprodutos()
        {
            InitializeComponent();
        }
        
        conn con = new conn();
        string sql;        
        MySqlCommand cmd;
        private void relprodutos_Load(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();

                // Consulta SQL para a tabela cad_produtos
                sql = "SELECT * FROM cad_produtos WHERE cod_empresa = @cod_empresa";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod_empresa", funcoes.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt1 = new DataTable();
                da.Fill(dt1);

                // Consulta SQL para a tabela cad_empresas
                sql = "SELECT * FROM cad_empresas WHERE cod = @cod";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@cod", funcoes.cod_empresa);
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt2 = new DataTable();
                da.Fill(dt2);

                con.FecharConexao();

                // Criar um novo DataSet
                DataSet ds = new DataSet();

                // Adicionar tabelas ao DataSet
                ds.Tables.Add(dt1);
                ds.Tables.Add(dt2);

                // Configurar fontes de dados do relatório
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[1]));

                // Atualizar o relatório
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }






        }


    }
}
