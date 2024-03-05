using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Relatorios.Recibos
{
    public class reciboPDV
    {
        public int id { get; set; }
        public int cod_venda { get; set; }
        public string tipo { get; set; }
        public string cliente { get; set; }
        public string produto { get; }
        public string quantidade { get; set; }
        public string vendedor { get; set; }
        public decimal descontos { get; set; }
        public string forma_pagamento { get; set; }
        public decimal valor_total { get; set; }
        public decimal valor_pago { get; set; }
        public decimal troco { get; set; }
        public decimal dinheiro { get; set; }
        public decimal pix { get; set; }
        public decimal cartao { get; set; }
        public string vencimento { get; set; }
        public decimal taxa { get; set; }
        public string categoria { get; set; }
        public int cod_produto { get; set; }
        public decimal valor_unitario { get; set; }
    }
}
