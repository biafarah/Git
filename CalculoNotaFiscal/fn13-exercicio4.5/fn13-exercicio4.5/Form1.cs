using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void impostoButton_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 2599.0;
            double valorImposto = 0.0;

            if (valorNotaFiscal <= 999)
            {
                valorImposto = valorNotaFiscal + (valorNotaFiscal * 0.02);
            }
            else if (valorNotaFiscal >= 1000 && valorNotaFiscal <= 2999)
            {
                valorImposto = valorNotaFiscal + (valorNotaFiscal * 0.025);
            }
            else if (valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                valorImposto = valorNotaFiscal + (valorNotaFiscal * 0.028);
            }
            else if (valorNotaFiscal >= 7000)
            {
                valorImposto = valorNotaFiscal + (valorNotaFiscal * 0.03);
            }

            MessageBox.Show("O valor do imposto foi: " + valorImposto);
        }
    }
}
