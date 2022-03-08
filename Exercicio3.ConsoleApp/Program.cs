using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro1 = new Cilindro();
            cilindro1.Altura = 13;
            cilindro1.Raio = 7;

            cilindro1.ObtemVolume();
            Console.WriteLine($"O volume do cilindo é de {cilindro1.volumeDoCilindro}");
            Console.ReadLine();
        }
    }
}
