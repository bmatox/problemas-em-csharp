// URI 1078: Dado um número inteiro ‘n’, escreva um programa que imprima a tabuada de multiplicação
// de ‘n’ de 1 a 10.
internal class Program
{
    private static void Main(string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 1; i < 11; i++) {
            Console.WriteLine(i + " x " + n + " = " + i*n);
        }
    }
}