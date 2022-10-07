using System;
using System.Globalization;

namespace Program1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempGastoHoras, velocidadeMedia;
            double qtdLitros, distanciaPercorrida;

            tempGastoHoras = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = velocidadeMedia * tempGastoHoras;

            qtdLitros = distanciaPercorrida / 12;

            Console.WriteLine(qtdLitros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}