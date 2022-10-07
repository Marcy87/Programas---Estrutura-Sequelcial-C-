using System;
using System.Globalization;

namespace Program1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, num1, cod2, num2;
            double valUni1, valUni2, total;

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            cod1 = int.Parse(vet1[0]);
            num1 = int.Parse(vet1[1]);
            valUni1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            cod2 = int.Parse(vet2[0]);
            num2 = int.Parse(vet2[1]);
            valUni2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (num1 * valUni1) + (num2 * valUni2);


            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
         }
    }
}