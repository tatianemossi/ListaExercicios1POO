using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9.ConsoleApp
{
    internal class MediaHarmonica
    {
        public int QuantidadeDeElementos;
        
        public void CalcularMediaHarmonica()
        {
            double[] ValorDeCadaElemento = new double[QuantidadeDeElementos];
            double somaDoInversoDosElementos = 0;
            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                Console.WriteLine("Digite o valor do Elemento");
                ValorDeCadaElemento[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                somaDoInversoDosElementos += 1 / ValorDeCadaElemento[i];
            }
            double resultado = QuantidadeDeElementos / somaDoInversoDosElementos;
            Console.WriteLine($"A média harmônica será: {resultado}");
        }
    }
}
