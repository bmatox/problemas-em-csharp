// URI 1071
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