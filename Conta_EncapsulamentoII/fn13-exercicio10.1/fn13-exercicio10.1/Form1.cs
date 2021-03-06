﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Conta conta;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaPoupanca();
            conta.Deposita(100.0);

            conta.Numero = 1;
            Cliente cli = new Cliente("Maria");
            conta.Titular = cli;

            titularTextBox.Text = conta.Titular.Nome;
            numeroTextBox.Text = Convert.ToString(conta.Numero);
            saldoTextBox.Text = Convert.ToString(conta.Saldo);
        }
    }
}
