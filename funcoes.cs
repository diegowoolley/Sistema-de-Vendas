using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sistema_de_Vendas
{
    internal class funcoes
    {
        public static string conectado;// pega usuario conectado ao sistema
        public string numero { get; set; }
        public static int cod_venda { get; set; }// pega codigo da venda para relatorios
        public static int cod_empresa { get; set; }// pega empresa conectada ao sistema

        
        public static void DecNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
             


       
    }

}
    

