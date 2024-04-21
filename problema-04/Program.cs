// URI 1036: Dado três números de ponto flutuante representando os coeficientes de uma equação quadrática (a, b e c), escreva um programa
// que calcule e imprima as raízes da equação usando a fórmula quadrática. Se o discriminante for negativo ou se o coeficiente ‘a’ for igual
// a zero, imprima “Impossível calcular.” Caso contrário, imprima as raízes no formato especificado.

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, delta, r1, r2;

        String[] vet = Console.ReadLine().Split(' ');

        Console.Write("Digite o primeiro coeficiente: ");
        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        Console.Write("Digite o segundo coeficiente: ");
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        Console.Write("Digite o terceiro coeficiente: ");
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