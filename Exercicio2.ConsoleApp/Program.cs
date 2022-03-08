using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorFahrenheitToCelsius conversor1 = new ConversorFahrenheitToCelsius();
            conversor1.Fahrenheit = 291;

            conversor1.ConversorFahrenheitParaCelsius();
            Console.ReadLine();
        }
    }
}
