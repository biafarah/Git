using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio6._16
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
            conta.titular = new Cliente();
            conta.titular.nome = "Jorge";
            Cliente cli = new Cliente();
            cli.idade = 20;
            conta.titular.idade = cli.idade;
          
            if (conta.titular.EhMaiorDeIdade())
            {
                MessageBox.Show("É maior de idade !");
            }
            else
            {
                MessageBox.Show("É menor de idade");
            }
        }
    }
}
