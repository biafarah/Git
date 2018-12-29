using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio5._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fatorialButton_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                MessageBox.Show(n + " fatorial= " + fatorial);
            }
        }
    }
}
