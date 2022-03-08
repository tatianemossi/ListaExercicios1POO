using System;

namespace Exercicio8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo soya = new LataDeOleo();
            soya.Altura = 10;
            soya.Raio = 7;

            soya.ObtemVolume();
            Console.ReadLine();
        }
    }
}
