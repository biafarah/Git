using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio14._2
{
    public class SeguroDeVida:ITributavel
    {
        const double seguroVal = 42.0;

        public double CalcularTributos()
        {
            return seguroVal;
        }
    }
}
