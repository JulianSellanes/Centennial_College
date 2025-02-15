using System;

//Julian Sellanes (301494667)

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 28000;
            double anualDepreciation = 4000;
            int year = 1;

            Console.WriteLine("                       END-OF-YEAR   ACCUMULATED");
            Console.WriteLine("YEAR   DEPRECIATION       VALUE      DEPRECIATION");
            Console.WriteLine("----   ------------   ------------   ------------");

            do
            {
                double accumulatedDepreciation = anualDepreciation * year;
                double depreciatedValue = initialValue - accumulatedDepreciation;
                Console.WriteLine($"{year,2} {anualDepreciation,12} {depreciatedValue,15} {accumulatedDepreciation,13}");
                year++;
            }
            while (year <= 7);
        }
    }
}
