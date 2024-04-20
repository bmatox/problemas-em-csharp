// URI 1071: Dado dois números inteiros ‘x’ e ‘y’, escreva um programa que calcule a soma de todos os números ímpares
// entre ‘x’ (exclusivo) e ‘y’ (exclusivo). Se ‘x’ for maior que ‘y’, troque os valores antes de calcular a soma.
internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, soma;
        soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        for (int i = (x + 1); i < y; i++)
        {
            if ((i % 2) != 0)
            {
                soma += i;
            }

        }
        Console.WriteLine(soma);
    }
}