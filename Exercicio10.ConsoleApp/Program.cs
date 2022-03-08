using System;

namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaPonderada = new MediaPonderada();

            mediaPonderada.PesoNota1 = 10;
            mediaPonderada.PesoNota2 = 10;
            mediaPonderada.Nota1 = 7;
            mediaPonderada.Nota2 = 5;

            mediaPonderada.CalcularMediaPonderada();
            Console.ReadLine();
        }
    }
}
