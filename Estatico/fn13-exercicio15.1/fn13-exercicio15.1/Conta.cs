using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio15._1
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        private static int numeroDeContas;

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public Conta()
        {
            //Conta.numeroDeContas++;
            Conta.numeroDeContas = ProximoNumero();
            this.Numero = Conta.numeroDeContas;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
