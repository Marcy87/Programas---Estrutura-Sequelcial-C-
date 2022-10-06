using System;
using System.Globalization;

namespace Program1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio;
            double area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio,2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}