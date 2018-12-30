using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contaButton_Click(object sender, EventArgs e)
        {
            Conta contaJosefina = new Conta();
            contaJosefina.titular = "Josefina";
            contaJosefina.numero = 1;
            contaJosefina.saldo = 100.0;
            contaJosefina.Deposita(100.0);

            MessageBox.Show("Titular: " +contaJosefina.titular);
            MessageBox.Show("Saldo: " +contaJosefina.saldo.ToString());
            contaJosefina.Saca(50.0);
            MessageBox.Show("Saldo depois do saque: " + contaJosefina.saldo.ToString());


            Conta contaMarcelino = new Conta();
            contaMarcelino.titular = "Marcelino";
            contaMarcelino.numero = 2;
            contaMarcelino.saldo = 200.0;
            contaMarcelino.Deposita(100.0);

            MessageBox.Show("Titular: " + contaMarcelino.titular);            
            MessageBox.Show("Saldo: " + contaMarcelino.saldo.ToString());
            contaMarcelino.Saca(50.0);
            MessageBox.Show("Saldo depois do saque: " + contaMarcelino.saldo.ToString());

        }
    }
}
