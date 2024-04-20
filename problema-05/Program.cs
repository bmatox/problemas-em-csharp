// URI 1113: Dado dois números inteiros ‘x’ e ‘y’, escreva um programa que compare esses valores e
// imprima “Decrescente!” se ‘x’ for maior que ‘y’, ou “Crescente!” se ‘x’ for menor que ‘y’.
// O programa deve continuar lendo novos valores de ‘x’ e ‘y’ até que ‘x’ seja igual a ‘y’.

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