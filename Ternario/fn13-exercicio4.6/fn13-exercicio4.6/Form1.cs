using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msgButton_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string msg = valor > 10 ? "Maior que dez" : "Menor que dez";

            MessageBox.Show(msg);
        }
    }
}
