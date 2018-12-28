using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void somaButton_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int contador = 1;

            do
            {
                if (contador % 3 == 0)
                {
                    soma += contador;
                }
                contador++;
            } while (contador <= 100);

            MessageBox.Show("Somatório de 1 até 100: " + soma);
        }
    }
}
