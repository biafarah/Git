using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fn13_exercicio_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeAstrubal = 32, idadeLourdes = 40, idadeGodofredo = 25;
            int media = (idadeAstrubal + idadeLourdes + idadeGodofredo) / 3;
            MessageBox.Show("A média entre a idade de Astrubal, Lourdes e Godofredo é: " + media);

        }
    }
}
