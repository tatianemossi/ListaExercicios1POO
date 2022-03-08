using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veículo veiculo1 = new Veículo();
            veiculo1.KmInicial = 30;
            veiculo1.KmFinal = 140;
            veiculo1.QtdCombustivelGasto = 50;

            veiculo1.CalcularConsumo();
            Console.WriteLine($"O consumo é de {veiculo1.Consumo}");
            Console.ReadLine();
        }
    }
}
