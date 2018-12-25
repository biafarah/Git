using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio4._4
{
    public partial class VotacaoForm : Form
    {
        public VotacaoForm()
        {
            InitializeComponent();
        }

        private void votarButton_Click(object sender, EventArgs e)
        {
            //Regra para votar é ser maior de 16 e brasileiro
            int idade = 20;
            bool isBrasileira = false;
            string podeVotar = (idade >= 16 && isBrasileira) ?  "Pode Votar" : "Não Pode Votar !";

            MessageBox.Show(podeVotar);
        }
    }
}
