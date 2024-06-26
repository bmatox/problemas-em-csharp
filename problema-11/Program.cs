﻿// Dado um número inteiro ‘n’, escreva um programa que leia ‘n’ valores decimais e armazene-os em um vetor.
// Em seguida, imprima: os valores do vetor com uma casa decimal, a soma desses valores com duas casas decimais
// e a média dos valores também com duas casas decimais.

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        double soma, media;
        soma = 0.0;
        media = 0.0;
        n = int.Parse(Console.ReadLine());
        double[] vet = new double[n];
        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture); // CultureInfo para receber os decimais dos elementos "double" separados por ponto.
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            soma += vet[i];
        }
        Console.WriteLine();
        media = soma / (double) n;

        Console.WriteLine("Soma dos números digitados: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Média dos valores digitados: " + media.ToString("F2", CultureInfo.InvariantCulture));
             
    }
}