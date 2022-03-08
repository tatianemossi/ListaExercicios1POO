using System;

namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario1 = new Salario();
            salario1.SalarioBase = 1000;
            salario1.TotalVendas = 100;
            Console.WriteLine("Digite o percentual de comissão: ");
            salario1.Comissao = Convert.ToDecimal(Console.ReadLine());

            salario1.CalcularSalarioTotal();
            Console.ReadLine();

        }
    }
}
