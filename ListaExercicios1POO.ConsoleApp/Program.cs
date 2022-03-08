using System;

namespace ListaExercicios1POO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();
            caixa.Altura = 10;
            caixa.Largura = 15;
            caixa.Comprimento = 20;

            caixa.ObtemVolume();
            Console.WriteLine($"O volume da caixa é de {caixa.VolumeTotal}");
            Console.ReadLine();

        }
    }
}
