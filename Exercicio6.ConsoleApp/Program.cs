using System;

namespace Exercicio6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCelsiusParaFahrenheit conversor1 = new ConversorCelsiusParaFahrenheit();
            conversor1.Celsius = 5;

            conversor1.ConversorCelsiusToFahrenheit();
            Console.ReadLine();
        }
    }
}
