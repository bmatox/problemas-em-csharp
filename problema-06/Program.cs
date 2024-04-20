// Dado um conjunto de números inteiros positivos, escreva um programa que leia esses números da entrada
// padrão até que um número negativo seja inserido. Em seguida, calcule e imprima a média dos números
// positivos (excluindo o número negativo). A média deve ser arredondada para 2 casas decimais.

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int idade, num, soma;
        double media;
        soma = 0;
        num = 0;
        media = 0.0;

        idade = int.Parse(Console.ReadLine());
        if (idade < 0)
        {
            Console.WriteLine("Impossível calcular!");

        }
        while (idade >= 0)
        {
            soma += idade;
            num += 1;
            idade = int.Parse(Console.ReadLine());

        }

        media = (soma / (double)num);

        Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}