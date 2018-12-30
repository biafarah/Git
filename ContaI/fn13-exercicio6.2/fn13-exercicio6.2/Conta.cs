using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio6._2
{
    public class Conta
    {
        public double saldo;
        public int numero;
        public string titular;

        public void Deposita (double valor)
        {
            this.saldo += valor;
        }

        public void Saca (double valor)
        {
            this.saldo -= valor;
        }
    }
}
