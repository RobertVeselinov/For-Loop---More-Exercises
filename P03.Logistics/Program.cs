using System;

namespace P03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ton1 = 0;
            double vanTon = 0;
            double truckTon = 0;
            double trainTon = 0;
            double vanPrice = 0;
            double truckPrice = 0;
            double trainPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                int ton2 = int.Parse(Console.ReadLine());
                ton1 += ton2;
                if (ton2 <= 3)
                {
                    vanPrice += ton2 * 200;
                    vanTon += ton2;
                }
                else if (ton2 >= 4 && ton2 <= 11)
                {
                    truckPrice += ton2 * 175;
                    truckTon += ton2;
                }
                else if (ton2 >= 12)
                {
                    trainPrice += ton2 * 120;
                    trainTon += ton2;
                }
            }
            double priceAll = vanPrice + truckPrice + trainPrice;
            double priceAllAverage = priceAll / ton1;
            double procentVan = vanTon / ton1 * 100;
            double procentTruck = truckTon / ton1 * 100;
            double procentTrain = trainTon / ton1 * 100;

            Console.WriteLine($"{priceAllAverage:f2}");
            Console.WriteLine($"{procentVan:f2}%");
            Console.WriteLine($"{procentTruck:f2}%");
            Console.WriteLine($"{procentTrain:f2}%");
        }
    }
}
