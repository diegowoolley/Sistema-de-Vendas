using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo SQL (*.sql)|*.sql",
                Title = "Salvar Backup",
                FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") +"backup.sql" 
            };

           
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string caminhoBackup = saveFileDialog.FileName;

                
                string comando = $"mysqldump --user={"root"} --password={""} --host={"localhost"} --databases {"dbsistema_vendas"} > \"{caminhoBackup}\"";

                
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
                {
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WorkingDirectory = "C:\\xampp\\mysql\\bin"
                };

                Process processo = new Process { StartInfo = psi };

                try
                {
                    processo.Start();                    
                    processo.StandardInput.WriteLine(comando);
                    processo.StandardInput.Close();
                    
                    processo.WaitForExit();

                    MessageBox.Show("Backup concluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao realizar backup: {ex.Message}");
                }

            }
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivo SQL (*.sql)|*.sql",
                Title = "Selecionar Backup"
            };

           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                string caminhoBackup = openFileDialog.FileName;

                
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja restaurar o banco de dados? Isso substituirá todos os dados existentes.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                if (resultado == DialogResult.Yes)
                {
                   
                    string comando = $"mysql --user={"root"} --password={""} --host={"localhost"} {"dbsistema_vendas"} < \"{caminhoBackup}\"";

                    

                    try
                    {
                       

                        MessageBox.Show("Restauração concluída com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao realizar restauração: {ex.Message}");
                    }
                }
            }

        }
    }
}
