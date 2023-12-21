
// problema do bloco 04 - 5m32seg
internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];

        // armazenando valores no vetor
        for (int i = 0; i < n; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        // mostrando valores negativos do vetor no console
        for (int i = 0; i < n; i++)
        {
            if (vet[i] < 0)
            {
                Console.WriteLine(vet[i]);
            }
        }

    }
}