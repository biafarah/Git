using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio12._2
{
    public partial class Form1 : Form
    {
        private int numeroDeContas;

        private Conta[] contas;

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboBoxContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[10];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new Conta();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 1;
            this.AdicionaConta(c2);

            Conta c3 = new Conta();
            c3.Titular = new Cliente("osni");
            c3.Numero = 1;
            this.AdicionaConta(c3);
        }

        private void novaContaButton_Click(object sender, EventArgs e)
        {
            FormCadastroNovaConta formularioCadastro = new FormCadastroNovaConta(this);
            formularioCadastro.ShowDialog();
        }

        private void comboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            numeroTextBox.Text = Convert.ToString(selecionada.Numero);
            titularTextBox.Text = selecionada.Titular.Nome;
            saldoTextBox.Text = Convert.ToString(selecionada.Saldo);
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(valorTextBox.Text);
            selecionada.Deposita(valor);
            saldoTextBox.Text = Convert.ToString(selecionada.Saldo);
        }

        private void sacarButton_Click(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(valorTextBox.Text);
            selecionada.Saca(valor);
            saldoTextBox.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}
