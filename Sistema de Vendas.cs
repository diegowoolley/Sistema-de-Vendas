using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    internal static class Program
    {

        private static Mutex mutex = new Mutex(true, "{B2E4D67D-3B69-4F0C-8BE3-A8E6D1BFA698}");
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmSplash());
                Application.Run(new frmLogin());             
                               
                //Application.Run(new frmPrincipal());

            }
            else
            {
                MessageBox.Show("O aplicativo já está em execução.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
