﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio12._2
{
    public class ContaCorrente:Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor - 0.05);
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }
    }
}
