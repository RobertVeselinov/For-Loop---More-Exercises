using System;

namespace P07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fansQuantity = int.Parse(Console.ReadLine());
            string sector = string.Empty;

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 1; i <= fansQuantity; i++)
            {
                sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            double sum = sectorA + sectorB + sectorG + sectorV;
            Console.WriteLine($"{(double)sectorA / fansQuantity * 100:f2}%");
            Console.WriteLine($"{(double)sectorB / fansQuantity * 100:f2}%");
            Console.WriteLine($"{(double)sectorV / fansQuantity * 100:f2}%");
            Console.WriteLine($"{(double)sectorG / fansQuantity * 100:f2}%");
            Console.WriteLine($"{sum / stadiumCapacity * 100:f2}%");

        }
    }
}
