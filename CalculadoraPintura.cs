using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPintura
{
    class CalculadoraPintura
    {
       private double areaParedes;
       private double areaTeto;

        public double CalcularAreaParede(double largura,double profundidade,double altura)
        {
           areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }

        public double  CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }
        
        public double CalcularLitragem()
        {

            return (areaParedes + areaTeto) / 10;
        }




    }
}
