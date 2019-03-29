using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio12._2
{
    public partial class FormCadastroNovaConta : Form
    {
        private Form1 formPrincipal;

        //public FormCadastroNovaConta()
        public FormCadastroNovaConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void cadastrarContaButton_Click(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(titularTextBox.Text);
            novaConta.Numero = Convert.ToInt32(numeroTextBox.Text);

            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
