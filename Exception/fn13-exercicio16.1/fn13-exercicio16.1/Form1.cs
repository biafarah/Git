﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio16._1
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        private int numeroDeContaCorrente;
        private int numeroDeContaPoupanca;

        private ContaPoupanca[] contaPoupanca;
        private ContaCorrente[] contaCorrente;

        public void AdicionaContaCorrente(ContaCorrente conta)
        {
            this.contaCorrente[this.numeroDeContaCorrente] = conta;
            this.numeroDeContaCorrente++;
            comboBoxContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        public void AdicionaContaPoupanca(ContaPoupanca conta)
        {
            this.contaPoupanca[this.numeroDeContaPoupanca] = conta;
            this.numeroDeContaPoupanca++;
            comboBoxContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contaCorrente = new ContaCorrente[10];
            this.contaPoupanca = new ContaPoupanca[10];

            ContaCorrente c1 = new ContaCorrente();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaContaCorrente(c1);

            ContaCorrente c2 = new ContaCorrente();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 1;
            this.AdicionaContaCorrente(c2);

            ContaPoupanca c3 = new ContaPoupanca();
            c3.Titular = new Cliente("osni");
            c3.Numero = 1;
            this.AdicionaContaPoupanca(c3);

            ContaPoupanca c4 = new ContaPoupanca();
            c4.Titular = new Cliente("teste");
            c4.Numero = 1;
            this.AdicionaContaPoupanca(c4);
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            int indice = comboBoxContas.SelectedIndex;
            Conta selecionada = this.contaPoupanca[indice];

            double valor = Convert.ToDouble(valorTextBox.Text);
            selecionada.Deposita(valor);
            saldoTextBox.Text = Convert.ToString(selecionada.Saldo);
        }

        private void comboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = comboBoxContas.SelectedIndex;
            ContaCorrente selecionadaCorrente = this.contaCorrente[indice];
            ContaPoupanca selecionadaPoupanca = this.contaPoupanca[indice];
            if (this.contaCorrente[indice] != null)
            {
                numeroTextBox.Text = Convert.ToString(selecionadaCorrente.Numero);
                titularTextBox.Text = selecionadaCorrente.Titular.Nome;
                saldoTextBox.Text = Convert.ToString(selecionadaCorrente.Saldo);
            }
            else
            {
                numeroTextBox.Text = Convert.ToString(selecionadaPoupanca.Numero);
                titularTextBox.Text = selecionadaPoupanca.Titular.Nome;
                saldoTextBox.Text = Convert.ToString(selecionadaPoupanca.Saldo);
            }
        }

        private void buttonImpostos_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            c1.Numero = 1;

            Conta c2 = new ContaCorrente();
            c2.Numero = 1;

            /*if (c1 == c2)
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");// São diferentes, pois estão comparando as referências !
            }*/

            /*if (c1.Numero == c2.Numero)
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");// São diferentes, pois estão comparando as referências !
            }*/

            if (c1.Equals(c2))//Pega o metodo da sobrescrito na conta
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }
    }
}
