using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera1 = new Esfera();
            esfera1.Raio = 7;

            esfera1.ObtemVolume();
            Console.WriteLine($"O volume da esfera é de: {esfera1.VolumeDaEsfera}");
            Console.ReadLine();
        }
    }
}
