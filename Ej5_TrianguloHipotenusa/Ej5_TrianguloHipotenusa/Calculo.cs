using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5_TrianguloHipotenusa
{
    class Calculo
    {
        public double Lado (double a, double b)
        {
            double h = (double)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return (h);
        }
    }
}
