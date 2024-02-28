using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Relatorios
{
    public class Empresa
    {
        public string nome { get; set; }
        public string documento { get; set; }
        public string inscricao {  get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string cidade { get; set; }
        public string estado {  get; set; }
        public string telefone { get; set;}
        public string celular {  get; set; }
        public byte[] foto {  get; set; }
        public string email { get; set; }
    }   
}
