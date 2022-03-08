using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.ConsoleApp
{
    internal class Cilindro
    {
        public double Altura;
        public double Raio;
        public double volumeDoCilindro;

        public void ObtemVolume()
        {
            volumeDoCilindro = Altura * (Math.PI * Raio * Raio);
        }
    }
}
