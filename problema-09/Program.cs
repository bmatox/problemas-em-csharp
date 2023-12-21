// problema do bloco 03 - 
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