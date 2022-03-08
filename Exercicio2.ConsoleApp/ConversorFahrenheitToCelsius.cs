using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.ConsoleApp
{
    internal class ConversorFahrenheitToCelsius
    {
        public double Fahrenheit;

        public void ConversorFahrenheitParaCelsius()
        {
            double celsius = (Fahrenheit - 32) / 1.8;
            Console.WriteLine($"A temperatura em graus Celsius é de: {celsius}");
        }
    }
}
