using System;
using System.Globalization;

namespace Program1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumoMed;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMed = X / Y;

            Console.WriteLine(consumoMed.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}