﻿using FoxLearn.License;
using Sistema_de_Vendas.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbSplash.Value < 100)
            {
                pbSplash.Value = pbSplash.Value + 2;
            }
            else
            {
                timer1.Enabled = false;

                Close();

            }
        }

       
    }
}
