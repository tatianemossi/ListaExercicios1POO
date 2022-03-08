using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8.ConsoleApp
{
    internal class LataDeOleo
    {
        public double Altura;
        public double Raio;
        public double VolumeDaLata;

        public void ObtemVolume()
        {
            VolumeDaLata = Altura * (Math.PI * Raio * Raio);
            Console.WriteLine($"O volume da Lata de Óleo é de: {VolumeDaLata}");
        }
    }
}
