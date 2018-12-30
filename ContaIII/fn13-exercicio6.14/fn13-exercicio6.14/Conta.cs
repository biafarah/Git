using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio6._14
{
    public class Conta
    {
        public double saldo;
        public int numero;
        public string titular;
        //public short idade;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public string Saca(double valor, short idade)
        {
            //Caso o cliente seja menor de idade limitar o saque para 200,00
            if (valor >= 200.0 && idade <= 17)
            {
                return "Saque não permitido para menores";
                //if (this.saldo >= valor)
                //{
                //    this.saldo -= valor;
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }

            else
            {
                if (this.saldo >= valor)
                {
                    this.saldo -= valor;
                    return "Saque realizado com sucesso";
                }
                else
                {
                    return "Saldo insuficiente";
                }
            }
        }
    }
}
