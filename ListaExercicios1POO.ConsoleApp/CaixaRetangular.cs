using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1POO.ConsoleApp
{
    internal class CaixaRetangular
    {
        public decimal Altura = 0;
        public decimal Comprimento = 0;
        public decimal Largura = 0;
        public decimal VolumeTotal = 0;

        public void ObtemVolume()
        {
            VolumeTotal = Altura * Comprimento * Largura;
        }
    }
}
