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
        public static string conectado ;// pega usuario conectado ao sistema
        public string numero { get; set; }

        public static int cod_venda {  get; set; }
        public static int cod_empresa {  get; set; }// pega empresa conectada ao sistema

        private const string chaveCripto = "Nsx-sz21"; // chave de cryptografia Altere isso para uma chave segura e única        

        public static void DecNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        public static bool CPF(string cpf)
        {
            bool cpfvalido = true;

           
            if(cpfvalido)
            {
                var j = 1;
                var d1 = 0;
                var d2 = 0;
                
                for (int i = 10; i > 1; i--) 
                {
                    d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }
                d1 = (d1 * 10) % 11;
                if (d1 == 10)
                    d1 = 0;

                if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
                    cpfvalido = false;
                
                
                if (cpfvalido)
                {
                    j = 0;
                    for(int i = 11; i > 1; i--)
                    {
                        d2 = Convert.ToInt32(cpf.Substring(j, 1)) * i;
                        j++;
                    }
                    d2 = (d2 * 10) % 11;
                    if (d2 == 10)
                        d2 = 0;

                    if(d2 != Convert.ToInt32(cpf.Substring(10, 1)))
                        cpfvalido = false;
                    
                }
                
            }
            return cpfvalido;

            //var j = 0;
            //var dig1 = 0;
            
            //    for (int i = 10; i > 1; i--)
            //    {
            //        dig1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
            //        j++;
            //    }
            //    dig1 = (dig1 * 10) % 11;
            //    if (dig1 == 10)
            //        dig1 = 0;
            //    cpf += dig1;

            //    j = 0;
            //    var dig2 = 0;
            //    for (int i = 11; i > 1; i--)
            //    {
            //        dig2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
            //        j++;
            //    }
            //    dig2 = (dig2 * 10) % 11;
            //    if (dig2 == 10)
            //        dig2 = 0;
            //     return true;                       
        }

        public static bool CNPJ(string cnpj)
        {
            
            int[] fator1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] fator2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * fator1[i];

            int resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            cnpj += digito;

            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * fator2[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            return true;



        }

        public static string Criptografar(string textoOriginal)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(chaveCripto);
                aesAlg.IV = new byte[16]; // Um IV (Vetor de Inicialização) seguro deve ser usado para criptografia

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(textoOriginal);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Descriptografar(string textoCriptografado)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(chaveCripto);
                aesAlg.IV = new byte[16];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textoCriptografado)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }



}
    

