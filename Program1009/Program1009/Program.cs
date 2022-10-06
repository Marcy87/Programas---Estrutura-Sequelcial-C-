using System;
using System.Globalization;

namespace Program1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double totalMes, salarioFixo, total, comissao;

            nome = Console.ReadLine();
            totalMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = (salarioFixo * 15) / 100;
            total = comissao + totalMes;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}