using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio15._1
{
    public class SeguroDeVida:Itributavel
    {
        const double seguroVal = 42.0;

        public double CalcularTributos()
        {
            return seguroVal;
        }
    }
}
