using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio5._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            string serieFibo = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibo += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibo);

        }
    }
}
