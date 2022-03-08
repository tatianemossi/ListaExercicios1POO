using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7.ConsoleApp
{
    internal class Salario
    {
        public decimal SalarioBase;
        public decimal TotalVendas;
        public decimal Comissao;
        public decimal SalarioTotal;

        public void CalcularSalarioTotal()
        {
            SalarioTotal = SalarioBase + (TotalVendas * Comissao);
            Console.WriteLine($"O salário total é de R${SalarioTotal}");
        }
    }
}
