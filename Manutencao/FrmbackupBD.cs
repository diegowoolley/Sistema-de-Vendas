using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Vendas
{
    public partial class FrmbackupBD : Form
    {
        public FrmbackupBD()
        {
            InitializeComponent();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show(funcoes.conectado + ", deseja realizar o backUp total do Sistema? ", "Cópia de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Arquivo SQL (*.sql)|*.sql",
                    Title = "Salvar Backup",
                    FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "backup.sql"
                };


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string path = saveFileDialog.FileName;

                    // Specify the directory you want to manipulate.



                    string constring = conn.connec;
                    // Important Additional Connection Options
                    constring += "charset=utf8;convertzerodatetime=true;";
                    string data = DateTime.Now.ToString("dd-MM-yyyy-ss");
                    string file = path + "backup-" + data + ".sql"; //caminho... optei criar uma pasta em C chamada Backup (nome 'backup'+data)
                    using (MySqlConnection conn = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd)) //instalar o pacote NuGet MySqlBackup.NET
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(file);
                                conn.Close();
                                MessageBox.Show("Backup Realizado com Sucesso!", "Backup Banco de Dados");
                            }
                        }
                    }
                }



            }
        }    

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(funcoes.conectado + ", deseja realizar o backUp total do Sistema? ", "Cópia de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Arquivo SQL (*.sql)|*.sql",
                    Title = "Salvar Backup",
                    FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "backup.sql"
                };


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string path = saveFileDialog.FileName;

                    // Specify the directory you want to manipulate.

                    string constring = conn.connec;
                    // Important Additional Connection Options
                    constring += "charset=utf8;convertzerodatetime=true;";
                    string data = DateTime.Now.ToString("dd-MM-yyyy-ss");
                    string file = path + "backup-" + data + ".sql"; //caminho... optei criar uma pasta em C chamada Backup (nome 'backup'+data)
                    using (MySqlConnection conn = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd)) //instalar o pacote NuGet MySqlBackup.NET
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportFromFile(file);
                                conn.Close();
                                MessageBox.Show("Backup Realizado com Sucesso!", "Backup Banco de Dados");
                            }
                        }
                    }
                }


            }
        }
    }
}
