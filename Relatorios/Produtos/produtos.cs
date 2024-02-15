using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Relatorios
{
    public class produtos
    {
        public int cod_produto {  get; set; }
        public string nome_produto { get; set; }
        public string categoria_produto { get; set; }
        public string unidade_medida {  get; set; }
        public decimal quantidade { get; set; }
        public string fornecedor {  get; set; }
        public string fabricante { get; set; }  
        public decimal valor_compra { get; set; }
        public decimal valor_venda { get; set; }
        public decimal margem_lucro {  get; set; }
        public int estoque_minimo {  get; set; }
        public int estoque_maximo {  get; set; }
        public string validade {  get; set; }
        public string etiqueta {  get; set; }

             


    }
}
