using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmsuporte : Form
    {
        public frmsuporte()
        {
            InitializeComponent();
        }

        #region MÉTODOS
        private void Enviar()
        {
            
            try
            {
                if (txtEmail.Text.Trim() != "")
                {
                    //corpo da email
                    MailMessage mail = new MailMessage(txtEmail.Text, "dwsistemasrecife@gmail.com");                    
                    mail.Subject = txtTitulo.Text;
                    mail.SubjectEncoding = Encoding.GetEncoding("UTF-8");                   
                    mail.IsBodyHtml = true;
                    mail.Body = "<p>" + txtNome.Text + "<br></br>" + txtEmail.Text + "<br></br>" + txtMessagem.Text + "</p>";
                    mail.BodyEncoding = Encoding.GetEncoding("UTF-8");
                    //fim

                    //envio
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false; //false pq nao iremos usar a credidencias padrao, iremos usar NetworkCredential com email e senha do proprio email remetente
                    smtp.Credentials = new NetworkCredential("dwsistemasrecife@gmail.com", "Nsx-sz21");
                    smtp.EnableSsl = true; //protocolo de criptografia
                    smtp.Send(mail); // enviar
                                     //fimm
                    MessageBox.Show("Mensagem enviada com sucesso!", "Confirmação de envio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Text = "NOME";
                    txtEmail.Text = "EMAIL";
                    txtTitulo.Text = "TÍTULO DA MENSAGEM";
                    txtMessagem.Text = "MENSAGEM";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Foi encontrado um erro ao enviar. Todos os campos são obrigatórios.", "Erro no envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally
            //{
            //    this.Close();
            //}
        }

        #endregion

        #region BOTÕES
        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() == "")
            {
                return;
            }
            if (txtNome.Text.Trim() == "")
            {
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                return;
            }
            Enviar();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "NOME";
            txtEmail.Text = "EMAIL";
            txtTitulo.Text = "TÍTULO DA MENSAGEM";
            txtMessagem.Text = "MENSAGEM";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://web.whatsapp.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ENTER \ LEAVE
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
                //txtsenha.Visible = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
                //txtsenha.Visible = true;
            }
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "TÍTULO DA MENSAGEM")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "TÍTULO DA MENSAGEM";
                txtTitulo.ForeColor = Color.DimGray;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
                //txtsenha.Visible = true;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "NOME";
                txtNome.ForeColor = Color.DimGray;
            }
        }

        private void txtMessagem_Enter(object sender, EventArgs e)
        {
            if (txtMessagem.Text == "MENSAGEM")
            {
                txtMessagem.Text = "";
                txtMessagem.ForeColor = Color.Black;
            }
        }

        private void txtMessagem_Leave(object sender, EventArgs e)
        {

            if (txtMessagem.Text == "")
            {
                txtMessagem.Text = "MENSAGEM";
                txtMessagem.ForeColor = Color.DimGray;
            }
        }

        #endregion

       
    }
}
