using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    internal class funcoes
    {
        public static string conectado;// pega usuario conectado ao sistema
        public string numero { get; set; }
        public static int cod_venda { get; set; }// pega codigo da venda para relatorios
        public static int cod_empresa { get; set; }// pega empresa conectada ao sistema
        public static string permissao { get; set; }


        public static void DecNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }




    }

}


