﻿// URI 1113

internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;

        string[] vet = Console.ReadLine().Split(' ');
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        while (x != y)
        {

            if (x > y)
            {
                Console.WriteLine("Decrescente!");
            }
            else
            {
                Console.WriteLine("Crescente!");
            }

            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

        }
    }
}