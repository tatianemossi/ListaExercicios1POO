using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.ConsoleApp
{
    internal class Veículo
    {
        public decimal KmInicial;
        public decimal KmFinal;
        public decimal QtdCombustivelGasto;
        public decimal Consumo;

        public void CalcularConsumo()
        {
            Consumo = QtdCombustivelGasto / (KmFinal - KmInicial);
        }
    }
}
