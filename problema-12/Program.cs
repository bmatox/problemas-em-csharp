// Exercício proposto 07 - Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
// Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
// Considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        double somanotas, media;
        somanotas = 0.0;
        media = 0.0;

        n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        double[] notas1 = new double[n];
        double[] notas2 = new double[n];

        // leitura dos dados
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            nomes[i] = s[0];
            notas1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
            notas2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
        }

        Console.WriteLine("\nAlunos aprovados: ");
        Console.WriteLine("");
        // calculo das medias
        for (int i = 0; i < n; i++)
        {
            media = (notas1[i] + notas2[i]) / 2.00;
            if (media >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }


    }
}