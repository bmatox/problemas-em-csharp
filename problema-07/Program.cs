// URI 1078
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