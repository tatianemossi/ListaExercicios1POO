using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    internal class MediaPonderada
    {
        public decimal Nota1;
        public decimal PesoNota1;
        public decimal Nota2;
        public decimal PesoNota2;
        public decimal Media;

        public void CalcularMediaPonderada()
        {
            Media = (PesoNota1 * Nota1 + PesoNota2 * Nota2) / (PesoNota1 + PesoNota2);
            Console.WriteLine($"A média ponderada é {Media}.");
        }


    }
}
