using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sistema_de_Vendas
{
    internal class funcoes
    {
        public static string conectado ;
        

        public static string retirarmascaracnpj(string cnpjmascara)
        {
            return cnpjmascara.Replace(".", "").Replace("/", "").Replace("-", "");
        }
        public static bool validarcnpj(string cnpj)
        {
            int[] fator1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] fator2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            if (cnpj.Length != 14)
            {
                throw new InvalidCastException("CNPJ deve ter 14 dígitos!\n" + cnpj);
            }
        

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * fator1[i];


            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            if (digito == cnpj[12].ToString()) 
            {
                soma = 0;

                for (int i = 0; i < 13; i++)
                    soma += int.Parse(cnpj[i].ToString()) * fator2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
            else
            {
                return false;
            }



        }
        
        public static void DecNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)//&& e.KeyChar != 44)
                e.Handled = true;
        }

        public static string formatardocumentos(string documento)
            {
            
            if (documento.Length > 14)
            {
                documento = Convert.ToInt64(documento).ToString(@"00\.000\.000/0000-00");
                return documento;
            }
            else
            {
                documento = Convert.ToInt64(documento).ToString(@"000\.000\.000-00");
                return documento;
            }
            
        }
    }
    
}
