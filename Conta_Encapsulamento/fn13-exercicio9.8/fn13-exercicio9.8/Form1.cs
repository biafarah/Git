using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio9._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Numero = 1;
            Cliente cli = new Cliente("Maria");
            conta.Titular = cli;

            titularTextBox.Text = conta.Titular.Nome;
            numeroTextBox.Text = Convert.ToString(conta.Numero);
            saldoTextBox.Text = Convert.ToString(conta.Saldo);
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            string valorDigitado = valorTextBox.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            Conta conta = new Conta();
            conta.Deposita(valorOperacao);
            saldoTextBox.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void sacarButton_Click(object sender, EventArgs e)
        {
            string valorDigitado = valorTextBox.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            Conta conta = new Conta();
            var msg = conta.Saca(valorOperacao);
            saldoTextBox.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show(msg);
        }
    }
}
