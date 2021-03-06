﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Conta[] contas = new Conta[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Conta conta in contas)
            {
                //contas = new Conta[3];

                //inicializar algumas instâncias de Conta
                this.contas[0] = new Conta();
                this.contas[0].Titular = new Cliente("victor");
                this.contas[0].Numero = 1;

                this.contas[1] = new ContaPoupanca();
                this.contas[1].Titular = new Cliente("mauricio");
                this.contas[1].Numero = 2;

                this.contas[2] = new ContaCorrente();
                this.contas[2].Titular = new Cliente("osni");
                this.contas[2].Numero = 2;
            }
            comboBoxContas.Items.Add("titular: " + contas[0].Titular.Nome);
            comboBoxContas.Items.Add("titular: " + contas[1].Titular.Nome);
            comboBoxContas.Items.Add("titular: " + contas[2].Titular.Nome);
        }

        private void comboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            numeroTextBox.Text = Convert.ToString(selecionada.Numero);
            titularTextBox.Text = selecionada.Titular.Nome;
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

        private void depositarButton_Click(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(valorTextBox.Text);
            selecionada.Deposita(valor);
            saldoTextBox.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}
