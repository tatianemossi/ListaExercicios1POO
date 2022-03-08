using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5.ConsoleApp
{
    internal class Esfera
    {
        public double Raio;
        public double VolumeDaEsfera;

        public void ObtemVolume()
        {
            VolumeDaEsfera = (4 / 3) * Math.PI * Math.Pow(Raio, 3);
        }
    }
}
