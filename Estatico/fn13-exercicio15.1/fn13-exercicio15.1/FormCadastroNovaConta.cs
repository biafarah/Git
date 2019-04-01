using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio15._1
{
    public partial class FormCadastroNovaConta : Form
    {
        //public FormCadastroNovaConta()
        //{
        //    InitializeComponent();
        //}
        private Form1 formPrincipal;
        public FormCadastroNovaConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroNovaConta_Load(object sender, EventArgs e)
        {
            numeroTextBox.Text = Convert.ToString(Conta.ProximoNumero());
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
