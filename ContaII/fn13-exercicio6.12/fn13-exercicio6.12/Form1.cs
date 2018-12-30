using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio6._12
{
    public partial class contaForm : Form
    {
        public contaForm()
        {
            InitializeComponent();
        }

        private void contaButton_Click(object sender, EventArgs e)
        {
            Conta contaJosefina = new Conta();
            contaJosefina.saldo = 10.0;
            contaJosefina.titular = "Josefina";
            
            if (contaJosefina.Saca(100.0))
            {
                MessageBox.Show("Saque Realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }
    }
}
