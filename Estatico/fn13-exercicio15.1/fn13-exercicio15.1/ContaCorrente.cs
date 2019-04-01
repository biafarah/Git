using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio15._1
{
    public class ContaCorrente:Conta, Itributavel
    {
        public override void Saca(double valor)
        {
            base.Saca(valor - 0.05);
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }

        public double CalcularTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
