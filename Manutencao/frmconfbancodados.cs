using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmconfbancodados : Form
    {
        public frmconfbancodados()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfigBD.txt", false);
                arquivo.WriteLine(txtservidor.Text);
                arquivo.WriteLine(txtbancodados.Text);
                arquivo.WriteLine(txtusuario.Text);
                arquivo.WriteLine(txtsenha.Text);
                arquivo.WriteLine(txtporta.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void frmconfbancodados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfigBD.txt");
                txtservidor.Text = arquivo.ReadLine();
                txtbancodados.Text = arquivo.ReadLine();
                txtusuario.Text = arquivo.ReadLine();
                txtsenha.Text = arquivo.ReadLine();
                txtporta.Text = arquivo.ReadLine();
                arquivo.Close();                
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnteste_Click(object sender, EventArgs e)
        {
            try
            {
                conn.servidor = txtservidor.Text;
                conn.banco = txtbancodados.Text;
                conn.usuario = txtusuario.Text;
                conn.senha = txtsenha.Text;
                conn.porta = txtporta.Text;
                conn con = new conn();
                con.AbrirConexao();
                con.FecharConexao();
                MessageBox.Show("Conexão efetuada com sucesso!");

                StreamReader aqruivo = new StreamReader("ConfigBD.txt");
                conn.servidor = aqruivo.ReadLine();
                conn.banco = aqruivo.ReadLine();
                conn.usuario= aqruivo.ReadLine();
                conn.senha= aqruivo.ReadLine();
                conn.porta = aqruivo.ReadLine();
                aqruivo.Close();

            }
            catch (MySqlException exb)
            {

                MessageBox.Show("Erro nos parâmentros de conexão, favor entrar com os dados corretos e tente conectar novamente!", exb.Message);
                return; 
            }
           
        }
    }
}
