using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_Vendas
{
    internal class conn
    {
        public static string servidor = "";
        public static string banco = "";
        public static string usuario = "";
        public static string senha = "";
        public static string porta = "";
       // public static string sql = "SERVER=localhost; DATABASE=dbsistema_vendas; UID=root; PID=; PORT=;";

        public static String connec 
        {
            get
            {
                return @"SERVER="+servidor+";DATABASE="+banco+";UID="+usuario+";PID="+senha+";PORT = "+ porta +";"; 
            }
        }
                


        public MySqlConnection con = null;
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(connec);
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de Conexão"+ ex.Message );
            }
                   }
        public void FecharConexao()
        {
            try 
            {
                con = new MySqlConnection(connec);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de Conexão" + ex.Message);
            }
        }

       
    }
}
