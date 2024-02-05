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
           
            
                if (MessageBox.Show(funcoes.conectado + ", deseja realizar a restauração total do Sistema? ao aceitar lembre-se que todos os dados antigos serão substituidos!", "Cópia de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Filter = "Arquivo SQL (*.sql)|*.sql",
                        Title = "Selecione o Arquivo de Backup"
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        string constring = conn.connec;
                        // Important Additional Connection Options
                        constring += "charset=utf8;convertzerodatetime=true;";

                        using (MySqlConnection conn = new MySqlConnection(constring))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    try
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();
                                        mb.ImportFromFile(filePath);
                                        conn.Close();
                                        MessageBox.Show("Restauração Realizada com Sucesso!", "Backup Banco de Dados");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Erro durante a restauração: " + ex.Message, "Erro");
                                    }
                                }
                            }
                        }
                    }
                }
            

        }
    }
}
