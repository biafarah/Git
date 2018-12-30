using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio6._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contaButton_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;
            conta.titular.nome = "Astolfo";

            MessageBox.Show("Cliente: " + conta.titular.nome);

            //Qual a saída ?
            Conta umaConta = new Conta();
            Cliente gui = new Cliente();
            gui.nome = "Guilherme";            
            umaConta.titular = new Cliente();
            umaConta.titular.nome = gui.nome;

            MessageBox.Show("Cliente: " + umaConta.titular.nome);
        }
    }
}
