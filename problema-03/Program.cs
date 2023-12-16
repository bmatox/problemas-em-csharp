// Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual.
// Em seguida, calcular a média e mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo.
// Caso a nota final do aluno seja inferior a 6, mostrar a mensagem "REPROVADO" ou "APROVADO", conforme exemplos.
// Todos os valores devem ter uma casa decimal.

using System.Globalization;

internal class Program {
    private static void Main(string[] args)
    {
        while (true)
        {
            double n1, n2, notafinal;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            notafinal = (n1 + n2) / 2;

            if (notafinal < 6)
            {
                Console.WriteLine("\nNOTA FINAL: " + notafinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("\nNOTA FINAL: " + notafinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }

            Console.WriteLine();

        }
    }
}