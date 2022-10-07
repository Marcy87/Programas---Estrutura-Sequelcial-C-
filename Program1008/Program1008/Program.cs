using System;
using System.Globalization;

namespace Program1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double valor, salario;

            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}