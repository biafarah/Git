using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio10._1
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        //public string Saca(double valor)
        //{
        //    if (this.Saldo >= valor)
        //    {
        //        this.Saldo -= valor;
        //        return "Saque realizado com sucesso";
        //    }
        //    else
        //    {
        //        return "Saldo insuficiente";
        //    }
        //}

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
