using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6.ConsoleApp
{
    internal class ConversorCelsiusParaFahrenheit
    {
        public decimal Celsius;       

        public void ConversorCelsiusToFahrenheit()
        {
            decimal Fahrenheit = (Celsius * (9 / 5)) + 32;
            Console.WriteLine($"A temperatura em graus Fahrenheit é de: {Fahrenheit}");
        }

    }
}
