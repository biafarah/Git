using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio6._14
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
            contaJosefina.saldo = 250.0;

            string msg = contaJosefina.Saca(350.0, 19);
            
            MessageBox.Show(msg);
            
            
        }
    }
}
