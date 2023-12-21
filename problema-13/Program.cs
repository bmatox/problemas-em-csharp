// exercicio proposto 09 - Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar
// um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um
// programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
// Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o
// lucro total.
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n, cont1, cont2, cont3;
        double lucro, somacompras, somavendas, lucrototal;
        somacompras = 0.0;
        somavendas = 0.0;
        lucrototal = 0.0;

        n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        double[] precompras = new double[n];
        double[] prevendas = new double[n];

        // leitura dos dados
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            nomes[i] = s[0];
            precompras[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
            prevendas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
        }

        cont1 = 0;
        cont2 = 0;
        cont3 = 0;

        for (int i = 0; i < n; i++)
        {
            lucro = (prevendas[i] - precompras[i]) / precompras[i];
            lucrototal += (prevendas[i] - precompras[i]);
            if (lucro < 0.1)
            {
                cont1++;
            }
            else if (lucro >= 0.1 && lucro <= 0.2)
            {
                cont2++;
            }
            else if (lucro > 0.2)
            {
                cont3++;
            }         
        }

        for (int i = 0; i < n; i++)
        {
            somacompras += precompras[i];
            somavendas += prevendas[i];
        }

        Console.WriteLine("\nLucro abaixo de 10%: " + cont1);
        Console.WriteLine("Lucro entre 10% e 20%: " + cont2);
        Console.WriteLine("Lucro acima de 20%: " + cont3);
        Console.WriteLine("Valor total de compra: " + somacompras.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valortotal de venda: " + somavendas.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Lucro total: " + lucrototal.ToString("F2", CultureInfo.InvariantCulture));
    }
}