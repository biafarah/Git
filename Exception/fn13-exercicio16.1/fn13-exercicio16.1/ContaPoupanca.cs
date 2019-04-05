using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio16._1
{
    public class ContaPoupanca:Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor);
        }

        public override void Deposita(double valor)
        {
           
            if (valor <0.0)
            {
                throw new ArgumentException();
            }

            base.Deposita(valor - 0.10);
        }

    }
}
