using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraPintura calculadora = new CalculadoraPintura();
            
            Console.WriteLine("Qual a largura ");
            double largura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual a profundidade?");
            double profundidade = double.Parse(Console.ReadLine());
         
            Console.WriteLine("A área das paredes é: ");
            const double Altura = 2.9;

            Console.WriteLine(calculadora.CalcularAreaParede(largura, profundidade, Altura));

            Console.WriteLine("A área do teto é: ");
            Console.WriteLine (calculadora.CalcularAreaTeto(largura, profundidade));

            Console.WriteLine("A litragem de tinta necessária é ");
            Console.WriteLine(calculadora.CalcularLitragem());

            Console.ReadKey();
        }
    }
}
