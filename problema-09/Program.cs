// Dado um número inteiro ‘n’, escreva um programa que leia ‘n’ valores inteiros e armazene-os em um vetor.
// Em seguida, imprima os valores do vetor na ordem em que foram lidos.
internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
      
        for (int i = 0; i < n; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vet[i]);
        }

    }
}