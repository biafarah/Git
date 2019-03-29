using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);
            MessageBox.Show("Imposto da conta corrente = " + conta.CalcularTributos());

            ITributavel t = conta;
            MessageBox.Show("Imposto da conta pela interface = " + t.CalcularTributos());

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("imposto seguro de vida = " + sv.CalcularTributos());

            t = sv;
            MessageBox.Show("imposto do seguro pela interface = " + t.CalcularTributos());
        }
    }
}
