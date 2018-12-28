using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_execicio5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int contador = 1;
            while (contador <= 100)
            {
                soma += contador;
                contador++;
            }

            MessageBox.Show("Somatório de 1 até 100: " + soma);
        }
    }
}
