using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio14._1
{
    public class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Adiciona (ITributavel t)
        {
            this.Total += t.CalcularTributos();
        }
    }
}
