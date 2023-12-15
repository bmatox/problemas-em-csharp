
using System.Globalization;
// URI 1008

namespace problemas_em_csharp
{

    internal class problema_01
    {
        private static void Main(string[] args)
        {

            int num, horastrab;
            double valorh, salario;

            num = int.Parse(Console.ReadLine());
            horastrab = int.Parse(Console.ReadLine());
            valorh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horastrab * valorh;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}