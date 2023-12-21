// Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
// Entrada:
// A entrada contém os números M e N na mesma linha, depois os dados da matriz.
// Saída:
// A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.
internal class Program
{
    private static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int M = int.Parse(valores[0]);
        int N = int.Parse(valores[1]);

        int[,] mat = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            valores = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                mat[i, j] = int.Parse(valores[j]);
            }
        }

        Console.WriteLine("VALORES NEGATIVOS:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (mat[i, j] < 0)
                {
                    Console.WriteLine(mat[i, j]);
                }
            }
        }
    }
}