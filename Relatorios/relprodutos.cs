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
                sql = "SELECT * FROM cad_produtos";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);

                con.FecharConexao();

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }






        }

       
    }
}
