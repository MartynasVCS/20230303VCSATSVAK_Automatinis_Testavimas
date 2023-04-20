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

        internal static int Sandauga(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }

        internal static int Skirtumas(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        internal static int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }
}
