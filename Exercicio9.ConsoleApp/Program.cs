using System;

namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica1 = new MediaHarmonica();
            mediaHarmonica1.QuantidadeDeElementos = 5;

            mediaHarmonica1.CalcularMediaHarmonica();
            Console.ReadLine();
        }
    }
}
