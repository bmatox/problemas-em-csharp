﻿// URI 1036
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, delta, r1, r2;

        String[] vet = Console.ReadLine().Split(' ');

        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossível calcular.");
        } else
        {
            r1 = ((-b + Math.Sqrt(delta))/(2 * a));
            r2 = ((-b - Math.Sqrt(delta)) / (2 * a));

            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));

        }

    }
}