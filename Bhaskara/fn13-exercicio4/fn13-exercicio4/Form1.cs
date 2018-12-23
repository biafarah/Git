using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bhaskaraButton_Click(object sender, EventArgs e)
        {
            double delta, a1, a2;
            int a = 30, b = 100, c = 20;

            delta = (b * b) - (4 * a * c);

            a1 = (-b + (Math.Sqrt(delta))) / (2*a);
            a2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            MessageBox.Show("A': " + a1 + "A'': " + a2);
        }
    }
}
