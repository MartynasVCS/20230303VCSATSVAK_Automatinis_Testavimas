using System;

namespace Skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Skaiciuotuvas.Dalyba(1, 3) == 0.3333333333333)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }

    public class Skaiciuotuvas
    {
        public static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        public static int Sandauga(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }

        public static double SandaugaDu(double skaicius1, double skaicius2)
        {
            return skaicius1 * skaicius2;
        }

        public static double SandaugaTrys(double skaicius1, double skaicius2, double skaicius3)
        {
            return skaicius1 * skaicius2 * skaicius3;
        }

        public static int Skirtumas(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        public static int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }

        public static double SumaDu(double skaicius1, double skaicius2)
        {
            return skaicius1 + skaicius2;
        }

        public static double SumaTrys(double skaicius1, double skaicius2, double skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;
        }

        public static double SumaTrysRounded(double skaicius1, double skaicius2, double skaicius3)
        {
            return Math.Round(skaicius1 + skaicius2 + skaicius3, 5);
        }

        public static decimal SumaTrysDecimal(decimal skaicius1, decimal skaicius2, decimal skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;
        }
    }
}
