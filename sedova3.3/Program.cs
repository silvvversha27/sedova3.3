using System;

namespace sedova3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 0, h = 2; i < n; i++, h += 2)
                {
                    long F = 1;
                    for (int j = 1; j <= h; j++) F *= j;
                    if (i % 2 == 0) S += -Math.Pow(2 * x, h) / F;
                    else S += Math.Pow(2 * x, h) / F;
                }
                Console.WriteLine("S={0:f2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
