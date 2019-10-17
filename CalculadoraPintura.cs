using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPintura
{
    class CalculadoraPintura
    {
       public double areaParedes;
       public double areaTeto;

        public double CalcularAreaParede(double largura,double profundidade,double altura)
        {
           areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }
    }
}
