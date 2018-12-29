﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio_5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somaButton_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int contador = 0;

            do
            {
                if (contador % 3 == 0 || contador % 4 == 0)
                {
                    soma += contador;
                }
                contador++;
            } while (contador <= 100);

            MessageBox.Show("Somatório dos múltiplos 3 e 4, de 1 até 30: " + soma);
        }
    }
}
