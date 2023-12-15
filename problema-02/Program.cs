// URI 1019 
internal class Program
{
    private static void Main(string[] args)
    {

        int tempo, horas, min, seg, rest1;
        
        tempo = int.Parse(Console.ReadLine());

        horas = tempo / 3600;
        rest1 = tempo % 3600;
        min = rest1 / 60;
        seg = rest1 % 60;

        Console.WriteLine(horas + ":" + min + ":" + seg);
    }
}